using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Git
    {
        private FileSystemWatcher _fileSystemWatcher;
        private TypeLogger loggerType;
        public static int changeCount = 0;
        public static string logDirectory = @"E:\progs\epam\reposit\EPAM-.NET-2019-1\LogsAndCopyes\log.txt";
        public static string gitDirectory = @"E:\progs\epam\reposit\EPAM-.NET-2019-1\MiniGitForTask12";
        public static string versionDirectory = @"E:\progs\epam\reposit\EPAM-.NET-2019-1\LogsAndCopyes";
        public Git(FileSystemWatcher fileSystemWatcher, string type)
        {
            _fileSystemWatcher = fileSystemWatcher;
            _fileSystemWatcher.Changed += OnChanged;
            _fileSystemWatcher.Created += OnChanged;
            _fileSystemWatcher.Deleted += OnChanged;
            _fileSystemWatcher.Renamed += OnRenamed;
            loggerType = new TypeLogger(type);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            changeCount++;
            CopyTo(gitDirectory, versionDirectory + @"\" + changeCount);
            string str = "";
            str += changeCount + ") " + e.ChangeType + " " + e.Name + " " + DateTime.Now + "\r\n";
            loggerType.Log(str);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            changeCount++;
            CopyTo(gitDirectory, versionDirectory + @"\" + changeCount);
            string str = "";
            str += changeCount + ") " + e.OldName + " " + e.ChangeType + " " + e.Name + " " + DateTime.Now + "\r\n";
            loggerType.Log(str);
        }

        public static void CopyTo(string sourcepath, string destpath)
        {
            if (!Directory.Exists(destpath))
            {
                Directory.CreateDirectory(destpath);
            }
            DirectoryInfo srcdir = new DirectoryInfo(sourcepath);
            DirectoryInfo[] srcdirs = srcdir.GetDirectories();
            FileInfo[] srcfiles = srcdir.GetFiles();
            foreach (FileInfo file in srcfiles)
            {
                string temppath = Path.Combine(destpath, file.Name);
                file.CopyTo(temppath, false);
            }
            foreach (DirectoryInfo subdir in srcdirs)
            {
                string temppath = Path.Combine(destpath, subdir.Name);
                CopyTo(subdir.FullName, temppath);
            }
        }

        public void GoToVersion(int version)
        {
            changeCount++;
            _fileSystemWatcher.EnableRaisingEvents = false;
            DirectoryInfo dirInfo = new DirectoryInfo(gitDirectory);
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                dir.Delete(true);
            }
            CopyTo(versionDirectory + @"\" + version, gitDirectory);
            CopyTo(gitDirectory, versionDirectory + @"\" + changeCount);
            string textToFile = changeCount + ") " + "Go to " + version + " version " + DateTime.Now + "\r\n";
            loggerType.Log(textToFile);
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        public void Watch()
        {
            if (!Directory.Exists(versionDirectory + @"\" + "0"))
            {
                CopyTo(gitDirectory, versionDirectory + @"\" + changeCount);
            }
        }

        public void Change(int version)
        {
            if (!Directory.Exists(versionDirectory + @"\" + "0"))
            {
                CopyTo(gitDirectory, versionDirectory + @"\" + changeCount);
            }
            GoToVersion(version);
        }

        public string[] GetVesrion()
        {
            string[] array;
            array = File.ReadAllLines(logDirectory);
            return array;
        }

    }
}
