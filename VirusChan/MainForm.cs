using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusChan.Api;
using VirusChan.form;
using VirusChan.Model;

namespace VirusChan
{
    public partial class MainForm : Form
    {
        enum ButtonType
        {
            Files,
            Urls,
        }

        enum FormType
        {
            FormFile,
            FormUrl,
        }

        private FormFiles formFile;
        private FormUrls formUrls;
        private ApiController ApiController;

        public MainForm()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            ApiController = new ApiController("your virustotal api key");

            formFile = new FormFiles(ApiController);
            formUrls = new FormUrls(ApiController);

            this.Controls.Add(formFile);
            this.Controls.Add(formUrls);

            formFile.Parent = this.panel_forms;
            formUrls.Parent = this.panel_forms;

            //default
            ShowSelectedForm(FormType.FormFile);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileAPI fileAPI = new FileAPI(); 
            var test = fileAPI.FileReport("key");                   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            } 

            this.Show();
        } 

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pb_minimum_Click(object sender, EventArgs e)
        {            
            this.WindowState = FormWindowState.Minimized;
        }

        private void MoveSelectedPanel(ButtonType type)
        {
            switch (type)
            {
                case ButtonType.Files:
                    panel_selected.Left = btn_files.Left;
                    break;
                case ButtonType.Urls:
                    panel_selected.Left = btn_urls.Left;
                    break;
            }
        }

        private void ShowSelectedForm(FormType type)
        {
            switch (type)
            {
                case FormType.FormFile:
                    formFile.Visible = true;
                    formUrls.Visible = false;
                    break;
                case FormType.FormUrl:
                    formFile.Visible = false;
                    formUrls.Visible = true;
                    break;
            }
        }

        private void btn_files_Click(object sender, EventArgs e)
        { 
            MoveSelectedPanel(ButtonType.Files);
            ShowSelectedForm(FormType.FormFile);
        } 

        private void btn_urls_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Urls);
            ShowSelectedForm(FormType.FormUrl);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
                button.ForeColor = Color.FromArgb(230, 245, 255);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
                button.ForeColor = Color.FromArgb(63, 130, 242);
        }

        private void FileScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Files);
            ShowSelectedForm(FormType.FormFile);

            notifyIcon_MouseDoubleClick(null, null);
        }

        private void UrlScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Urls);
            ShowSelectedForm(FormType.FormUrl);

            notifyIcon_MouseDoubleClick(null, null);
        }
    } 
}
