using System.Text.RegularExpressions;

namespace Nomadicooer.Core
{
    /// <summary>
    /// 对现有的已有类进行扩展
    /// </summary>
    public static class Extensions
    {
        #region 对字符串进行扩展
        /// <summary>
        /// 去掉字符串所有的空白字符
        /// </summary>
        /// <param name="str">要去掉空白字符的字符串</param>
        /// <returns></returns>
        public static string TrimAllWhiteSpace(this string str)
        {
            return Regex.Replace(str, @"\s", "");
        }
        #endregion
        #region 对枚举类进行扩展
        /// <summary>
        /// 判断平台是否为当前平台
        /// </summary>
        /// <param name="platform">当前平台枚举实例</param>
        /// <returns></returns>
        public static bool IsCurrent(this Platform platform)
        {
            return RuntimeInfos.UniquePlatform==platform;
        }
        #endregion
    }
}
