namespace Nomadicooer.Translator
{
    /// <summary>
    /// 翻译配置
    /// </summary>
    public  class TranslateConfiguration
    {
        private string appid;
        private string secretKey;

        /// <summary>
        /// Appid
        /// </summary>
        public string Appid { get => appid; set => appid = value; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string SecretKey { get => secretKey; set => secretKey = value; }
    }
}
