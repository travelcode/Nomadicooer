using Nomaidcooer.Universal;

namespace Nomadicooer.Tests.Universal
{
    [TestFixture]
    public class MainTest
    {
        [Test]
        public void TestCountyCodeInfo()
        {
            CountryCode[] values = Enum.GetValues<CountryCode>();
            Console.WriteLine($"总枚举数:{values.Length}");
            Console.WriteLine($"总国家数:{values.Length/3}");
            foreach (var countryCode in values)
            {
                PrintCountInfo(new CountryCodeInfo(countryCode));
            }
        }

        private static void PrintCountInfo(CountryCodeInfo countyCodeInfo)
        {
            Console.WriteLine("-----------------Begin------------------");
            Console.WriteLine($"CountryCode:{countyCodeInfo.CountryCode}");
            Console.WriteLine($"PhoneAreaCode:{countyCodeInfo.PhoneAreaCode}");
            Console.WriteLine($"IsIndependent:{countyCodeInfo.IsIndependent}");
            Console.WriteLine($"CanAsDomain:{countyCodeInfo.CanAsDomain}");
            Console.WriteLine($"Alpha2:{countyCodeInfo.Alpha2}");
            Console.WriteLine($"Alpha3:{countyCodeInfo.Alpha3}");
            Console.WriteLine($"Alpha3:{countyCodeInfo.Domain}");
            Console.WriteLine($"Alpha3:{countyCodeInfo.DomainWithoutDot}");
            Console.WriteLine($"SystemCode:{countyCodeInfo.SystemCode}");
            Console.WriteLine($"SystemCodeHex:{countyCodeInfo.CountryName}");
            Console.WriteLine($"SystemCodeHex:{countyCodeInfo}");
        }
    }
}
