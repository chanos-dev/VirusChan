using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Model;

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
                ["apikey"] = this.ApiKey,
                ["resource"] = resource
            };

            string URL = GetFullAPIURL(ApiParams);            

            ResponseAPI responseAPI = RequestAPI.SendRequest(URL, Method.GET);    
            
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
