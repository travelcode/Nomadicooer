using System;
using System.IO;
using System.Xml.Schema;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// XmlShema生成
    /// </summary>
    public class XsdGenerator
    {
        private readonly XmlSchema schema = new XmlSchema();
        private NamingStrategy namingStrategy = NamingStrategy.Camelcase;
        private string targetNamespace = "http://www.nomadicooer.com";
        private string prefix = "nc";
        private XmlSchemaForm elementFormDefault = XmlSchemaForm.Qualified;
        private XmlSchemaForm attributeFormDefault = XmlSchemaForm.Qualified;
        public XsdGenerator(Type rootType)
        {
            this.rootType = rootType;
        }
        private readonly Type rootType;
        /// <summary>
        /// 名称策略
        /// </summary>
        public NamingStrategy NamingStrategy { get => namingStrategy; set => namingStrategy = value; }
        /// <summary>
        /// 指定xsd目标命名空间,用于标志该规则,相当于C#的namespace,JAVA的package
        /// </summary>
        public string TargetNamespace { get => targetNamespace; set => targetNamespace = value; }
        /// <summary>
        /// 给本规则集定义一个前缀,便于需要的时候引用,比如前缀为nc,则将在命名空间添加 xmlns:nc前缀并指向目标空间
        /// </summary>
        public string Prefix { get => prefix; set => prefix = value; }
        public XmlSchemaForm ElementFormDefault { get => elementFormDefault; set => elementFormDefault = value; }
        public XmlSchemaForm AttributeFormDefault { get => attributeFormDefault; set => attributeFormDefault = value; }
        /// <summary>
        /// 添加名称空间
        /// </summary>
        private void AddHeader()
        {
            //引入xsd规则集命名空间
            schema.Namespaces.Add("xs", "http://www.w3.org/2001/XMLSchema");
            //设置目标命名空间
            schema.TargetNamespace = targetNamespace;
            schema.Namespaces.Add(prefix, targetNamespace);
            //设置默认命名空间
            schema.Namespaces.Add("", targetNamespace);
            schema.ElementFormDefault = elementFormDefault;
            schema.AttributeFormDefault = attributeFormDefault;

        }
        /// <summary>
        /// 实例化一个XsdGenerator
        /// </summary>
        /// <param name="rootType">要被解析的根类型</param>
        public string Generate()
        {
            AddHeader();
            Parse();
            return Write();
        }

        private void Parse() {
            ParseType(rootType);
        }
        private void ParseType(Type t,string name="") {
            //将对象作为元素添加进Schema
            if (name.Length==0) {
               name= namingStrategy.Translate(t.Name);
            }
            XmlSchemaElement typeElement = new XmlSchemaElement();
            typeElement.Name = name;
            typeElement.Id = name;
            schema.Items.Add(typeElement);
            //解析字段,只对非私有字段进行解析
            
        }
        private string Write()
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.ValidationEventHandler += ValidationEventHandler;
            schemaSet.Add(schema);
            schemaSet.Compile();
            using (StringWriter sw = new StringWriter())
            {
                schema.Write(sw);
                return sw.ToString();
            }
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            Console.WriteLine("message");
            Console.WriteLine(e.Message);
        }
    }
}
