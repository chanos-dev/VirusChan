using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Interface
{
    public interface IFormat
    {
        string GetName();
        string GetUnique();
        IScan GetScan();
    }
}
