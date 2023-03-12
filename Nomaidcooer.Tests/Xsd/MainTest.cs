using Nomadicooer.Xsd;
using NUnit.Framework;

namespace Nomadicooer.Tests.Xs
{
    public class MainTest
    {
        [Test]
        public void TestXsdGenarator() {
            XsdGenerator xsdGenerator = new XsdGenerator(typeof(XsdAssistor));
            Console.WriteLine(xsdGenerator.generate());
        }
    }
}
