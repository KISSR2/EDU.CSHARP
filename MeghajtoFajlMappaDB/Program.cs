using System;
using System.IO;

namespace MeghajtoFajlMappaDB
{
    internal class Program
    {
        private static long files = 0;
        private static long dirs = 0;

        private static void DirsFiles(FileSystemInfo[] FSInfo)
        {
            if (FSInfo == null)
            {
                throw new ArgumentNullException("FSInfo");
            }

            foreach (FileSystemInfo i in FSInfo)
            {
                if (i is DirectoryInfo)
                    dirs++;
                else if (i is FileInfo)
                    files++;
            }
        }

        private static void Main(string[] args)
        {
            FileStream stream = new FileStream("adatok.txt", FileMode.OpenOrCreate);

            try
            {
                DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                FileSystemInfo[] infos = dir.GetFileSystemInfos();
                Console.WriteLine("Információk begyűjtése folyamatban....");
                DirsFiles(infos);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("Könyvtárak száma:     {0} \t db", dirs);
                    writer.WriteLine("Fájlok száma:         {0} \t db", files);
                }
                Console.WriteLine("Az információk kiirása a fájlba sikeresen megtörtént!\n\n");
                Console.WriteLine("A fájlba kiirt adatok:\n");
                Console.WriteLine("Könyvtárak száma:\t {0} db", dirs);
                Console.WriteLine("Fájlok száma:\t\t {0} db", files);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }
    }
}