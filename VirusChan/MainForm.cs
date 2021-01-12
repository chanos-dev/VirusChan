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

namespace VirusChan
{
    public partial class MainForm : Form
    {
        enum ButtonType
        {
            Files,
            Urls
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        { 
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //file full path
                string[] strFiles = (string[])e.Data.GetData(DataFormats.FileDrop);  
            }            
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {             
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            { 
                e.Effect = DragDropEffects.Copy;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileAPI fileAPI = new FileAPI(); 
            var test = fileAPI.FileReport("F25299AF3D51D09D073C588C552C952E");                   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void VirusChanMenuStrip_Opening(object sender, CancelEventArgs e)
        {

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

        private void btn_files_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Files);
        } 

        private void btn_urls_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Urls);
        }
    } 
}
