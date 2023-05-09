using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nomadicooer.Core
{
    /// <summary>
    /// 路径信息
    /// </summary>
    public class PathInfo
    {
        /// <summary>
        /// 一个空的路径信息
        /// </summary>
        public readonly static PathInfo Empty = new PathInfo();
        private bool? isValid = null;
        private bool? exists;
        private bool? isDirectory;
        private bool? isFile;
        private bool? isHidden;
        private bool? isReadOnly;
        private bool? isRoot;
        private FileAttributes? attributes;
        private readonly string originalPath;
        private string fullPath = string.Empty;
        private PathInfo? firstParent;
        private PathInfo[]? parents;
        private string? fileName;
        private PathInfo()
        {
            this.originalPath = string.Empty;
        }
        /// <summary>
        /// 实例化一个PathInfo对象
        /// </summary>
        /// <param name="path">要获取关于路径信息的路径</param>
        public PathInfo(string path)
        {
            this.originalPath = path ?? string.Empty;
        }
        /// <summary>
        /// 是否为有效路径
        /// </summary>
        public bool IsValid
        {
            get
            {
                //已经初始化
                if (this.isValid != null)
                {
                    return (bool)this.isValid;
                }
                //空路径处理
                if (string.IsNullOrEmpty(this.originalPath))
                {
                    this.isValid = false;
                    return false;
                }
                //判断是否是有效的路径字符
                char[] chars = Path.GetInvalidPathChars();
                if (this.originalPath.Any(c => chars.Contains(c)))
                {
                    this.isValid = false;
                    return false;
                }
                try
                {
                    string path = PathUtility.TrimEndDirectorySeparator(this.originalPath);
                    string fileName = Path.GetFileName(path);
                    if (string.IsNullOrEmpty(fileName))
                    {
                        this.isValid = false;
                        return false;
                    }
                    chars = Path.GetInvalidFileNameChars();
                    if (fileName.Any(c => chars.Contains(c)))
                    {
                        this.isValid = false;
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    this.isValid = false;
                    return false;
                }
                this.isValid = true;
                return true;
            }
        }
        /// <summary>
        /// 最初由用户指定的路径
        /// </summary>
        public string OriginalPath => this.originalPath;
        /// <summary>
        /// 文件是否存在
        /// </summary>
        public bool Exists
        {
            get
            {

                if (this.exists != null) return (bool)this.exists;
                if (string.IsNullOrEmpty(this.originalPath))
                {
                    this.exists = false;
                    return false;
                }
                try
                {
                    FileAttributes attributes = File.GetAttributes(this.originalPath);
                    if ((int)attributes == -1)
                    {
                        this.exists = false;
                        return false;
                    }
                    this.exists = true;
                    return true;
                }
                catch (Exception e) when (e is FileNotFoundException | e is DirectoryNotFoundException)
                {
                    this.exists = false;
                    return false;
                }
            }
        }
        /// <summary>
        /// 判断是否为目录,如果文件不存在同样返回false
        /// </summary>
        public bool IsDirectory
        {
            get
            {
                if (this.isDirectory != null)
                {
                    return (bool)this.isDirectory;
                }
                if (this.Attributes == null)
                {
                    this.isDirectory = false;
                    return false;
                }
                if ((this.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    this.isDirectory = true;
                    return true;
                }
                this.isDirectory = false;
                return false;
            }
        }
        /// <summary>
        /// 判断是否为文件,不为目录即为文件,如果文件不存在同样返回false
        /// </summary>
        public bool IsFile
        {
            get
            {
                if (this.isFile != null)
                {
                    return (bool)this.isFile;
                }
                if (this.Attributes == null)
                {
                    this.isFile = false;
                    return false;
                }
                if ((this.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    this.isFile = true;
                    return true;
                }
                this.isFile = false;
                return false;
            }
        }
        /// <summary>
        /// 是否为隐藏文件,如果文件不存在同样返回false
        /// </summary>
        public bool IsHidden
        {
            get
            {
                if (this.isHidden != null)
                {
                    return (bool)this.isHidden;
                }
                if (this.Attributes == null)
                {
                    this.isHidden = false;
                    return false;
                }
                if ((this.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    this.isHidden = true;
                    return true;
                }
                this.isHidden = false;
                return false;
            }
        }
        /// <summary>
        /// 获取文件属性,文件不存在返回空
        /// </summary>
        public FileAttributes? Attributes
        {
            get
            {
                if (!this.Exists)
                {
                    return null;
                }
                if (this.attributes != null)
                {
                    return this.attributes;
                }
                try
                {
                    this.attributes = File.GetAttributes(this.originalPath);
                    return this.attributes;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 是否为只读,如果文件不存在,同样返回false
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                if (this.isReadOnly != null)
                {
                    return (bool)this.isReadOnly;
                }
                if (this.Attributes == null)
                {
                    this.isReadOnly = false;
                    return false;
                }
                if ((this.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    this.isReadOnly = true;
                    return true;
                }
                this.isReadOnly = false;
                return false;
            }
        }
        /// <summary>
        /// 获取到的路径的全路径,不会对路径存在与否进行判断,
        /// 通常情况下路径径都去掉了尾斜杠,唯独路径是根路径的时候保留了尾斜杠
        /// </summary>
        public string FullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.originalPath))
                {
                    return string.Empty;
                }
                if (this.fullPath != string.Empty)
                {
                    return this.fullPath;
                }
                this.fullPath = Path.GetFullPath(this.originalPath);
                if (!this.IsRoot)
                {
                    this.fullPath = this.fullPath.TrimEnd(Path.DirectorySeparatorChar);
                }
                return this.fullPath;
            }
        }
        /// <summary>
        /// 第一个父目录
        /// </summary>
        public PathInfo FirstParent
        {
            get
            {
                if (firstParent != null)
                {
                    return firstParent;
                }
                if (string.IsNullOrEmpty(this.originalPath))
                {
                    return Empty;
                }
                DirectoryInfo dir = Directory.GetParent(this.originalPath);
                if (string.IsNullOrEmpty(dir?.FullName))
                {
                    this.firstParent = Empty;
                    return Empty;
                }
                this.firstParent = new PathInfo(dir?.FullName ?? string.Empty);
                return this.firstParent;
            }
        }
        /// <summary>
        /// 获取到所有的父级目录
        /// </summary>
        public PathInfo[] Parents
        {
            get
            {
                if (this.parents != null)
                {
                    return this.parents;
                }
                HashSet<PathInfo> parents = new HashSet<PathInfo>();
                PathInfo parent = this.FirstParent;
                for (int i = 0; i < 100; i++)
                {
                    if (parent == Empty)
                    {
                        break;
                    }
                    parents.Add(parent);
                    parent = parent.FirstParent;
                }
                this.parents = parents.ToArray();
                return this.parents;
            }
        }
        /// <summary>
        /// 文件的名称,如果传入的最后一级包括目录分割符号,不会返回空而是返回分割符号前一级目录名称
        /// </summary>
        public string FileName
        {
            get
            {
                if (this.fileName != null)
                {
                    return this.fileName;
                }
                this.fileName = Path.GetFileName(PathUtility.TrimEndDirectorySeparator(this.originalPath));
                return this.fileName;
            }
        }
        /// <summary>
        /// 判断是否为根路径
        /// </summary>
        public bool IsRoot
        {
            get
            {
                if (this.isRoot != null)
                {
                    return (bool)this.isRoot;
                }
                string root=Path.GetPathRoot(this.originalPath);
                this.isRoot = this.originalPath==root||this.originalPath+Path.DirectorySeparatorChar==root;
                return (bool)this.isRoot;
            }
        }

        /// <summary>
        /// 刷新pathInfo信息,使用其它方式对文件进行操作后,应该调用此方法
        /// </summary>
        public void Refresh()
        {
            this.isValid = null;
            this.exists = null;
            this.isDirectory = null;
            this.isFile = null;
            this.isHidden = null;
            this.isReadOnly = null;
            this.attributes = null;
            this.fullPath = string.Empty;
            this.firstParent = null;
            this.parents = null;
            this.fileName = null;
        }
        /// <summary>
        /// 获取到包含的路径信息
        /// </summary>
        /// <param name="directory">要获取路径信息的一级或者多级目录</param>
        /// <returns>返回该级目录名称</returns>
        public PathInfo[] GetContainPathInfo(string directory)
        {
            if (string.IsNullOrEmpty(directory))
            {
                return new PathInfo[] { Empty };
            }
            string[] directorys = directory.Split(Path.DirectorySeparatorChar, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (var dir in directorys)
            {
                sb.Append(dir).Append(Path.DirectorySeparatorChar);
            }
            directory = sb.ToString().TrimEnd(Path.DirectorySeparatorChar);
            string fullPath = this.fullPath == string.Empty ? Path.GetFullPath(this.originalPath) : this.fullPath;
            HashSet<PathInfo> pathInfos = new HashSet<PathInfo>();
            //判断师傅是结束位置
            string tempFullPath = fullPath;
            string tempDir = Path.DirectorySeparatorChar + directory;
            if (tempFullPath.EndsWith(tempDir))
            {
                pathInfos.Add(new PathInfo(tempFullPath));
                tempFullPath = tempFullPath[..tempFullPath.LastIndexOf(tempDir)] + Path.DirectorySeparatorChar;
            }
            tempDir = Path.DirectorySeparatorChar + directory + Path.DirectorySeparatorChar;
            for (int i = 0; i < 100; i++)
            {
                int lastIndex = tempFullPath.LastIndexOf(tempDir);
                if (lastIndex == -1)
                {
                    break;
                }
                string path = tempFullPath[..lastIndex] + tempDir.TrimEnd(Path.DirectorySeparatorChar);
                pathInfos.Add(new PathInfo(path));
                tempFullPath = tempFullPath[..(lastIndex + 1)];
            }
            //路径相同
            if (fullPath == directory)
            {
                pathInfos.Add(new PathInfo(Path.GetPathRoot(directory)));
            }

            tempDir = directory + Path.DirectorySeparatorChar;
            int index = fullPath.IndexOf(tempDir);
            if (index == 0)
            {
                pathInfos.Add(new PathInfo(Path.GetPathRoot(tempDir)));
            }
            return pathInfos.ToArray();
        }
        /// <summary>
        /// 返回原路径
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.FullPath;
        }

    }
}
