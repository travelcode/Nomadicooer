using Newtonsoft.Json;
using Nomaidcooer.Universal;
using System.Collections.Generic;

namespace Nomadicooer.Translator
{
    public class BaiduTranslateResponse : ITranslateResponse
    {
        private string from=string.Empty;
        private string to=string.Empty;
        private TranslateReson reson=TranslateReson.Succeed;
        private string message =TranslateReson.Succeed.ToString();
        private string erroCode=StringChars.Num0;
        private List<BaiduTransResult> result=new List<BaiduTransResult>();
        public BaiduTranslateResponse() {

        }
        [JsonProperty(propertyName: "from")]
        public string From { get => from; set => from = value; }
        [JsonProperty(propertyName: "to")]
        public string To { get => to; set => to = value; }
        public TranslateReson Reson { get => reson; set => reson = value; }
        [JsonProperty(propertyName: "error_msg")]
        public string Message { get => message; set => message = value; }
        [JsonProperty(propertyName: "trans_result")]
        public List<BaiduTransResult> Result { get => result; set => result = value; }
        [JsonProperty(propertyName: "error_code")]
        public string ErroCode { get => erroCode; set => erroCode = value; }

        public List<ITransResult> GetResult()
        {
          return new List<ITransResult>(result);
        }
    }        

}
