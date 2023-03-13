using Nomadicooer.Tests.Xsd;
using Nomadicooer.Xsd;
using NUnit.Framework;

namespace Nomadicooer.Tests.Xs
{
    public class MainTest
    {
        [Test]
        public void TestXsdGenarator() {
            XsdGenerator xsdGenerator = new XsdGenerator(typeof(IConfigs));
            Console.WriteLine(xsdGenerator.Generate());
        }

    }
}
