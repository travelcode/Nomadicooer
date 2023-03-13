using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 设定长度范围
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class LengthRangeAttribute : Attribute
    {
        private readonly int minLength = -1;
        private readonly int maxLength = -1;
        /// <summary>
        /// 对值的最大长度进行限定
        /// </summary>
        /// <param name="maxLength">最大值</param>
        public LengthRangeAttribute(int maxLength)
        {
            this.maxLength = maxLength;
        }

        /// <summary>
        /// 设定长度范围
        /// </summary>
        /// <param name="minLength">最小长队</param>
        /// <param name="maxLength">最大长队</param>
        public LengthRangeAttribute(int minLength, int maxLength)
        {
            this.minLength = minLength;
            this.maxLength = maxLength;
        }
        /// <summary>
        /// 最大长度
        /// </summary>
        public int MaxLength => maxLength;
        /// <summary>
        /// 最小长度
        /// </summary>
        public int MinLength => minLength;
    }
}

