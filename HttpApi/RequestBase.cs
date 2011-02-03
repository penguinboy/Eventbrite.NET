using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace EventbriteApi.HttpApi
{
    public class RequestBase
    {
        const string HOST = "https://www.eventbrite.com/xml/";
        static string APIKEY
        {
            get
            {
                if (ConfigurationManager.AppSettings["EventbriteAppKey"] != null)
                {
                    return ConfigurationManager.AppSettings["EventbriteAppKey"];
                }
                throw new Exception("Not EventbriteAppKey found in App.config");
            }
        }

        private Dictionary<string, string> GetParameters;
        private string Path;

        public string Url
        {
            get
            {
                var builder = new StringBuilder();
                builder.Append(HOST);
                builder.Append(Path);
                builder.Append('?');

                var firstKey = true;
                foreach (var key in GetParameters.Keys)
                {
                    builder.Append((firstKey != true) ? "&" : "");
                    builder.Append(key);
                    builder.Append('=');
                    builder.Append(GetParameters[key]);
                    firstKey = false;
                }

                Console.WriteLine(builder.ToString());

                return builder.ToString();
            }
        }
        
        public RequestBase(string path)
        {
            this.GetParameters = new Dictionary<string, string>();
            this.AddGet("app_key", APIKEY);
            
            this.Path = path;
        }

        public RequestBase AddGet(string key, string value)
        {
            if (GetParameters.ContainsKey(key))
            {
                GetParameters.Remove(key);
            }

            GetParameters.Add(key, value);

            return this;
        }

        public RequestBase RemoveGet(string key)
        {
            
            GetParameters.Remove(key);
            return this;
        }

        public string GetResponse()
        {
            var client = new WebClient();
            return client.DownloadString(this.Url);
        }

    }
}
