using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Class2
    {
        public static async Task<Stream> GetWebString(string url, string formData)
        {
            string requestUri = "";
            if (formData.Contains("="))
            {
                requestUri = string.Concat(new object[]
                {
                    url,
                    "?",
                    formData,
                    "r=",
                    DateTime.Now.Ticks
                });
            }
            else
            {
                if (string.IsNullOrEmpty(formData))
                {
                    requestUri = url + "?r=" + DateTime.Now.Ticks;
                }
                else
                {
                    requestUri = url + formData;
                }
            }
            Stream result;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(new Uri(requestUri)))
                    {
                        httpResponseMessage.EnsureSuccessStatusCode();
                        Stream text = await httpResponseMessage.Content.ReadAsStreamAsync();
                        result = text;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = null;
            }

            return result;
        }

    }
}
