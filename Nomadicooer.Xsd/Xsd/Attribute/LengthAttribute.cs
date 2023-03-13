using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 设定长度精确值
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class LengthAttribute : Attribute
    {
        private readonly int length = -1;
        /// <summary>
        /// 对长度进行精确限定
        /// </summary>
        /// <param name="length"></param>
        public LengthAttribute(int length)
        {
            this.length = length;
        }
        /// <summary>
        /// 字符串精确长度
        /// </summary>
        public int Length => length;
    }
}

