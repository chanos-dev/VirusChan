using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Interface;
using VirusChan.Model.VirusUrl;

namespace VirusChan.Model
{
    public class UrlFormat : IFormat
    {
        public string UrlName { get; set; }
        public UrlScan UrlScan { get; set; }

        public string GetName() => UrlName;

        public IScan GetScan() => UrlScan;

        public string GetUnique() => UrlScan.scan_id;
    }
}
