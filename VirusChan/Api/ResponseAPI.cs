using System.Net;

namespace VirusChan.Api
{
    class ResponseAPI
    {
        public string Result { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
