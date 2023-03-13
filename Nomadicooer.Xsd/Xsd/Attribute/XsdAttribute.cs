using System;

namespace Nomadicooer.Xsd
{
    [AttributeUsage(AttributeTargets.Interface
     | AttributeTargets.Class
     | AttributeTargets.Field
     | AttributeTargets.Property
     )]
    public class XsdAttribute : Attribute
    {
        private readonly string name;
        private readonly string @default;
        private readonly string type;
        /// <summary>
        /// 元素或者属性名称
        /// </summary>
        public string Name => name;
        /// <summary>
        /// 默认值
        /// </summary>
        public string Default => @default;
        /// <summary>
        /// 数据类型,从XmlSchemaSimpleType获取,或者直接填写
        /// </summary>
        public string Type => type;
        /// <summary>
        /// 重命名字段或者元素名称
        /// </summary>
        /// <param name="name">元素名称</param>
        public XsdAttribute(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 指定字段或者元素名称并设置默认值
        /// </summary>
        /// <param name="name">元素名称</param>
        /// <param name="default">默认值</param>
        public XsdAttribute(string name, string @default)
        {
            this.name = name;
            this.@default = @default;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="default"></param>
        /// <param name="type"></param>
        public XsdAttribute(string name, string @default, string type)
        {
            this.name = name;
            this.@default = @default;
            this.type = type;
        }
    }
}

