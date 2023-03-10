using System.Collections.Generic;

namespace Nomadicooer.Translator
{
    /// <summary>
    /// 翻译结果
    /// </summary>
    public interface ITranslateResponse
    {
        /// <summary>
        /// 源语言代码
        /// </summary>
        string From { get; }
        /// <summary>
        /// 目标语言代码
        /// </summary>
        string To { get; }
        TranslateReson Reson { get; }
        /// <summary>
        /// 翻译结果消息
        /// </summary>
        string Message { get; }
        /// <summary>
        /// 翻译结果
        /// </summary>
        List<ITransResult> GetResult();
    }
}
