using Nomaidcooer.Universal;

namespace Nomadicooer.Tests.Universal
{
    [TestFixture]
    public class MainTest
    {
        [Test]
        public void TestType() {
          Console.WriteLine(typeof(IEnumerable<object>));
        }
    }
}
