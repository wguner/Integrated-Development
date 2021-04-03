using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public static class GitlabParser
    {
        public static string getData(string siteUrl)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(siteUrl));
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using(Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
