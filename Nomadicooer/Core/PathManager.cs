using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nomadicooer.Core
{
    /// <summary>
    /// 路径管理器
    /// </summary>
    public class PathManager
    {
        private readonly string appPath;
        private readonly string appDataPath;
        private readonly string dataPath;
        private readonly string[] languagesPaths;
        private readonly string appDataLanguagesPath;
        private readonly string dataLanguagesPath;
        /// <summary>
        /// 应用程序安装路径,该路径不一定可读可写
        /// </summary>
        public virtual string AppPath => this.appPath;
        /// <summary>
        /// 应用程序随附数据保存路径,用户不一定可读可写,但是应用程序一定可读
        /// </summary>
        public virtual string AppDataPath => this.appDataPath;
        /// <summary>
        /// 综合性数据保存路径,一个用户程序可读可写的路径
        /// </summary>
        public virtual string DataPath => this.dataPath;
        /// <summary>
        /// 本地化语言路径
        /// </summary>
        public virtual string[] LanguagesPaths => this.languagesPaths;
        /// <summary>
        /// PathManager实例
        /// </summary>
        public readonly static PathManager Instance = Nested.instance;
        private static class Nested
        {
            internal static readonly PathManager instance = new PathManager();
        }
        /// <summary>
        /// 用于内部初始化PathManager新实例和公开子类继承权限
        /// </summary>
        protected PathManager()
        {
            this.appPath = GetAppPath();
            this.appDataPath = GetAppDataPath(this.appPath);
            this.dataPath = GetDataPath();
            this.appDataLanguagesPath = GetAppDataLanguagesPath(this.appDataPath);
            this.dataLanguagesPath = GetDataLanguagesPath(this.dataPath);
            this.languagesPaths = GetLanguesPaths();
        }
        private string GetAppPath()
        {
            return Environment.CurrentDirectory;
        }
        private string GetAppDataPath(string appPath)
        {
            return Path.Combine(appPath, StringsHelper.AppData);
        }
        private string GetAppDataLanguagesPath(string appPath)
        {
            return Path.Combine(appPath, StringsHelper.Languages);
        }
        private string GetDataPath()
        {
            string path = Environment.CurrentDirectory;
            path = Path.Combine(path, StringsHelper.Data);
            return path;
        }
        private string GetDataLanguagesPath(string dataPath)
        {
            return Path.Combine(dataPath, StringsHelper.Languages);
        }
        private string[] GetLanguesPaths()
        {
            HashSet<string> paths = new HashSet<string>();
            if (PathUtility.Exists(this.appDataLanguagesPath))
            {
                paths.Add(this.appDataLanguagesPath);
            };
            if (PathUtility.Exists(this.dataLanguagesPath))
            {
                paths.Add(this.dataLanguagesPath);
            }
            return paths.ToArray();
        }
        /// <summary>
        /// 创建基本路径,该方法应该在开发阶段使用,用于创建基本的目录结构
        /// <list type="number">
        ///     <item>
        ///         <term>[AppDataPath]</term>
        ///         <description>应用程序数据保存路径</description>
        ///     </item>
        ///     <item>
        ///         <term>[DataPath]</term>
        ///         <description>综合数据保存路径</description>
        ///     </item>
        ///     <item>
        ///         <term>[AppDataPath]\languages</term>
        ///         <description>应用程序数据目录语言路径</description>
        ///     </item>
        ///     <item>
        ///         <term>[DataPath]\languages</term>
        ///         <description>数据目录语言路径</description>
        ///     </item>
        /// </list>
        /// </summary>
        public string[] CreateBasePath()
        {
            List<string> basePaths = new List<string>();
            string basePath = this.appDataPath;
            Directory.CreateDirectory(this.appDataPath);
            basePaths.Add(basePath);
            basePath = this.dataPath;
            Directory.CreateDirectory(basePath);
            basePaths.Add(basePath);
            basePath = this.appDataLanguagesPath;
            Directory.CreateDirectory(basePath);
            basePaths.Add(basePath);
            basePath = this.dataLanguagesPath;
            Directory.CreateDirectory(basePath);
            basePaths.Add(basePath);
            return basePaths.ToArray();
        }
    }
}
