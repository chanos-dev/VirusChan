using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusChan.Model;

namespace VirusChan.form
{
    enum ButtonType
    {
        Summary,
        Detection,
        Details
    }

    enum FormType
    {
        Summary,
        Detection,
        Details
    }

    public partial class FormFileScanDetail : Form
    {
        private Point mousePoint { get; set; }
        private FileScan FileScan { get; set; } = null;

        private FormSummary FormSummary { get; set; } = null;
        private FormDetection FormDetection { get; set; } = null;     

        public FormFileScanDetail(FileScan fileScan)
        {
            InitializeComponent();            
            this.FileScan = fileScan;
            InitializeControl();
        }

        private void InitializeControl()
        {
            FormSummary = new FormSummary(FileScan);
            FormDetection = new FormDetection(FileScan);

            this.Controls.Add(FormSummary);
            this.Controls.Add(FormDetection);

            FormSummary.Parent = this.panel_forms;
            FormDetection.Parent = this.panel_forms;

            ShowSelectedForm(FormType.Summary);
        }

        private void ShowSelectedForm(FormType type)
        {
            switch (type)
            {
                case FormType.Summary:
                    FormSummary.Visible = true;
                    FormDetection.Visible = false;
                    break;
                case FormType.Detection:
                    FormSummary.Visible = false;
                    FormDetection.Visible = true;
                    break;
            }
        }

        private void pb_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void MoveSelectedPanel(ButtonType type)
        {
            switch (type)
            {
                case ButtonType.Summary:
                    panel_selected.Left = btn_Summary.Left;
                    break;
                case ButtonType.Detection:
                    panel_selected.Left = btn_Detection.Left;
                    break;
                case ButtonType.Details:
                    panel_selected.Left = btn_Details.Left;
                    break;
            }
        }

        private void btn_Summary_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Summary);
            ShowSelectedForm(FormType.Summary);
        }

        private void btn_Detection_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Detection);
            ShowSelectedForm(FormType.Detection);
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            MoveSelectedPanel(ButtonType.Details);
        }
    }
}
