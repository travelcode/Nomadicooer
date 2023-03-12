using System;
using System.Xml;

namespace Nomadicooer.Xsd
{
    public class XsdGenerator
    {
        private readonly XmlDocument  document =new XmlDocument();
        
        private readonly Type rootType;
        /// <summary>
        /// 实例化一个XsdGenerator
        /// </summary>
        /// <param name="rootType">要被解析的根类型</param>
        
        public XsdGenerator(Type rootType) {
            this.rootType = rootType;   
        }

        public string generate() {
            return "";
        }
    }
}
