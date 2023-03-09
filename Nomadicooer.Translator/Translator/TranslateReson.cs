namespace Nomadicooer.Translator
{
    /// <summary>
    /// 请求结果成功或者失败原因枚举
    /// </summary>
    public enum TranslateReson
    {
        /// <summary>
        /// 成功
        /// </summary>
        Succeed,
        /// <summary>
        /// 失败,不想一个一个确认就用它
        /// </summary>
        Failed,
        /// <summary>
        /// 超时
        /// </summary>
        Timedout,
        /// <summary>
        /// 系统错误
        /// </summary>
        Systemerr,
        /// <summary>
        /// 未授权
        /// </summary>
        Unauthorized,
        /// <summary>
        /// 参数错误
        /// </summary>
        Argumenterr,
        /// <summary>
        /// 签名错误
        /// </summary>
        Signerr,
        /// <summary>
        /// 余额不足,充值再战
        /// </summary>
        InsufficientNalance,
        /// <summary>
        /// 调用频率过快
        /// </summary>
        Hyperfrequency,
        /// <summary>
        /// 不支持的语言
        /// </summary>
        UnsupportedLanguage,
        /// <summary>
        /// 翻译服务已经关闭
        /// </summary>
        ServiceShutDown,
        /// <summary>
        /// 未知
        /// </summary>
        Unknown,
    }
}
