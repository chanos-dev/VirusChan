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

namespace VirusChan.form
{
    public partial class FormFiles : UserControl
    {
        private ApiController ApiController;

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

            OLVColumn[] columns = new []
            {
                ListViewData.CreateColumn("FileName", "파일명", "FileName", 150),
                ListViewData.CreateColumn("FileSize", "사이즈", "FileSize", 90),
                ListViewData.CreateColumn("FileState", "상태", "FileState", 50),
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
            }            
        } 

        private void FileListView_FormatRow(object sender, FormatRowEventArgs e)
        {
            if (e.Item.RowObject is FileFormat fileFormat)
            {
                e.Item.ForeColor = Color.FromArgb(230, 245, 255);                 
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (FileListView.Items.Count < 1)
                return;


            //thread file scan 

            foreach(var file in FileListView.Objects)
            {
                if (file is FileFormat fileFormat)
                {
                    if (fileFormat.FileState == VirusTotalState.Ready)
                    {
                        string md5 = VirusTotal.GetMD5(fileFormat.FileFullPath);
                        fileFormat.FileScan = ApiController.FileReport(md5);
                        fileFormat.FileState = VirusTotalState.Finished;
                        FileListView.UpdateObject(fileFormat);
                    }
                }
            }
        }

        private void FileListView_DoubleClick(object sender, EventArgs e)
        {
            if (FileListView.Items.Count < 1)
                return;

            if (FileListView.SelectedObject is FileFormat fileFormat)
            {
                //double click test
                MessageBox.Show(fileFormat.FileScan.sha1);
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

                List<FileFormat> lists = new List<FileFormat>();

                for (int i = 0; i < files.Length; i++)
                {
                    FileFormat file = new FileFormat();
                    file.FileName = Path.GetFileName(files[i]);
                    file.FileSize = File.OpenRead(files[i]).Length;
                    file.FileFullPath = files[i];
                    file.FileState = VirusTotalState.Ready;
                    lists.Add(file);
                } 

                FileListView.SetObjects(lists);
            }
        }
    }
}
