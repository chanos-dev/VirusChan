using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Interface;
using VirusChan.Model.VirusFile;

namespace VirusChan.Model
{
    public class FileFormat : IFormat
    {
        public string FileName { get; set; }
        public long FileSize { get; set; } 
        public string FileFullPath { get; set; }
        public VirusTotalState FileState { get; set; }
        public FileScan FileScan { get; set; }

        public string GetName() => $"{FileName} / {FileSize}";

        public IScan GetScan() => FileScan;

        public string GetUnique() => FileScan.sha256;
    }
}
