using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace EventbriteNET.HttpApi
{
    public class RequestBase
    {
        protected EventbriteContext Context;

        private Dictionary<string, string> GetParameters;
        private string Path;

        public string Url
        {
            get
            {
                var builder = new StringBuilder();
                builder.Append(this.Context.Host);
                builder.Append(this.Path);
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

                return builder.ToString();
            }
        }
        
        public RequestBase(string path, EventbriteContext context)
        {
            this.Context = context;

            this.GetParameters = new Dictionary<string, string>();
            this.AddGet("app_key", context.AppKey);

            if (context.UserKey != null)
            {
                this.AddGet("user_key", context.UserKey);
            }
            
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
