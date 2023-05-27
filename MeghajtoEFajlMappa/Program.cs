using System;
using System.IO;

namespace MeghajtoEFajlMappa
{
    internal class Program
    {
        private static long dirs = 0;

        private static void Dirs(FileSystemInfo[] FSInfo)
        {
            if (FSInfo == null)
            {
                throw new ArgumentNullException("FSInfo");
            }

            foreach (FileSystemInfo i in FSInfo)
            {
                if (i is DirectoryInfo && (i.Name.Contains("E") || i.Name.Contains("e")))
                {
                    dirs++;
                }
            }
        }

        private static void Main(string[] args)
        {
            FileStream stream = new FileStream("adatok.txt", FileMode.OpenOrCreate);

            try
            {
                DirectoryInfo dir = new DirectoryInfo("C:\\");
                FileSystemInfo[] infos = dir.GetFileSystemInfos();
                Console.WriteLine("Információk begyűjtése folyamatban....");
                Dirs(infos);
                Console.WriteLine("E betűt tartalmazó könyvtárak száma:     {0} \t db", dirs);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("E betűt tartalmazó könyvtárak száma:     {0} \t db", dirs);
                }
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }
    }
}