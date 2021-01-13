using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Model
{
    class FileFormat
    {
        public string FileName { get; set; }
        public long FileSize { get; set; } 
        public string FileFullPath { get; set; }
        public VirusTotalState FileState { get; set; }
        public FileScan FileScan { get; set; }
    }
}
