namespace Nomadicooer.Translator
{
    public class BaiduTransResult : ITransResult
    {

        public BaiduTransResult(string src, string dst)
        {
            Src = src;
            Dst = dst;
        }

        public string Src { get; internal set; }
        public string Dst { get; internal set; }
    }
}
