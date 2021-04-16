using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Git_REST_API_Testing
{

   
    public class Git
    {
        private string url = string.Empty;
        public Git(string url)
        {
            this.url = url;
        }

        public string getResponse()
        {
            HttpWebRequest webRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
            if (webRequest != null)
            {
                webRequest.Method = "GET";
                webRequest.UserAgent = "Anything";
                webRequest.ServicePoint.Expect100Continue = false;

                try
                {
                    using (StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
                    {
                        string reader = responseReader.ReadToEnd();
                        //var jsonobj = JsonConvert.DeserializeObject(reader);
                    }
                }
                catch
                {
                    return string.Empty;
                }
            }
            return string.Empty;
        }
    }
}
