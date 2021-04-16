using CodebaseView.Git_REST_API.API_Objects;
using CodebaseView.Git_REST_API.API_Objects.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView.Git_REST_API
{
    public class GitAPIExecutor
    {
        public string url = string.Empty;

        public GitAPIExecutor(string url)
        {
            this.url = url;
        }

        public Repository execute()
        {
            HttpWebRequest webRequest = System.Net.WebRequest.Create(this.url) as HttpWebRequest;
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
                        Repository repo = JsonConvert.DeserializeObject<Repository>(reader);
                        return repo;
                        
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;

        }
    }
}
