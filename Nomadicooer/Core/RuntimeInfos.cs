using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace Nomadicooer.Core
{
    /// <summary>
    /// 用于提供运行时环境
    /// </summary>
    public static class RuntimeInfos
    {
        private readonly static Platform uniquePlatform=GetUniquePlatform();
        private readonly static Platform multiPlatform=GetMultiPlatform();
        private readonly static string appDataDir = GetAppDataDir();

        /// <summary>
        /// 判断是否为windows系统
        /// </summary>
        /// <returns></returns>
        public static bool IsWindows()
        {
            PlatformID platformID = Environment.OSVersion.Platform;
            if (platformID == PlatformID.Win32NT)
            {
                return true;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return true;
            }
            return false;

        }
        /// <summary>
        /// 判断是否为Unix操作系统
        /// </summary>
        /// <returns></returns>
        public static bool IsUnix()
        {
            PlatformID platformID = Environment.OSVersion.Platform;
            return platformID == PlatformID.Unix;
        }
        /// <summary>
        /// 判断是否为unity游戏引擎
        /// </summary>
        /// <returns></returns>
        public static bool IsUnity()
        {
#if UNITY
            return true;
#else
            return false;
#endif

        }
        /// <summary>
        /// 判断是否为linux操作系统
        /// </summary>
        /// <returns></returns>
        public static bool IsLinux()
        {
            bool r = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            if (r) return true;
#if LINUX
            return true;
#else
            return false;
#endif
        }
        /// <summary>
        /// 判断是否为安卓平台
        /// </summary>
        /// <returns></returns>
        public static bool IsAndroid()
        {
            var osNameAndVersion = RuntimeInformation.OSDescription;
            if (osNameAndVersion.Contains(StringsHelper.Android))
            {
                return true;
            }
            //过滤判断开始,假设是安卓系统
            if (!osNameAndVersion.StartsWith(StringsHelper.Linux)) {
                return false;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!(path.StartsWith(StringsHelper.DataData) &&path.EndsWith(StringsHelper.Files))) {
                return false;
            }
            path = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            if (!(path.StartsWith(StringsHelper.DataData) && path.EndsWith(StringsHelper.FilesFonts)))
            {
                return false;
            }
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!(path.StartsWith(StringsHelper.DataData) && path.EndsWith(StringsHelper.FilesFonts)))
            {
                return false;
            }
            path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            if (path!= StringsHelper.UsrShare)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取所有可能的平台
        /// </summary>
        public static Platform MultiPlatform => multiPlatform;
        private static Platform GetMultiPlatform()
        {
            Platform platform = Platform.None;
            if (IsWindows())
            {
                platform |= Platform.Windows;
            }
            if (IsUnix())
            {
                platform |= Platform.Unix;
            }
            if (IsLinux())
            {
                platform |= Platform.Linux;
            }
            if (!IsAndroid())
            {
                platform |= Platform.Android;
            }
            if (IsUnity())
            {
                platform |= Platform.Unity;
            }
            return platform;
        }
        /// <summary>
        /// 返回当前最有可能的,唯一的一个平台
        /// </summary>
        public static Platform UniquePlatform => uniquePlatform;
        private static Platform GetUniquePlatform()
        {
            if (IsUnity())
            {
                return Platform.Unity;
            }
            else if (IsWindows())
            {
                return Platform.Windows;
            }
            else if (IsAndroid())
            {
                return Platform.Android;
            }
            else if (IsLinux())
            {
                return Platform.Linux;
            }
            else if (IsUnix())
            {
                return Platform.Unix;
            }
            return Platform.None;
        }
        /// <summary>
        /// 获取应用程序数据存放目录,该目录必须保证应用程序本身可读可写
        /// <list type="number">
        ///  
        /// </list>
        /// </summary>
        public static string AppDataDir => appDataDir;
        private static string GetAppDataDir()
        {
            string path=string.Empty;
            
            if (Platform.Windows.IsCurrent()) {
                return Environment.CurrentDirectory;
            }
            return path;
        }
    }
}
