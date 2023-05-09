using Java.Util.Logging;
using System.Runtime.InteropServices;

namespace AndroidTest
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Logger logger = Logger.GetLogger(typeof(MainActivity).Name);
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Save1();
            //NetPaths();
        }

        private void Save1()
        {
            Java.IO.File? file = this.GetFileStreamPath("download");
            logger.Info(file?.AbsolutePath);
            string description = RuntimeInformation.OSDescription;
            logger.Info(description);
            OperatingSystem osversion = System.Environment.OSVersion;
            logger.Info($"Platform=>{osversion.Platform}");
            logger.Info($"osversion=>{osversion}");
            logger.Info($"Version=>{osversion.Version}");
            logger.Info($"VersionMajor=>{osversion.Version.Major}");
            logger.Info($"VersionMinor=>{osversion.Version.Minor}");
            logger.Info($"VersionBuild=>{osversion.Version.Build}");
            string[] drives = Environment.GetLogicalDrives();
            foreach (var drive in drives)
            {
                logger.Info(drive);
            }
        }

        private void NetPaths()
        {
            string path = System.Environment.CurrentDirectory;
            logger.Info($"CurrentDirectory=>{path}");
            path = System.Environment.ProcessPath ?? string.Empty;
            logger.Info($"ProcessPath=>{path}");
            path = System.Environment.SystemDirectory;
            logger.Info($"SystemDirectory=>{path}");
            string[] drivers = System.Environment.GetLogicalDrives();
            foreach (string driver in drivers)
            {
                logger.Info($"driver=>{driver}");
            }

            string machineName = System.Environment.MachineName;
            logger.Info($"machineName=>{machineName}");
            OperatingSystem osversion = System.Environment.OSVersion;
            logger.Info($"Platform=>{osversion.Platform}");
            logger.Info($"osversion=>{osversion}");
            logger.Info($"Version=>{osversion.Version}");
            logger.Info($"VersionMajor=>{osversion.Version.Major}");
            logger.Info($"VersionMinor=>{osversion.Version.Minor}");
            logger.Info($"VersionBuild=>{osversion.Version.Build}");
            System.Environment.SpecialFolder[] values = Enum.GetValues<System.Environment.SpecialFolder>();
            foreach (var value in values)
            {
                path = System.Environment.GetFolderPath(value);
                logger.Info($"{value}=>{path}");
            }
            bool r = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            logger.Info($"isLinux=>{r}");
            r = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            logger.Info($"isWindows=>{r}");
            r = RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD);
            logger.Info($"isFreeBSD=>{r}");
            r = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
            logger.Info($"isOSX=>{r}");
        }

        private void AndroidIntenalPaths()
        {
            logger.Info($"CacheDir=>{this.CacheDir?.AbsolutePath}");
            logger.Info($"CodeCacheDir=>{this.CodeCacheDir?.AbsolutePath}");
            logger.Info($"DataDir=>{this.DataDir?.AbsolutePath}");
            logger.Info($"ExternalCacheDir=>{this.ExternalCacheDir?.AbsolutePath}");
            logger.Info($"FilesDir=>{this.FilesDir?.AbsolutePath}");
            logger.Info($"ObbDir=>{this.ObbDir?.AbsolutePath}");
            logger.Info($"NoBackupFilesDir=>{this.NoBackupFilesDir?.AbsolutePath}");
            Java.IO.File[]? dirs = this.GetExternalCacheDirs();
            dirs ??= (Array.Empty<Java.IO.File>());
            foreach (var dir in dirs)
            {
                logger.Info($"ExternalCacheDir=>{dir}");
            }
            dirs = this.GetExternalMediaDirs();
            dirs ??= (Array.Empty<Java.IO.File>());
            foreach (var dir in dirs)
            {
                logger.Info($"ExternalMediaDir=>{dir}");
            }

            Java.IO.File? file = this.GetExternalFilesDir(Android.OS.Environment.MediaBadRemoval);
            logger.Info($"MediaBadRemoval=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaChecking);
            logger.Info($"MediaChecking=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaEjecting);
            logger.Info($"MediaEjecting=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaMounted);
            logger.Info($"MediaMounted=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaMountedReadOnly);
            logger.Info($"MediaMountedReadOnly=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaNofs);
            logger.Info($"MediaNofs=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaRemoved);
            logger.Info($"MediaRemoved=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaShared);
            logger.Info($"MediaShared=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaUnknown);
            logger.Info($"MediaUnknown=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaUnmountable);
            logger.Info($"MediaUnmountable=>{file?.AbsolutePath}");
            file = this.GetExternalFilesDir(Android.OS.Environment.MediaUnmounted);
            logger.Info($"MediaUnmounted=>{file?.AbsolutePath}");
            string? path = this.PackageCodePath;
            logger.Info($"PackageCodePath=>{path}");
            path = this.PackageResourcePath;
            logger.Info($"PackageResourcePath=>{path}");
            file = Android.OS.Environment.DataDirectory;
            logger.Info($"DataDirectory=>{file}");
            path = Android.OS.Environment.DirectoryAlarms;
            logger.Info($"DirectoryAlarms=>{path}");
            path = Android.OS.Environment.DirectoryAudiobooks;
            logger.Info($"DirectoryAudiobooks=>{path}");
            path = Android.OS.Environment.DirectoryDcim;
            logger.Info($"DirectoryDcim=>{path}");
            path = Android.OS.Environment.DirectoryDocuments;
            logger.Info($"DirectoryDocuments=>{path}");
            path = Android.OS.Environment.DirectoryDownloads;
            logger.Info($"DirectoryDownloads=>{path}");
            path = Android.OS.Environment.DirectoryMovies;
            logger.Info($"DirectoryMovies=>{path}");
            path = Android.OS.Environment.DirectoryMusic;
            logger.Info($"DirectoryMusic=>{path}");
            path = Android.OS.Environment.DirectoryNotifications;
            logger.Info($"DirectoryNotifications=>{path}");
            path = Android.OS.Environment.DirectoryPictures;
            logger.Info($"DirectoryPictures=>{path}");
            path = Android.OS.Environment.DirectoryPodcasts;
            logger.Info($"DirectoryPodcasts=>{path}");
            path = Android.OS.Environment.DirectoryRingtones;
            logger.Info($"DirectoryRingtones=>{path}");
            file = Android.OS.Environment.DownloadCacheDirectory;
            logger.Info($"DownloadCacheDirectory=>{file?.AbsolutePath}");
            file = Android.OS.Environment.ExternalStorageDirectory;
            logger.Info($"ExternalStorageDirectory=>{file?.AbsolutePath}");
            file = Android.OS.Environment.RootDirectory;
            logger.Info($"RootDirectory=>{file.AbsolutePath}");
            Android.Content.Context? context = this.Application?.ApplicationContext;
            logger.Info($"DataDir=>{context?.DataDir}");
            logger.Info($"PackageName=>{context?.PackageName}");
            logger.Info($"OpPackageName=>{context?.OpPackageName}");
            logger.Info($"CodeCacheDir=>{context?.CodeCacheDir}");
        }
    }
}