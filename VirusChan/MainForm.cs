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
    } 
}
