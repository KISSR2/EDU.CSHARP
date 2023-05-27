using System;
using System.IO;

namespace Mappakezelés
{
    internal class Program
    {
        private static void newfile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Új fájl érkezett a könyvtárba!");
        }

        private static void Main(string[] args)
        {
            FileSystemWatcher directorywat = new FileSystemWatcher();
            directorywat.Path = @"C:\proba";
            directorywat.Changed += new FileSystemEventHandler(newfile);
            directorywat.EnableRaisingEvents = true;
            Console.ReadKey();
        }
    }
}