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
            
        }
    }
}
