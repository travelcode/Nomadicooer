using System.Security.Cryptography;
using System.Text;

namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 字符串实用工具
    /// </summary>
    public class StringUtility
    {
        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="str">要首字母大写的字符串</param>
        /// <returns></returns>
        public static string ToUpperWithInitial(string str)
        {
            if (str == null || str.Length == 0) return str;
            char[] chars;
            if (str[0] >= Chars.LowerA && str[0] <= Chars.LowerZ)
            {
                chars = str.ToCharArray();
                chars[0] = (char)(str[0] - 32);
                return new string(chars);
            }
            return str;
        }

        /// <summary>
        /// 添加双引号
        /// </summary>
        /// <param name="str">要添加双引号的字符串</param>
        /// <returns></returns>
        public static string AddDoubleQuotation(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Chars.Quote).Append(str).Append(Chars.Quote);
            return stringBuilder.ToString();
        }
        /// <summary>
        /// 将字符串转换为Md5签名,默认字符串编码为UTF8
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// 转换为MD5
        /// </summary>
        /// <param name="text">要转换的文本</param>
        /// <returns></returns>
        public static string ToMd5(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] testBytes = Encoding.UTF8.GetBytes(text);
            byte[] result = md5.ComputeHash(testBytes);
            StringBuilder hash =new StringBuilder();
            foreach (var item in result)
            {
                hash.Append(item.ToString("x2"));
            }
            return hash.ToString();
        }
        /// <summary>
        /// 将字符串转化为Md5字符串
        /// </summary>
        /// <param name="text">要转化的文本</param>
        /// <param name="encoding">字符串文本编码</param>
        /// <returns></returns>
        public static string ToMd5(string text, Encoding encoding)
        {
            MD5 md5 = MD5.Create();
            byte[] testBytes = encoding.GetBytes(text);
            byte[] result = md5.ComputeHash(testBytes);
            StringBuilder hash = new StringBuilder();
            foreach (var item in result)
            {
                hash.Append(item.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
