using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 指定xsd名称
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
    public class NameAttribute : Attribute
    {
        private readonly string name;
        private readonly string @default;
        /// <summary>
        /// xsd名称
        /// </summary>
        /// <param name="name">xsd的名称</param>
        public NameAttribute(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 设置xsd元素或则属性的默认值
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="default">默认值</param>
        public NameAttribute(string name, string @default)
        {
            this.name = name;
            this.@default = @default;
        }

        /// <summary>
        /// xsd名称
        /// </summary>
        public string Name => name;
        /// <summary>
        /// xsd默认值
        /// </summary>
        public string Default => @default;
    }
}
