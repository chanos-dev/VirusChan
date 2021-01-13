using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Model;

namespace VirusChan.Api
{
    public class ApiController
    {
        private FileAPI FileAPI { get; set; } = new FileAPI();

        private UrlAPI UrlAPI { get; set; } = new UrlAPI();

        public FileScan FileReport(string resource)
        {
            return FileAPI.FileReport(resource);
        }

        public ApiController(string apiKey)
        {
            BaseAPI.ApiKey = apiKey;
        }
    }
}
