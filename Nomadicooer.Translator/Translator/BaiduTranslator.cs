using Newtonsoft.Json;
using Nomaidcooer.Universal;
using System;
using System.Text;

namespace Nomadicooer.Translator
{
    public class BaiduTranslator : ITranslator
    {
        private const string apiAdress = "https://fanyi-api.baidu.com/api/trans/vip/translate?";
        private const int slotMaxvalue = 10000;
        private readonly string appid;
        private readonly string secretKey;
        /// <summary>
        /// 实例化百度翻译接口
        /// </summary>
        /// <param name="appid">百度API的APPID</param>
        /// <param name="sceret">API的密钥</param>
        public BaiduTranslator(string appid, string secretKey)
        {
            this.appid = appid;
            this.secretKey = secretKey;
        }
        
        /// <summary>
        /// 翻译文本
        /// </summary>
        /// <param name="from">源语言类型</param>
        /// <param name="to">目标语言类型</param>
        /// <param name="q">需要翻译的文本</param>
        /// <returns></returns>
        public ITranslateResponse Translate(string from, string to, params string[] querys)
        {
            Random r = new Random();
            string salt = r.Next(slotMaxvalue).ToString();
            StringBuilder builder = new StringBuilder();
            foreach (var query in querys)
            {
                builder.AppendLine(query);
            }
            string queryString = builder.ToString();
            string sign = StringUtility.ToMd5(appid + queryString + salt + secretKey);
            (string key, string value)[] args = {("q",queryString),("from",from),("to",to),("appid",appid),("salt",salt),("sign",sign) };
            string jsonString= HttpRequetUtility.GetRequet(apiAdress,args);
            BaiduTranslateResponse response = JsonConvert.DeserializeObject<BaiduTranslateResponse>(jsonString);
            int erroCode= int.Parse(response.ErroCode);
            if (erroCode>0) {
                response.From = from;
                response.To = to;
                response.Reson = TranslateReson.Failed;
            }
            return response;
        }
    }
}
