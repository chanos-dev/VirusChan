using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Model; 
using VirusChan.Model.VirusFile;
using VirusChan.Model.VirusUrl;

namespace VirusChan.Api
{
    public class ApiController
    { 
        private FileAPI FileAPI { get; set; } = new FileAPI();

        private UrlAPI UrlAPI { get; set; } = new UrlAPI();

        public ApiController(string apiKey)
        {            
            BaseAPI.ApiKey = apiKey;
        }

        public FileScan FileReport(string resource) => FileAPI.FileReport(resource); 

        public FileScan FileScan(string sourceFilePath)
        {
            using (FileStream fs = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                PostFile postFile = new PostFile();
                postFile.FileBytes = new byte[fs.Length];
                fs.Read(postFile.FileBytes, 0, postFile.FileBytes.Length);

                postFile.FileName = Path.GetFileName(sourceFilePath);                

                return FileAPI.FileScan(postFile);
            }
        } 

        public UrlScan UrlReport(string url) => UrlAPI.UrlReport(url); 
    }
}
