using System.Text.Json.Serialization;

namespace Nomadicooer.Translator
{
    public class BaiduTransResult : ITransResult
    {
        [JsonPropertyName("src")]
        public string Src{ get; set; }

        [JsonPropertyName("dst")]
        public string Dst { get; set; }
    }
}
