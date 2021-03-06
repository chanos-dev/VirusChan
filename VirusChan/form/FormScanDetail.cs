﻿using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusChan.Interface;
using VirusChan.Model; 
using VirusChan.Model.VirusFile;

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

    public partial class FormScanDetail : Form
    {
        private Point mousePoint { get; set; }
        private IFormat ScanFormat { get; set; }   

        private FormSummary FormSummary { get; set; }
        private FormDetection FormDetection { get; set; }
        private FormDetails FormDetails { get; set; }

        public FormScanDetail(IFormat format)
        {           
            InitializeComponent();             

            ScanFormat = format;

            if (ScanFormat is FileFormat)
                lb_title.Text = "파일 스캔 정보";
            else
                lb_title.Text = "사이트 스캔 정보";

            InitializeControl();
        }

        private void InitializeControl()
        {
            FormSummary = new FormSummary(ScanFormat);
            FormDetection = new FormDetection(ScanFormat.GetScan());
            FormDetails = new FormDetails(ScanFormat.GetScan());

            this.Controls.Add(FormSummary);
            this.Controls.Add(FormDetection);
            this.Controls.Add(FormDetails);

            FormSummary.Parent = this.panel_forms;
            FormDetection.Parent = this.panel_forms;
            FormDetails.Parent = this.panel_forms;

            ShowSelectedForm(FormType.Summary);
        }

        private void ShowSelectedForm(FormType type)
        {
            switch (type)
            {
                case FormType.Summary:
                    FormSummary.Visible = true;
                    FormDetection.Visible = false;
                    FormDetails.Visible = false;
                    break;
                case FormType.Detection:
                    FormSummary.Visible = false;
                    FormDetection.Visible = true;
                    FormDetails.Visible = false;
                    break;
                case FormType.Details:
                    FormSummary.Visible = false;
                    FormDetection.Visible = false;
                    FormDetails.Visible = true;
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
            ShowSelectedForm(FormType.Details);
        }
    }
}
