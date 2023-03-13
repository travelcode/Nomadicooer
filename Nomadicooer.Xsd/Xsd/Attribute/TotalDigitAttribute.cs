using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 定义阿拉伯数字精确位数,必须大于零
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class TotalDigitAttribute : Attribute
    {
        private readonly int totalDigits = -1;

        public TotalDigitAttribute(int totalDigits)
        {
            this.totalDigits = totalDigits;
        }
        /// <summary>
        /// 总位数
        /// </summary>
        public int TotalDigits => totalDigits;
    }
}

