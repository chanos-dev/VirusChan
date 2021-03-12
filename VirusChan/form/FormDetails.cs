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

namespace VirusChan.form
{
    public partial class FormDetails : UserControl
    {
        private FileScan FileScan { get; set; } = null;

        public FormDetails(FileScan fileScan)
        {
            InitializeComponent();
            this.FileScan = fileScan;
            InitializeContol();
        }

        private void InitializeContol()
        {
            lb_md5Result.Text = FileScan.md5 ?? string.Empty;
            lb_sha1Result.Text = FileScan.sha1 ?? string.Empty;
            lb_sha256Result.Text = FileScan.sha256 ?? string.Empty;
            lb_permalinkResult.Text = FileScan.permalink ?? string.Empty;
        }
    }
}
