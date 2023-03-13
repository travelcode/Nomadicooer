using System;

namespace Nomadicooer.Xsd
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class DefalutAttribute : Attribute
    {
        private readonly string @default;
        /// <summary>
        /// 设置默认值
        /// </summary>
        /// <param name="default">xsd默认值</param>
        public DefalutAttribute(string @default)
        {
            this.@default = @default;
        }
        /// <summary>
        /// 获取到默认值
        /// </summary>
        public string Default => @default;
    }
}
