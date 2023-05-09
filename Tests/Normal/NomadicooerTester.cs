using Nomadicooer.Core;

namespace Tests.Normal
{
    public class NomadicooerTester
    {
        #region TestPathInfo
        [TestCase(@"C:\Users\machanglong\AppData\Roaming\KuGou8\Skin10\Locale\755db30bbd9af740cd58a4ec35a26e8b\skin.zip", Description = "压缩文件测试")]
        [TestCase(@"C:\Users\machanglong\AppData\Roaming\KuGou8\Skin10\Locale\755db30bbd9af740cd58a4ec35a26e8b", Description = "目录测试")]
        [TestCase(@"D:\Application\Baidu\BaiduNetdisk\api-ms-win-core-interlocked-l1-1-0.dll", Description = "文件测试")]
        [TestCase(@"^^DSFDS\4366/><445435\4534/)(**&^^%$#@!text.txt", Description = "特殊符号测试")]
        [TestCase(@"C:\dsfsd\GFDGF\DSFDS/", Description = "带驱动器文件测试")]
        [TestCase(@"\dsfsd\GFDGF\DSFDS/", Description = "不带驱动器文件测试")]
        [TestCase(@"dafda\adfasd\dfdasf00", Description = "相对路径测试")]
        [TestCase(@"dafda\adfasd\dfdasf00\\//\\/\/\/\/\", Description = "测试结尾符号")]
        [TestCase(@"", Description = "空路径测试")]
        [TestCase(null, Description = "空路径测试")]
        public void TestPathInfo(string path)
        {
            PathInfo pathInfo = new(path);
            Console.WriteLine("OriginalPath=>" + pathInfo.OriginalPath);
            Console.WriteLine("FullPath=>" + pathInfo.FullPath);
            Console.WriteLine("FileName=>" + pathInfo.FileName);
            Console.WriteLine("Exists=>" + pathInfo.Exists);
            Console.WriteLine("IsValid=>" + pathInfo.IsValid);
            Console.WriteLine("IsReadOnly=>" + pathInfo.IsReadOnly);
            Console.WriteLine("IsHidden=>" + pathInfo.IsHidden);
            Console.WriteLine("IsDirectory=>" + pathInfo.IsDirectory);
            Console.WriteLine("IsFile=>" + pathInfo.IsFile);
            Console.WriteLine("Attributes=>" + pathInfo.Attributes);
            Console.WriteLine("FirstParent=>" + pathInfo.FirstParent);
            PathInfo[] parents = pathInfo.Parents;
            foreach (var parent in parents)
            {
                Console.WriteLine(parent.OriginalPath);
            }
        }
        #endregion
        #region TestContainDir
        [TestCase("", Description = "空路径测试", ExpectedResult = "")]
        [TestCase("commons", Description = "部分路径测试", ExpectedResult = "")]
        [TestCase("commons-configuration", ExpectedResult = @"D:\Repository\JavaRepository\commons-configuration\commons-configuration")]
        [TestCase("commons-configuration-1.10.pom", ExpectedResult = @"D:\Repository\JavaRepository\commons-configuration\commons-configuration\1.10\commons-configuration-1.10.pom")]
        [TestCase("commons-configuration-1.10.po", ExpectedResult = "")]
        [TestCase(@"D:\", ExpectedResult = @"D:\")]
        [TestCase(@"JavaRepository\commons-configuration", ExpectedResult = @"D:\Repository\JavaRepository\commons-configuration")]
        public string TestContainDir(string path)
        {
            string testPaht = @"D:\Repository\JavaRepository\commons-configuration\commons-configuration\1.10\commons-configuration-1.10.pom";
            PathInfo pathInfo = new(testPaht);
            PathInfo[] pathinfos = pathInfo.GetContainPathInfo(path);
            foreach (var pathinfo in pathinfos)
            {
                Console.WriteLine(pathinfo);
            }
            return pathinfos.Length > 0 ? pathinfos[0].FullPath : string.Empty;
        }
        #endregion
        #region TestPathManager
        [Test]
        public void TestPathManager()
        {
            string[] paths = PathManager.Instance.LanguagesPaths;
            foreach (var pathinfo in paths)
            {
                Console.WriteLine(pathinfo);
            }
        }
        #endregion
        [Test]
        public void TestRuntimeInformation() {
            RuntimeInfos.IsWindows();
        }
    }
}
