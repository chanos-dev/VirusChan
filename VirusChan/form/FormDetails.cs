using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusChan.Model; 
using VirusChan.Model.VirusFile;
using System.Diagnostics;
using VirusChan.Interface;
using VirusChan.Model.VirusUrl;

namespace VirusChan.form
{
    public partial class FormDetails : UserControl
    {
        private IScan Scan { get; set; }

        public FormDetails(IScan scan)
        {
            Scan = scan;

            InitializeComponent();

            switch(Scan)
            {
                case FileScan fileScan:
                    InitializeFileScanContol(fileScan);
                    break;
                case UrlScan urlScan:
                    InitializeUrlScanContol(urlScan);
                    break;
            }
        }

        private void InitializeUrlScanContol(UrlScan urlScan)
        {
            lb_info1.Text = string.Empty;
            lb_info1Result.Text = string.Empty;

            lb_info2.Text = nameof(urlScan.url).ToUpper();
            lb_info2Result.Text = urlScan.url ?? string.Empty;

            lb_info3.Text = string.Empty;
            lb_info3Result.Text = string.Empty;

            llb_permalinkResult.Text = urlScan.permalink ?? string.Empty;
        }

        private void InitializeFileScanContol(FileScan fileScan)
        {
            lb_info1.Text = nameof(fileScan.md5).ToUpper();
            lb_info1Result.Text = fileScan.md5 ?? string.Empty;

            lb_info2.Text = nameof(fileScan.sha1).ToUpper();
            lb_info2Result.Text = fileScan.sha1 ?? string.Empty;

            lb_info3.Text = nameof(fileScan.sha256).ToUpper();
            lb_info3Result.Text = fileScan.sha256 ?? string.Empty;

            llb_permalinkResult.Text = fileScan.permalink ?? string.Empty;
        } 

        private void label_DoubleClick(object sender, EventArgs e)
        {
            if (sender is Label label) 
                Clipboard.SetText(label.Text); 
        }

        private void llb_permalinkResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llb_permalinkResult.LinkVisited = true; 
            Process.Start(llb_permalinkResult.Text);
        }
    }
}
