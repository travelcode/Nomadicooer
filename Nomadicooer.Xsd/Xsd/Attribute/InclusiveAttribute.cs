using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// Xsd Inclusive 限定,定义值的上下限包含该值
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class InclusiveAttribute : Attribute
    {
        private readonly int? maxInclusive = null;
        private readonly int? minInclusive = null;
        /// <summary>
        /// 获取上限值
        /// </summary>
        public int? MaxInclusive => maxInclusive;
        /// <summary>
        /// 获取下限值
        /// </summary>
        public int? MinInclusive => minInclusive;

        /// <summary>
        /// 设置上下限
        /// </summary>
        /// <param name="minInclusive">下限并包含定义值</param>
        /// <param name="maxInclusive">上线不包含定义值</param>
        public InclusiveAttribute(int minInclusive, int maxInclusive)
        {
            this.maxInclusive = maxInclusive;
            this.minInclusive = minInclusive;
        }
        /// <summary>
        /// 设定值上下限制
        /// </summary>
        /// <param name="maxInclusive">最大值</param>
        public InclusiveAttribute(int maxInclusive)
        {
            this.maxInclusive = maxInclusive;
        }

    }
}

