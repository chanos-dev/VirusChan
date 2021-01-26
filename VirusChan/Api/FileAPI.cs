using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Model;
using VirusChan.Model.VirusFile;

namespace VirusChan.Api
{
    class FileAPI : BaseAPI
    {
        protected override string[] ApiUrl => new string[] { "vtapi", "v2", "file" };

        public FileScan FileReport(string resource)
        {
            this.ApiParams = new string[] { "report" };

            Dictionary<string, string> ApiParams = new Dictionary<string, string>()
            {
                ["apikey"] = ApiKey,
                ["resource"] = resource
            };

            string URL = GetFullAPIURL(ApiParams);            

            ResponseAPI responseAPI = RequestAPI.SendRequest(URL, Method.GET).Result;

            return CreateFileScan(responseAPI);
        } 

        public FileScan FileScan(PostFile file)
        {
            this.ApiParams = new string[] { "scan" };

            string URL = GetFullAPIURL();

            Dictionary<string, object> ApiParams = new Dictionary<string, object>()
            {
                ["file"] = file,
                ["apikey"] = ApiKey
            };

            ResponseAPI responseAPI = RequestAPI.SendRequest(URL, Method.POST, ApiParams).Result;

            return CreateFileScan(responseAPI);
        }

        private FileScan CreateFileScan(ResponseAPI responseAPI)
        {
            if (responseAPI is null)
                return null;

            if (responseAPI.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<FileScan>(responseAPI.Result);
            }
            else
            {
                return null;
            }
        }
    }
}
