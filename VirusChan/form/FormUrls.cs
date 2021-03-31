using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusChan.Api;
using VirusChan.Model.VirusUrl;
using VirusChan.Model;

namespace VirusChan.form
{
    public partial class FormUrls : UserControl
    {
        private UrlScan UrlScan { get; set; }

        private ApiController ApiController;
        public FormUrls(ApiController ApiController)
        {
            InitializeComponent();
            this.ApiController = ApiController;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Urls.Text))
                return;

            
            Program.logger.Info("URL 스캔 시작");

            Task.Factory.StartNew(() =>
            {
                try
                {
                    ChangeEnabled(btn_start, false);
                    ChangeEnabled(btn_detail, false);

                    UrlScan = ApiController.UrlReport(txt_Urls.Text);

                    if (UrlScan is null)
                    {
                        Program.logger.Error($"{txt_Urls.Text} URL 스캔 에러");
                        return;
                    }

                    Program.logger.Info($"{txt_Urls.Text} URL 스캔 시작");

                    ChangeText(lb_msg, UrlScan.verbose_msg);
                    ChangeText(lb_scanDate, UrlScan.scan_date);

                    if (UrlScan.response_code == 1)
                        ChangeEnabled(btn_detail, true); 

                    Program.logger.Info($"{txt_Urls.Text} URL 스캔 완료");
                }
                finally
                {
                    ChangeEnabled(btn_start, true);
                }
            });
        }

        private void ChangeText(Control control, string text)
        {
            if(control.InvokeRequired)
            {
                control.Invoke(new Action(() => ChangeText(control, text)));
            }
            else
            {
                control.Text = text;
            }
        }

        private void ChangeEnabled(Control control, bool flag)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => ChangeEnabled(control, flag)));
            }
            else
            {
                control.Enabled = flag;
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            UrlFormat urlFormat = new UrlFormat()
            {
                UrlName = txt_Urls.Text,
                UrlScan = this.UrlScan,
            };

            using (FormScanDetail formFileScanDetail = new FormScanDetail(urlFormat))
            {
                formFileScanDetail.ShowDialog();
            }
        }
    }
}
