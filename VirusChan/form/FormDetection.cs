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
using VirusChan.Properties;
using VirusChan.Model.VirusFile;
using VirusChan.Interface;
using VirusChan.Model.VirusUrl;

namespace VirusChan.form
{
    public partial class FormDetection : UserControl
    {
        private IScan Scan { get; set; }

        public FormDetection(IScan scan)
        {
            InitializeComponent();
            Scan = scan;
            InitializeDetectionListView(); 

            switch(scan)
            {
                case FileScan fileScan:
                    InitializeFileScanList();
                    SettingDetectionList(fileScan);
                    break;
                case UrlScan urlScan:
                    InitializeUrlScanList();
                    SettingDetectionList(urlScan);
                    break;
            }
        }

        private void InitializeFileScanList()
        {
            DetectionListView.AllColumns.Clear();
            DetectionListView.Columns.Clear();

            OLVColumn[] columns = new[]
            {
                ListViewData.CreateColumn("DetectionEngine", "탐지엔진", "DetectionEngine", 165),
                ListViewData.CreateColumn("Detected", "탐지", "Detected", 105), //150
                ListViewData.CreateColumn("DetectionVersion", "엔진버전", "DetectionVersion", 100),
                ListViewData.CreateColumn("DetectionResult", "결과", "DetectionResult", 150),
            };

            ColumnHeader[] headers = new ColumnHeader[columns.Length];

            for (int idx = 0; idx < columns.Length; idx++)
            {
                headers[idx] = columns[idx];
                DetectionListView.AllColumns.Add(columns[idx]);
            }

            DetectionListView.Columns.AddRange(headers);
        }

        private void InitializeUrlScanList()
        {
            DetectionListView.AllColumns.Clear();
            DetectionListView.Columns.Clear();

            OLVColumn[] columns = new[]
            {
                ListViewData.CreateColumn("DetectionEngine", "탐지엔진", "DetectionEngine", 165),
                ListViewData.CreateColumn("Detected", "탐지", "Detected", 105), //150 
                ListViewData.CreateColumn("DetectionResult", "결과", "DetectionResult", 150),
            };

            ColumnHeader[] headers = new ColumnHeader[columns.Length];

            for (int idx = 0; idx < columns.Length; idx++)
            {
                headers[idx] = columns[idx];
                DetectionListView.AllColumns.Add(columns[idx]);
            }

            DetectionListView.Columns.AddRange(headers);
        }

        private void InitializeDetectionListView()
        {
            DetectionListView.FullRowSelect = true;
            DetectionListView.ShowGroups = false;
            DetectionListView.HeaderUsesThemes = false;
            DetectionListView.HideSelection = true;
            DetectionListView.UseCellFormatEvents = true; 
        }

        private void SettingDetectionList(FileScan fileScan)
        {
            Task<List<Detection>>.Factory.StartNew(() =>
            {
                ShowProcess(true); 

                List<Detection> detections = new List<Detection>();

                PropertyInfo[] propertyInfos = fileScan.scans.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    if (propertyInfo.GetValue(fileScan.scans, null) is IFileScanInfo fileScanInfo)
                    {                        
                        string engine = propertyInfo.Name;
                        bool detected = fileScanInfo.detected;
                        string version = fileScanInfo.version;
                        string result = fileScanInfo.result?.ToString();
                        string update = fileScanInfo.update;

                        detections.Add(Detection.CreateDetection(engine, detected, version, result, update));
                    }

                    //dynamic DetectionEngineClass = FileScan.scans.GetType().GetProperty(propertyInfo.Name).GetValue(FileScan.scans, null);

                    //if (DetectionEngineClass != null)
                    //{
                    //    string engine = propertyInfo.Name;
                    //    bool detected = DetectionEngineClass.detected;
                    //    string version = DetectionEngineClass.version;
                    //    string result = DetectionEngineClass.result;
                    //    string update = DetectionEngineClass.update;

                    //    detections.Add(Detection.CreateDetection(engine, detected, version, result, update)); 
                    //}
                }

                return detections;
            }).ContinueWith(e =>
            {                
                DetectionListView.SetObjects(e.Result);
                ShowProcess(false);
            });
        }

        private void SettingDetectionList(UrlScan urlScan)
        {
            Task<List<Detection>>.Factory.StartNew(() =>
            {
                ShowProcess(true);

                List<Detection> detections = new List<Detection>();

                PropertyInfo[] propertyInfos = urlScan.scans.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    if (propertyInfo.GetValue(urlScan.scans, null) is IUrlScanInfo fileScanInfo)
                    {
                        string engine = propertyInfo.Name;
                        bool detected = fileScanInfo.detected; 
                        string result = fileScanInfo.result?.ToString(); 

                        detections.Add(Detection.CreateDetection(engine, detected, string.Empty, result, string.Empty));
                    } 
                }

                return detections;
            }).ContinueWith(e =>
            {
                DetectionListView.SetObjects(e.Result);
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

        private void DetectionListView_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.Model is Detection detection)
            {
                if (e.ColumnIndex == 1)
                {
                    if (detection.Detected)
                        e.SubItem.Decoration = new ImageDecoration(Resources.checked_red, 1000, ContentAlignment.MiddleRight);
                    else
                        e.SubItem.Decoration = new ImageDecoration(Resources.checked_green, 1000, ContentAlignment.MiddleRight);
                }
            }
        } 
    }
}