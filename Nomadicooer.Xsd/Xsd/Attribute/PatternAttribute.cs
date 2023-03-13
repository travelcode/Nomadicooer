using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 正则匹配
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class PatternAttribute : Attribute
    {
        private readonly string pattern = string.Empty;
        /// <summary>
        /// 设置正则表达式
        /// </summary>
        /// <param name="pattern">正则表达式</param>
        public PatternAttribute(string pattern)
        {
            this.pattern = pattern;
        }
        /// <summary>
        /// 正则匹配
        /// </summary>
        public string Pattern => pattern;
    }
}

