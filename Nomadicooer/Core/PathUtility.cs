using System.IO;

namespace Nomadicooer.Core
{
    /// <summary>
    /// 路径工具类
    /// </summary>
    public static class PathUtility
    {
        /// <summary>
        /// 去掉尾部的目录文件分割符号
        /// </summary>
        /// <param name="path">要去掉分割符号的路径</param>
        /// <returns></returns>
        public static string TrimEndDirectorySeparator(string path)
        {
            int count = 0;
            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] != Path.DirectorySeparatorChar && path[i] != Path.AltDirectorySeparatorChar)
                {
                    break;
                }
                count++;

            }
            return path[..^count];
        }
        /// <summary>
        /// 判断路径是否存在
        /// </summary>
        /// <param name="path">需要判断的路径</param>
        /// <returns></returns>
        public static bool Exists(string path)
        {
            return Directory.Exists(path) || File.Exists(path);
        }
    }
}
