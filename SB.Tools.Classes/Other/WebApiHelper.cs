using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using SB.Tools.Classes.Response;

namespace SB.Tools.Classes.Other
{
    public class WebApiHelper
    {
        public const string ChelchelaStatusKeyName = "X-ASP-TModelCode";

        public Response<T> GetObject<T>(string uri)
        {
            Response<T> response = new Response<T>();
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(uri);
                var httpResponse = request.GetResponse();
                if (httpResponse.Headers.AllKeys.Contains(ChelchelaStatusKeyName))
                {
                    string str;
                    using (var stream = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        str = stream.ReadToEnd();
                    }

                    if (httpResponse.Headers[ChelchelaStatusKeyName] == "0")
                    {
                        response.Object = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(str);
                    }
                    else
                    {
                        throw new Exception(Newtonsoft.Json.JsonConvert.DeserializeObject<string>(str));
                    }
                }
                else
                {
                    throw new Exception("Bad Request.");
                }
            }
            catch (Exception ex)
            {
                response.Exception = ex;
            }

            return response;
            
        }

    }
}
