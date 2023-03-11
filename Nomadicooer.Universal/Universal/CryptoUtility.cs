using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 加解密工具类
    /// </summary>
    public static class CryptoUtility
    {
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
            return ToMd5(text, Encoding.UTF8);
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
        /// <summary>
        /// 将字符串encryptStr加密成一串Hash字符串
        /// </summary>
        /// <param name="encryptStr">需要加密的字符串</param>
        /// <param name="key">加密的时候所用的自动生成密钥,需要妥善保管</param>
        /// <param name="iv">加密的时候所用的自动生成的IV向量,需要妥善保管</param>
        /// <returns></returns>
        public static string EncryptToHashWithAes(string encryptStr, out string key, out string iv)
        {
            using (Aes aes = Aes.Create())
            {
                key = StringUtility.BytesToHash(aes.Key);
                iv = StringUtility.BytesToHash(aes.IV);
                ICryptoTransform encryptor = aes.CreateEncryptor();
                string hash = null;
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(encryptStr);
                        }
                        //该条语句必须放在外面而不是里面
                          hash=  StringUtility.BytesToHash(msEncrypt.ToArray());
                    }
                }
                return hash;
               
            }

        }
        /// <summary>
        /// 将hash加密字符串,解密成原始字符串
        /// </summary>
        /// <param name="decryptStr">需要解密的字符串</param>
        /// <param name="key">加密密钥</param>
        /// <param name="iv">加密向量</param>
        /// <returns></returns>
        public static string DecryptFromHashWithAes(string decryptStr, string key, string iv) {
            byte[] decryptBytes = StringUtility.HashToBytes(decryptStr);
            byte[] keybytes = StringUtility.HashToBytes(key);
            byte[] bytes = StringUtility.HashToBytes(iv);
            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keybytes;
                aesAlg.IV = bytes;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor();
                using (MemoryStream msDecrypt = new MemoryStream(decryptBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
