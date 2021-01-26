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

namespace VirusChan.form
{
    public partial class FormUrls : UserControl
    {
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
                UrlScan urlScan = ApiController.UrlReport(txt_Urls.Text);

                
            });
        }
    }
}
