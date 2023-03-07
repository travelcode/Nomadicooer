using Microsoft.VisualBasic;
using Nomaidcooer.Universal;

namespace Nomadicooer.Tests.Universal
{
    class NormalClass
    {
        private readonly int a;
        public NormalClass(int a)
        {
            this.a = a;
            Console.WriteLine($"实例被创建{a}");
        }
        ~NormalClass()
        {
            Console.WriteLine($"实例被销毁{a}");
        }
    }
    static class StaticClass
    {
        public  static NormalClass NormalClass1=> new(1);
        public readonly static NormalClass NormalClass2= new(2);
        public readonly static NormalClass NormalClass3= new(3);
    }
    /// <summary>
    /// C#语言特性测试
    /// </summary>
    enum EnumTest { 
      AA=11,
      CC=AA,
      BB=AA,
      DD=AA
    }
    public class CsharpTest
    {
        [Test]
        public void TestStaticClass() {
            Console.WriteLine(CountyCode.ABW);
            Console.WriteLine(CountyCode.AW);
            Console.WriteLine(CountyCode.AUS);
            Console.WriteLine(CountyCode.AU);
            Console.WriteLine(CountyCode.CHN);
            Console.WriteLine(CountyCode.CN);
        }
    }
}
