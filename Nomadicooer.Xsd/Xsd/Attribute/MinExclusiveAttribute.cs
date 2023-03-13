using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 设置最小值下限排除该选项
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinExclusiveAttribute : Attribute
    {
        private readonly int minExclusive;
        /// <summary>
        /// 设置最小值下限并排除该选项
        /// </summary>
        /// <param name="minExclusive">最小值并不包含该值</param>
        public MinExclusiveAttribute(int minExclusive)
        {
            this.minExclusive = minExclusive;
        }
        /// <summary>
        /// 获取到最小值下限(不包括该值)
        /// </summary>
        public int MinExclusive => minExclusive;
    }
}
