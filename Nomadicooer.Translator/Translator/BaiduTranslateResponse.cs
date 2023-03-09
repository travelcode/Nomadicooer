using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nomadicooer.Translator
{
    public class BaiduTranslateResponse : ITranslateResponse
    {
        private string from;
        private string to;
        private TranslateReson reson;
        private string message;
        private List<BaiduTransResult> result;
        public BaiduTranslateResponse() {

        }
     [JsonPropertyName("from")]
        public string From { get => from; set => from = value; }
        [JsonPropertyName("to")]
        public string To { get => to; set => to = value; }
        public TranslateReson Reson { get => reson; set => reson = value; }
        [JsonPropertyName("error_code")]
        public string Message { get => message; set => message = value; }

        [JsonPropertyName("trans_result")]
        public List<BaiduTransResult> Result { get => result; set => result = value; }
     
        public List<ITransResult> GetResult()
        {
          return new List<ITransResult>(result);
        }
    }        

}
