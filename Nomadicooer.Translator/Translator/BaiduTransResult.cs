using Newtonsoft.Json;

namespace Nomadicooer.Translator
{
    public class BaiduTransResult : ITransResult
    {
        [JsonProperty(propertyName: "src")]
        public string Src{ get; set; }
        [JsonProperty(propertyName: "dst")]
        public string Dst { get; set; }
    }
}
