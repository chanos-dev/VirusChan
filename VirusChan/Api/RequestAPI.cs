using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Model;

namespace VirusChan.Api
{
    enum Method
    {
        GET,
        POST
    } 

    class RequestAPI
    {
        private static TimeSpan TimeOut => new TimeSpan(TimeSpan.TicksPerSecond * 3);

        public static async Task<ResponseAPI> SendRequest(string URL, Method method, Dictionary<string, object> RequestBodies = null)
        {
            try
            {
                ResponseAPI response = new ResponseAPI(); 
                
                if (method == Method.GET)
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.Timeout = TimeOut;

                        HttpResponseMessage httpresponse = await httpClient.GetAsync(URL);

                        httpresponse.EnsureSuccessStatusCode();
                        response.Result = httpresponse.Content.ReadAsStringAsync().Result;
                        response.StatusCode = httpresponse.StatusCode;
                    } 
                }
                else if (method == Method.POST)
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.Timeout = TimeOut;

                        HttpResponseMessage httpresponse = await httpClient.PostAsync(URL, CreateMultiPartBodies(RequestBodies));

                        httpresponse.EnsureSuccessStatusCode();
                        httpClient.Dispose();
                        response.Result = httpresponse.Content.ReadAsStringAsync().Result;
                        response.StatusCode = httpresponse.StatusCode;
                    }
                }

                return response;
            }
            catch 
            {
                return null;
            }
        }

        private static MultipartFormDataContent CreateMultiPartBodies(Dictionary<string, object> RequestBodies)
        {
            MultipartFormDataContent multipartForm = new MultipartFormDataContent();

            foreach(var RequestBody in RequestBodies)
            { 
                if (RequestBody.Value is string value)
                { 
                    multipartForm.Add(new StringContent(value), RequestBody.Key);
                }
                else if (RequestBody.Value is PostFile file)
                { 
                    multipartForm.Add(new ByteArrayContent(file.FileBytes, 0, file.FileBytes.Length), RequestBody.Key, file.FileName);
                } 
            } 

            return multipartForm;
        }
    }
}
