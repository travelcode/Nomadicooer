using System.Collections.Generic;

namespace Nomadicooer.Translator
{
    public class BaiduTranslateResponse : ITranslateResponse
    {
        private string from = string.Empty;
        private string to = string.Empty;
        private TranslateReson reson = TranslateReson.Succeed;
        private string message = TranslateReson.Succeed.ToString();
        private int erroCode = 0;
        private List<BaiduTransResult> result = new List<BaiduTransResult>();
        public BaiduTranslateResponse()
        {

        }

        public string From { get => from; internal set => from = value; }

        public string To { get => to; internal set => to = value; }
        public TranslateReson Reson { get => reson; internal set => reson = value; }

        public string Message { get => message; internal set => message = value; }

        public List<BaiduTransResult> Result { get => result; internal set => result = value; }
        public int ErroCode { get => erroCode; internal set => erroCode = value; }

        public List<ITransResult> GetResult()
        {
            return new List<ITransResult>(result);
        }
    }

}
