using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Nomaidcooer.Universal
{
    /// <summary>
    /// http请求工具
    /// </summary>
    public static class HttpRequetUtility
    {
        public static string GetRequet(string url,(string key,string value)[] args) {
            StringBuilder argsStrBuilder= new StringBuilder();
            //多带个参数,以便不用判断是否是开始连接
            argsStrBuilder.Append(url).Append($"t={DateTime.Now.Ticks}");
            foreach (var (key, value) in args)
            {
                argsStrBuilder.Append(Chars.And).Append(key).Append(Chars.Equal).Append(HttpUtility.UrlEncode(value));
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(argsStrBuilder.ToString());
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 6000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream myResponseStream = response.GetResponseStream())
            {
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
        }
    }
}
