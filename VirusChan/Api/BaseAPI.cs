using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Api
{
    public abstract class BaseAPI
    { 
        public static string ApiKey { get; set; }

        protected int TimeOut => 3000;

        protected string BaseURL => "https://www.virustotal.com";

        protected abstract string[] ApiUrl { get; }

        protected string[] ApiParams { get; set; }

        protected string GetParamsURL(Dictionary<string, string> param) => string.Join("&", param.Select(item => $"{item.Key}={item.Value}"));

        protected string GetFullAPIURL() => string.Join("/", Enumerable.Concat(new string[] { BaseURL }, this.ApiUrl).Concat(ApiParams)); 

        protected string GetFullAPIURL(Dictionary<string, string> ApiParams)
        {
            string ApiUrl = string.Join("/", Enumerable.Concat(new string[] { BaseURL }, this.ApiUrl).Concat(this.ApiParams));
            string ParamsURL = GetParamsURL(ApiParams);

            return string.Join("?", new string[] { ApiUrl, ParamsURL }); 
        }
    }
}
