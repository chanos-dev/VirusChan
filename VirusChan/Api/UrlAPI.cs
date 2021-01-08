using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Api
{
    class UrlAPI : BaseAPI
    {
        protected override string[] ApiUrl => new string[] { "vtapi", "v2", "url" };
    }
}
