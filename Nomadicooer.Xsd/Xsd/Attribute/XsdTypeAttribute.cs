using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 对xsd类型进行单独定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class XsdTypeAttribute : Attribute
    {
        private readonly string type;
        private readonly string @default;
        /// <summary>
        /// xsd的类型限定
        /// </summary>
        /// <param name="type">xsd类型</param>
        /// <param name="default">默认值</param>
        public XsdTypeAttribute(string type, string @default)
        {
            this.type = type;
            this.@default = @default;
        }
        /// <summary>
        /// 对xsd属性或者元素的类型进行限定
        /// </summary>
        /// <param name="type"></param>
        public XsdTypeAttribute(string type)
        {
            this.type = type;
        }

        /// <summary>
        /// 获取到xsd类型
        /// </summary>
        public string Type => type;
        /// <summary>
        /// 获取到xsd的默认值
        /// </summary>
        public string Default => @default;
    }
}
