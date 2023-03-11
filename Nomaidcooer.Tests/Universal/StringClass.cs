namespace Nomadicooer.Tests.Universal
{
    public class StringClass
    {
        public static readonly string fieldString = "\"this \" \"is a \"fildString";

        public  static string PropertyString => "this \\\\\\is a PropertyString";

        public static string PathString => @"FloderA\\FloderB/FloderC";
        //这是注释"中的注释"
        /// <summary>
        /// "文档注释"
        /// </summary>
        public static void StringTest() {
            const string varint = "this is a var string";
            Console.WriteLine(varint);
            Console.WriteLine("this is a writeLine string");

        }
    }
}
