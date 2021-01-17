using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using VirusChan.Model;
using System.Threading;
using System.Reflection;

namespace VirusChan.form
{
    public partial class FormDetection : UserControl
    {
        private FileScan FileScan { get; set; } = null;
        public FormDetection(FileScan fileScan)
        {
            InitializeComponent();
            this.FileScan = fileScan;
            InitializeControl(); 
            
            PropertyInfo[] propertyInfos = FileScan.scans.GetType().GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            { 
                string engine = propertyInfo.Name;
                bool detected = false;
                string version = "";
                string result = "";
                string update = "";  
                
            }

            SettingDetectionList();
        } 

        private void InitializeControl()
        {
            DetectionListView.FullRowSelect = true;
            DetectionListView.ShowGroups = false;
            DetectionListView.HeaderUsesThemes = false;
            DetectionListView.HideSelection = true;

            OLVColumn[] columns = new[]
            {
                ListViewData.CreateColumn("DetectionEngine", "탐지엔진", "DetectionEngine", 265),
                ListViewData.CreateColumn("DetectionResult", "결과", "DetectionResult", 265),
            };
             
            ColumnHeader[] headers = new ColumnHeader[columns.Length];

            for (int idx = 0; idx < columns.Length; idx++)
            {
                headers[idx] = columns[idx];
                DetectionListView.AllColumns.Add(columns[idx]);
            }

            DetectionListView.Columns.AddRange(headers);
        }

        private void SettingDetectionList()
        {
            Task.Factory.StartNew(() =>
            {
                ShowProcess(true);

                List<Detection> detections = new List<Detection>();
                PropertyInfo[] propertyInfos = FileScan.scans.GetType().GetProperties();

                foreach(PropertyInfo propertyInfo in propertyInfos)
                {                    
                    if (propertyInfo.PropertyType == typeof(Bkav))
                    {

                    }
                    string engine = propertyInfo.Name;
                    bool detected = false;
                    string version = "";
                    string result = "";
                    string update = "";

                    detections.Add(Detection.CreateDetection(engine, detected, version, result, update));
                }

            }).ContinueWith(e =>
            {
                ShowProcess(false);
            });
        }

        private void ShowProcess(bool flag)
        {
            if (pb_process.InvokeRequired)
            {
                pb_process.Invoke(new Action(() => ShowProcess(flag)));
            }
            else
            {
                pb_process.Visible = flag;
            }
        }
    }
}