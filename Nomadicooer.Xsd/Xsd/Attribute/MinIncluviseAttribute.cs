using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 设置最小值下限
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinIncluviseAttribute : Attribute
    {
        private readonly int minIncluvise;

        public MinIncluviseAttribute(int minIncluvise)
        {
            this.minIncluvise = minIncluvise;
        }

        /// <summary>
        /// 设置下限包括本值
        /// </summary>
        public int MinIncluvise => minIncluvise;
    }
}
