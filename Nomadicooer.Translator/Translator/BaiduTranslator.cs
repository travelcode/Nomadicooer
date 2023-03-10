using Newtonsoft.Json;
using Nomaidcooer.Universal;
using System;
using System.Collections.Generic;
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
            (string key, string value)[] args = { ("q", queryString), ("from", from), ("to", to), ("appid", appid), ("salt", salt), ("sign", sign) };
            string jsonString = HttpRequetUtility.GetRequet(apiAdress, args);
            return GetTranslateResponse(from, to, jsonString);
        }
        /// <summary>
        /// 获取到百度翻译响应数据
        /// </summary>
        /// <param name="from">需要翻译的文字语言</param>
        /// <param name="to">翻译为的文字</param>
        /// <param name="jsonString">返回的结果集</param>
        /// <returns></returns>
        private BaiduTranslateResponse GetTranslateResponse(string from, string to, string jsonString)
        {
            BaiduTranslateResponse response = new BaiduTranslateResponse();
            BaiduTransJsonStruct json = JsonToDefaultStruct(jsonString);
            int errCode = 0;
            if (!string.IsNullOrEmpty(json.error_code))
            {
                int.TryParse(json.error_code, out errCode);
            }
            if (errCode > 0)
            {
                //失败设置
                response.From = from;
                response.To = to;
                response.Message = json.error_msg;
                response.ErroCode = errCode;
                response.Reson = TranslateReson.Failed;
                response.Result = new List<BaiduTransResult>();
                return response;
            }
            //成功设置
            response.From = json.from;
            response.To = json.to;
            response.Message = TranslateReson.Succeed.ToString();
            response.ErroCode = (int)TranslateReson.Succeed;
            response.Reson = TranslateReson.Succeed;
            Trans_Result[] results = json.trans_result;
            response.Result = new List<BaiduTransResult>();
            BaiduTransResult baiduResult;
            foreach (var result in results)
            {
                baiduResult = new BaiduTransResult(result.src, result.dst);
                response.Result.Add(baiduResult);
            }

            return response;
        }
        /// <summary>
        /// 用于兼容不同JSON序列化工具
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        private BaiduTransJsonStruct JsonToDefaultStruct(string jsonString) { 
            return JsonConvert.DeserializeObject<BaiduTransJsonStruct>(jsonString);
        }
    }
}
