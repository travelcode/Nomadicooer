using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 对值或者字符串的枚举限定
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class EnumerationAttribute : Attribute
    {
        public readonly string[] enumerations;
        /// <summary>
        /// 对值或者字符串进行枚举限定
        /// </summary>
        /// <param name="enumerations">要进行限定的枚举值</param>
        public EnumerationAttribute(params string[] enumerations)
        {
            this.enumerations = enumerations;
        }
    }
}

