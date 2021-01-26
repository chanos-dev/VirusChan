using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Model;
using VirusChan.Model.VirusUrl;

namespace VirusChan.Api
{
    class UrlAPI : BaseAPI
    {
        protected override string[] ApiUrl => new string[] { "vtapi", "v2", "url" };

        public UrlScan UrlReport(string url)
        {
            this.ApiParams = new string[] { "report" };

            Dictionary<string, string> ApiParams = new Dictionary<string, string>()
            {
                ["apikey"] = ApiKey,
                ["resource"] = url
            };

            string URL = GetFullAPIURL(ApiParams);

            ResponseAPI responseAPI = RequestAPI.SendRequest(URL, Method.GET).Result;

            return CreateUrlScan(responseAPI);
        }

        private UrlScan CreateUrlScan(ResponseAPI responseAPI)
        {
            if (responseAPI is null)
                return null;

            if (responseAPI.StatusCode == HttpStatusCode.OK)
            {
                //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
                return JsonConvert.DeserializeObject<UrlScan>(responseAPI.Result);
            }
            else
            {
                return null;
            } 
        }
    }
}
