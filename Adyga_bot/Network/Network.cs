using System;
using System.IO;
using System.Net;
using System.Text;

namespace Adyga_bot
{
    internal static class Network
    {
        public static string GET(string link)
        {
            return new StreamReader(((HttpWebRequest)WebRequest.Create(link)).GetResponse().GetResponseStream()).ReadToEnd();
        }
        public static string GET(string link, CookieContainer cc = null)
        {
            var http = (HttpWebRequest)WebRequest.Create(link);
            if (cc != null)
                http.CookieContainer = cc;
            return new StreamReader(http.GetResponse().GetResponseStream()).ReadToEnd();
        }
        public static string GET(string link, out string Location, CookieContainer cc = null)
        {
            var http = (HttpWebRequest)WebRequest.Create(link);
            if (cc != null)
                http.CookieContainer = cc;
            http.AllowAutoRedirect = false;
            var httpResponse = (HttpWebResponse)http.GetResponse();
            Location = httpResponse.Headers.Get("location");
            return new StreamReader(httpResponse.GetResponseStream()).ReadToEnd();
        }

        public static string POST(string url, string Data, CookieContainer cc = null)
        {
            var http = (HttpWebRequest)WebRequest.Create(url);
            http.Method = "POST";
            if (cc != null)
                http.CookieContainer = cc;
            http.Timeout = 100000;
            http.AllowAutoRedirect = true;
            http.ContentType = "application/x-www-form-urlencoded";
            http.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.61 Safari/537.36";
            byte[] bytes = Encoding.UTF8.GetBytes(Data);

            http.ContentLength = (long)bytes.Length;
            Stream requestStream = http.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            TextReader textReader = new StreamReader(http.GetResponse().GetResponseStream(), Encoding.UTF8);
            if (cc != null)
                cc = http.CookieContainer;
            return textReader.ReadToEnd();
        }
    }
}
