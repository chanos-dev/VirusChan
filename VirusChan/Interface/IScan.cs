using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Interface
{
    public interface IScan
    {
        string scan_id { get; set; }
        string resource { get; set; }
        int response_code { get; set; }
        string scan_date { get; set; }
        string permalink { get; set; }
        string verbose_msg { get; set; }
        int positives { get; set; }
        int total { get; set; }
    }
}
