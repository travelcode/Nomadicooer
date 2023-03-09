namespace Nomadicooer.Translator
{
    /// <summary>
    /// 翻译结果集映射
    /// </summary>
    public interface ITransResult
    {
        /// <summary>
        /// 源语言
        /// </summary>
        string Src { get; }
        /// <summary>
        /// 目标语言
        /// </summary>
        string Dst { get; }
    }
}
