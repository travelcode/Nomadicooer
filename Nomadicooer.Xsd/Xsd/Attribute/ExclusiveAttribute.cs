using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// Xsd  Exclusive 限定,定义值的上下限,不包含此值
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ExclusiveAttribute : Attribute
    {
        private readonly int? minExclusive = null;
        private readonly int? maxExclusive = null;
        /// <summary>
        /// 下限值但是不好含定义值
        /// </summary>
        public int? MinExclusive => minExclusive;
        /// <summary>
        /// 上限值包含定义值
        /// </summary>
        public int? MaxExclusive => maxExclusive;

        /// <summary>
        /// 设定上线
        /// </summary>
        /// <param name="maxExclusive">上限</param>
        public ExclusiveAttribute(int maxExclusive)
        {
            this.maxExclusive = maxExclusive;
        }
        /// <summary>
        /// 设定下限
        /// </summary>
        /// <param name="minExclusive">下限</param>
        /// <param name="maxExclusive">上限</param>
        public ExclusiveAttribute(int minExclusive, int maxExclusive)
        {
            this.minExclusive = minExclusive;
            this.maxExclusive = maxExclusive;
        }
    }
}

