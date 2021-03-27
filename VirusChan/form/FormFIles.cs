using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VirusChan.Model;
using BrightIdeasSoftware;
using VirusChan.Api;
using VirusChan.Properties;
using System.Threading;
using System.Diagnostics;

namespace VirusChan.form
{
    public partial class FormFiles : UserControl
    { 
        private ApiController ApiController;

        private const int FixedFileSize = 1024 * 1024 * 32;

        public delegate void ShowBallonTip(string title, string contents);
        public event ShowBallonTip ShowBallonTipHandler;

        public FormFiles(ApiController ApiController)
        {
            InitializeComponent();
            InitializeControl();

            this.ApiController = ApiController;
        }

        private void InitializeControl()
        {
            //setting listview  
            FileListView.FullRowSelect = true;
            FileListView.ShowGroups = false;
            FileListView.HeaderUsesThemes = false;
            FileListView.HideSelection = true;

            FileListView.ItemSelectionChanged += FileListView_ItemSelectionChanged;

            OLVColumn[] columns = new []
            {
                ListViewData.CreateColumn("FileName", "파일명", "FileName", 150),
                ListViewData.CreateColumn("FileSize", "사이즈", "FileSize", 75),
                ListViewData.CreateColumn("FileState", "상태", "FileState", 65),
            };            

            ColumnHeader[] headers = new ColumnHeader[columns.Length];

            for(int idx=0; idx<columns.Length; idx++)
            {                
                headers[idx] = columns[idx]; 
                FileListView.AllColumns.Add(columns[idx]);
            }

            FileListView.Columns.AddRange(headers); 
        } 

        private void panel_main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void panel_main_DragDrop(object sender, DragEventArgs e)
        {
            //limit <= 32MB
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

                List<FileFormat> lists = new List<FileFormat>();

                for (int i=0; i<files.Length; i++)
                {
                    FileFormat file = new FileFormat();
                    file.FileName = Path.GetFileName(files[i]);
                    file.FileSize = File.OpenRead(files[i]).Length;
                    file.FileFullPath = files[i];
                    file.FileState = VirusTotalState.Ready;
                    lists.Add(file);
                }

                FileListView.SetObjects(lists);

                lb_dragndrop.Visible = false;
            }            
        }

        private void FileListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) 
                e.Item.BackColor = Color.FromArgb(0, 120, 215); 
            else 
                e.Item.BackColor = Color.FromArgb(63, 130, 242); 
        }

        private void FileListView_FormatRow(object sender, FormatRowEventArgs e)
        {
            if (e.Item.RowObject is FileFormat fileFormat) 
                e.Item.ForeColor = Color.FromArgb(230, 245, 255);
        }

        private void btn_start_Click(object sender, EventArgs e)
        { 
            if (FileListView.Items.Count < 1)
                return;

            Program.logger.Info("파일 스캔 시작");
            
            Task.Factory.StartNew(() =>
            {  
                Parallel.ForEach(FileListView.Objects.Cast<FileFormat>(), fileFormat =>
                { 
                    Program.logger.Info($"{fileFormat.FileFullPath} 파일 스캔 시작");

                    fileFormat.FileState = VirusTotalState.Working;
                    FileListView.UpdateObject(fileFormat);

                    string fileMD5 = VirusTotal.GetMD5(fileFormat.FileFullPath);
                    fileFormat.FileScan = ApiController.FileReport(fileMD5);

                    if (fileFormat.FileScan is null)
                    {
                        Program.logger.Error($"{fileFormat.FileFullPath} 파일 스캔 에러");
                        fileFormat.FileState = VirusTotalState.Error;
                        FileListView.UpdateObject(fileFormat);
                    }
                    else
                    {
                        if (fileFormat.FileScan.response_code == 0)
                        {
                            //파일 스캔
                            Program.logger.Info($"{fileFormat.FileFullPath} 파일 최초 스캔 필요, 스캔 중");
                            fileFormat.FileScan = ApiController.FileScan(fileFormat.FileFullPath);
                        }

                        if (fileFormat.FileScan.response_code == -2 || (fileFormat.FileScan.response_code == 1 && fileFormat.FileScan.scans is null))
                        {
                            Program.logger.Info($"{fileFormat.FileFullPath} 파일 탐색 리스트 큐 추가, 스캔 중");
                            while (true)
                            {
                                Thread.Sleep(10000);
                                fileFormat.FileScan = ApiController.FileReport(fileMD5);

                                if (fileFormat.FileScan != null)
                                {
                                    if (fileFormat.FileScan.response_code == 1)
                                    {
                                        ShowBallonTipHandler?.Invoke("스캔 완료", $"{fileFormat.FileName} : 스캔 완료");
                                        break;
                                    }
                                }
                                Program.logger.Info($"{fileFormat.FileFullPath} 파일 스캔 중");
                            }
                        }

                        Program.logger.Info($"{fileFormat.FileFullPath} 파일 스캔 완료");
                        fileFormat.FileState = VirusTotalState.Finished;
                        FileListView.UpdateObject(fileFormat);
                    } 
                });
            });          
        }

        private void UpdateFileListObject(FileFormat fileFormat)
        { 
            if (FileListView.InvokeRequired)
            {
                FileListView.Invoke(new Action(() => UpdateFileListObject(fileFormat)));
            }
            else
            { 
                FileListView.UpdateObject(fileFormat); 
            } 
        }

        private void FileListView_DoubleClick(object sender, EventArgs e)
        {
            if (FileListView.Items.Count < 1)
                return;

            if (FileListView.SelectedObject is FileFormat fileFormat)
            { 
                switch (fileFormat.FileState)
                {
                    case VirusTotalState.Finished:
                        using (FormFileScanDetail formFileScanDetail = new FormFileScanDetail(fileFormat.FileScan))
                        {
                            formFileScanDetail.ShowDialog();
                        }
                        break;
                }                  
            }
        } 

        private void pb_files_MouseLeave(object sender, EventArgs e)
        {
            pb_files.Image = Resources.files;
        }

        private void pb_files_MouseEnter(object sender, EventArgs e)
        {
            pb_files.Image = Resources.files_off;
        }

        private void pb_files_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = true;                
                fileDialog.ShowDialog();
                
                string[] files = fileDialog.FileNames;

                // virustotal api call limit.
                if (files.Count() > 4)
                {
                    MessageBox.Show("최대 4개 파일만 가능합니다.");
                    return;
                }

                if (files.Count() > 0)
                {
                    List<FileFormat> lists = new List<FileFormat>();

                    for (int i = 0; i < files.Length; i++)
                    {
                        FileFormat file = new FileFormat();
                        file.FileName = Path.GetFileName(files[i]);
                        file.FileSize = File.OpenRead(files[i]).Length;                        
                        file.FileFullPath = files[i];
                        if (FixedFileSize > file.FileSize)
                            file.FileState = VirusTotalState.Ready;
                        else
                            file.FileState = VirusTotalState.Error;
                        lists.Add(file);
                    }

                    FileListView.SetObjects(lists);
                    lb_dragndrop.Visible = false;
                }                
            }
        } 
    }
}
