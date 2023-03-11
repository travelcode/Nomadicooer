using System;
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
        /// 将字节数组转化为hash串在net5中的Convert.ToHexString(array);
        /// </summary>
        /// <param name="bytes">要转化的bytes</param>
        /// <returns></returns>
        public static string BytesToHash(byte[] bytes) {
            StringBuilder hash = new StringBuilder();
            foreach (var bt in bytes)
            {
                hash.Append(bt.ToString("x2"));
            }
            return hash.ToString();
        }
        /// <summary>
        /// 将字节转化为字符串
        /// </summary>
        /// <param name="bytes">要转化的字节</param>
        /// <returns></returns>
        public static string BytesTostring(byte[] bytes) { 
          return Encoding.Default.GetString(bytes);
        }
        /// <summary>
        /// 将字符串转化为byte
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] StringToBytes(string str) { 
          return Encoding.Default.GetBytes(str);
        }
        /// <summary>
        /// 将hash字符串转化为对应的整数
        /// </summary>
        /// <returns></returns>
        public static int HashToInt(string hash)
        {
            return Convert.ToInt32(hash);
        }
        /// <summary>
        /// 将hash转化为bytes,必须是由byte数组之前转化成的hash
        /// </summary>
        /// <param name="hash">要转化的hash</param>
        /// <returns></returns>
        public static byte[] HashToBytes(string hash) {
            hash=hash.ToUpper();
            byte[] bytes = new byte[hash.Length/2];
            for (int i = 0; i < bytes.Length; i++)
            {
               bytes[i]=Convert.ToByte(hash.Substring(2*i,2),16);
            }
            return bytes;
        }
    }
}
