using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 	定义所允许的最大的小数位数。必须大于等于0。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class FractionDigitsAttribute : Attribute
    {
        private readonly int fractionDigits = -1;
        /// <summary>
        /// 设置数字小数位数
        /// </summary>
        /// <param name="fractionDigits">小数位数</param>
        public FractionDigitsAttribute(int fractionDigits)
        {
            this.fractionDigits = fractionDigits;
        }
        /// <summary>
        /// 小数点位数
        /// </summary>
        public int FractionDigits => fractionDigits;
    }
}

