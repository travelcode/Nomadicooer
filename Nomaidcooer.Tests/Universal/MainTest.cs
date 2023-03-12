using Nomadicooer.Xsd;
using Nomaidcooer.Universal;
using NUnit.Framework;
using System.Security.Cryptography;
using System.Text;

namespace Nomadicooer.Tests.Universal
{
    [TestFixture]
    public class MainTest
    {
        [Test]
        public void TestGetCodeStringInfos()
        {
            string path = @"C:\Users\50284\Documents\workspace\vs\Nomadicooer\Nomaidcooer.Tests\Universal\StringClass.cs";
            string codeText = File.ReadAllText(path);
            CodeStringSearcher search = new(codeText);
            search.RecordEvent += (sender, e) =>
            {
                CodeStringInfo info = e.Info;
                info.Text = info.Text.Trim().Replace("\"", "").Replace("\\", "");
                Console.WriteLine(info.Text);
            };
            List<CodeStringInfo> infos = search.Search();

            foreach (var info in infos)
            {
                Console.WriteLine("--------------------------start------------------");
                Console.WriteLine($"Text=>{info.Text}");
                Console.WriteLine($"StartSpan=>{info.StartSpan}");
                Console.WriteLine($"StartLine=>{info.StartLine}");
                Console.WriteLine($"StartLineSpan=>{info.StartLineSpan}");
                Console.WriteLine($"EndSpan=>{info.EndSpan}");
                Console.WriteLine($"EndLine=>{info.EndLine}");
                Console.WriteLine($"EndLineSpan=>{info.EndLineSpan}");
            }
        }
        [Test]
        public void TestHashCovert()
        {

            string testStr = "小时候在农村的春天里,踏晨露,听鸟鸣,看树绿,闻花香.我一直想不通，这些近在咫尺的情景为何被书本描绘得遥不可及.";
            byte[] bytes1 = Encoding.Default.GetBytes(testStr);
            string hash = StringUtility.BytesToHash(bytes1);
            Console.WriteLine(hash);
            byte[] bytes2 = StringUtility.HashToBytes(hash);
            string testStr1 = Encoding.Default.GetString(bytes2);
            Assert.That(testStr1, Is.EqualTo(testStr));
            Console.WriteLine(testStr1);

        }
        [Test]
        public void TestAes()
        {
            Aes aes = Aes.Create();
            Console.WriteLine($"key=>{StringUtility.BytesToHash(aes.Key)}");
            Console.WriteLine($"Iv=>{StringUtility.BytesToHash(aes.IV)}");
            aes = Aes.Create();
            Console.WriteLine($"key=>{StringUtility.BytesToHash(aes.Key)}");
            Console.WriteLine($"Iv=>{StringUtility.BytesToHash(aes.IV)}");

        }
        [Test]
        public void TestCrptoUtilityAes()
        {
            string testStr = "When I was a child in the rural spring, step on the morning dew, listen to the birds, see the trees green, smell the flowers.  I have always wondered why these scenes, so close to me, can be portrayed as unreachable in books.";
            string result = CryptoUtility.EncryptToHashWithAes(testStr, out string key, out string iv);
            Console.WriteLine($"encrypt=>{result}");
            result = CryptoUtility.DecryptFromHashWithAes(result, key, iv);
            Console.WriteLine($"decrypt=>{result}");
            Assert.That(result, Is.EqualTo(testStr));
        }
        [Test]
        public void TestNaming()
        {
            PrintNewNaming("_Aaa_bbb____ccc____Dddd_eEee");
        }


        private static void PrintNewNaming(string name)
        {
            Console.WriteLine($"------------{name}----------------");
            Console.WriteLine("ToPascal=>" + NamingUtility.ToPascal(name));
            Console.WriteLine("ToCamelcase=>" + NamingUtility.ToCamelcase(name));
            Console.WriteLine("ToUnderLine=>" + NamingUtility.ToUnderLine(name));
        }
        [Test]
        public void TestNamingStrategy()
        {
            string name = "_Aaa_bbb__ccc____Dddd_eEee";
            string newName = NamingStrategy.Pascal.Translate(name);
            Console.WriteLine(newName);
            newName = NamingStrategy.Camelcase.Translate(name);
            Console.WriteLine(newName);
            newName = NamingStrategy.Snake.Translate(name);
            Console.WriteLine(newName);
        }
    }
}
