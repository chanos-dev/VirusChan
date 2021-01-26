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
    public partial class FormSummary : UserControl
    {
        public FormSummary(FileScan fileScan)
        {
            InitializeComponent();
        }
    }
}
