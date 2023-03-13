using System;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// xsd命令提示
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Property | AttributeTargets.Field)]
    public class AnnotationAttribute : Attribute
    {
        private readonly string appinfo;
        private readonly string documentation;
        /// <summary>
        /// 添加注解
        /// </summary>
        /// <param name="documentation">要添加的提示文档</param>
        public AnnotationAttribute(string documentation)
        {
            this.documentation = documentation;
        }
        /// <summary>
        /// 添加注解
        /// </summary>
        /// <param name="appinfo">由应用程序使用的信息</param>
        /// <param name="documentation">要添加的提示文档</param>
        public AnnotationAttribute(string appinfo, string documentation)
        {
            this.appinfo = appinfo;
            this.documentation = documentation;
        }

        /// <summary>
        /// 由应用程序使用的信息
        /// </summary>
        public string Appinfo => appinfo;
        /// <summary>
        /// 提示文档信息
        /// </summary>
        public string Documentation => documentation;
    }
}
