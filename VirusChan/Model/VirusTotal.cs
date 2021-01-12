using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Model
{
    class VirusTotal
    { 
        public static string GetMD5(string filePath)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (Stream stream = File.OpenRead(filePath))
                {                      
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-","");
                }
            }
        }

        public static string GetSHA256(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "");
                }
            }
        }
    }
}
