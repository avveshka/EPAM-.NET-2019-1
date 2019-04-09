using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(Git.versionDirectory + @"\" + "0"))
            {
                Git.CopyTo(Git.gitDirectory, Git.versionDirectory + @"\" + Git.changeCount);
                File.AppendAllText(Git.logDirectory, "0) Изначальная версия\r\n");
            }
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = Git.gitDirectory;
                watcher.IncludeSubdirectories = true;
                watcher.Filter = "*.txt";
                watcher.EnableRaisingEvents = true;
                Git git = new Git(watcher, "logfile");
                string[] arrayForCount = git.GetVesrion();
                Git.changeCount = arrayForCount.Length - 1;
                Console.WriteLine("Напишите watch чтобы наблюдать");
                Console.WriteLine("Напишите change чтобы менять");
                string arg = Console.ReadLine();
                while (arg != "q")
                {
                    switch (arg)
                    {
                        case "watch":
                            git.Watch();
                            break;
                        case "change":
                            Console.WriteLine("Выберите,к какому состоянию откатить");
                            string[] array = git.GetVesrion();
                            for (int i = 0; i < array.Length; i++)
                            {
                                Console.WriteLine(array[i]);
                            }
                            int.TryParse(Console.ReadLine(), out int temp);
                            git.Change(temp);
                            break;
                        default:
                            Console.WriteLine("Неизвестная команда");
                            break;
                    }
                    arg = Console.ReadLine();
                }
            }
        }
    }
}
