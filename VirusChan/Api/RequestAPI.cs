using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Api
{
    enum Method
    {
        GET,
        POST
    } 

    class RequestAPI
    {
        private static int TimeOut => 3000;

        public static ResponseAPI SendRequest(string URL, Method method)
        {
            try
            {
                ResponseAPI response = new ResponseAPI();

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                httpWebRequest.Timeout = TimeOut;
                httpWebRequest.Method = method.ToString();

                if (method == Method.GET)
                {
                    HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response.Result = streamReader.ReadToEnd();
                        response.StatusCode = httpWebResponse.StatusCode;
                    }
                }

                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}
