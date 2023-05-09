
using System.Security.AccessControl;

namespace Tests.Normal
{
    public class FeaturesTester
    {
        [Test]
        public void TestEnumerateDirectories() {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                List<string> dirs = new(Directory.EnumerateDirectories(docPath));

                foreach (var dir in dirs)
                {
                    Console.WriteLine($"{dir[(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)..]}");
                }
                Console.WriteLine($"{dirs.Count} directories found.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void TestInvalidFileNameChars()
        {
            char[] chars=Path.GetInvalidFileNameChars();
            foreach (var ch in chars)
            {
                Console.Write($"{ch},");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            chars = Path.GetInvalidPathChars();
            foreach (var ch in chars)
            {
                Console.Write($"{ch},");
            }
        }
        [Test]
        public void TestDirectoryInfo() {
        string path = @"C:\Recovery";
            FileAttributes attributes = File.GetAttributes(path);
            Console.WriteLine(attributes);
        }
        [Test]
        public void TestGetFullPath() {
            string path = @"C:\dfadsf/DSFDASF\DSFASF/SDFSDAF\DSFDAFS\SDFASFD/0//0///";
            Console.WriteLine(Path.GetFullPath(path));
        }
        [Test]
        public void TestGetFileParent() {
            string path = @"C:\Users\machanglong\.step";
           Console.WriteLine(Directory.GetParent(path)?.FullName);
           Console.WriteLine(Path.GetFileName(path));
        }
        [Test]
        public void TestDrives()
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (var dirve in drives)
            {
                Console.WriteLine(dirve);
            }
        }
    }
}
