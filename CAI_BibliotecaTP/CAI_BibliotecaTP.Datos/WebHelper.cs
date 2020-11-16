using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;

namespace CAI_BibliotecaTP.Datos
{
    public static class WebHelper
    {
        private static WebClient _client;
        private static string _rutabase;

        static WebHelper()
        {
            _client = new WebClient();
            _client.Encoding = Encoding.UTF8;
            _rutabase = ConfigurationManager.AppSettings["URL_API"];

            _client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            var uri = _rutabase + url;

            var responseString = _client.DownloadString(uri);

            return responseString;
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = _rutabase + url;

            try
            {
                var response = _client.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":null}";
            }


        }
        public static string Put(string url, NameValueCollection parametros)
        {
            string uri = _rutabase + url;

            try
            {
                var response = _client.UploadValues(uri, "PUT", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":null}";
            }


        }
    }
}
