using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 如何处理空白符号
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class WhiteSpaceAttribute : Attribute
    {
        private readonly WhiteSpace whiteSpace;
        /// <summary>
        /// 设置空字符处理方式
        /// </summary>
        /// <param name="whiteSpace"></param>
        public WhiteSpaceAttribute(WhiteSpace whiteSpace)
        {
            this.whiteSpace = whiteSpace;
        }

        public WhiteSpace WhiteSpace => whiteSpace;
    }
}

