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
    }
}
