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
using System.Drawing.Drawing2D;

namespace VirusChan.form
{
    public partial class FormSummary : UserControl
    {
        private FileFormat FileFormat { get; set; }

        private int CircleWidth => 120;        
        private int inCircleWidthRate => Convert.ToInt32(CircleWidth * 0.25);
        private int CircleY => 30;

        public FormSummary(FileFormat fileFormat)
        {
            FileFormat = fileFormat;

            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            lb_sha256.Text = FileFormat.FileScan.sha256 ?? string.Empty;
            lb_fileInfo.Text = $"{FileFormat.FileName} / {FileFormat.FileSize}";
            lb_scanDate.Text = FileFormat.FileScan.scan_date ?? string.Empty;

            lb_count.Text = $"{FileFormat.FileScan.positives} / {FileFormat.FileScan.total}"; 
            lb_count.Location = new Point((this.Size.Width / 2) - (lb_count.Size.Width / 2), CircleY + (CircleWidth / 2) - (lb_count.Size.Height / 2));

            pnl_Undetected.BackColor = Color.FromArgb(34, 181, 115);

            float part = pnl_Undetected.Size.Width / FileFormat.FileScan.total;
            int positivesParts = Convert.ToInt32(part * FileFormat.FileScan.positives);

            pnl_Detected.Location = pnl_Undetected.Location;
            pnl_Detected.BackColor = Color.FromArgb(255, 31, 74);
            pnl_Detected.Size = new Size(positivesParts, pnl_Detected.Size.Height);
        }

        private void FormSummary_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality; 
            Graphics gh = e.Graphics;
                         
            float part = 360 / FileFormat.FileScan.total;
            int positivesParts = Convert.ToInt32(part * FileFormat.FileScan.positives); 

            using (Pen ellipse = new Pen(SystemColors.Control))
            {  
                Rectangle rect = new Rectangle((this.Size.Width / 2) - (CircleWidth / 2), CircleY, CircleWidth, CircleWidth);

                // Undetected
                gh.DrawEllipse(ellipse, rect);
                gh.FillPie(new SolidBrush(Color.FromArgb(34, 181, 115)), rect, 360, 360);

                // Detected
                gh.DrawEllipse(ellipse, rect);
                gh.FillPie(new SolidBrush(Color.FromArgb(255, 31, 74)), rect, 270, positivesParts);


                rect = new Rectangle((this.Size.Width / 2) - (CircleWidth/2) + (inCircleWidthRate / 2), CircleY + (inCircleWidthRate / 2), CircleWidth - inCircleWidthRate, CircleWidth - inCircleWidthRate);
                gh.DrawEllipse(ellipse, rect);
                gh.FillPie(new SolidBrush(SystemColors.Control), rect, 360, 360);
            } 
        }
    }
}
