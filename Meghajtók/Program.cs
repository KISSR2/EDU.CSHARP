using System;
using System.IO;

namespace Meghajtók
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 0;
            const double BytesInMB = 1048576;
            const double BytesInGB = 1073741824;
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(i + "." + drive.Name);
                i++;
            }
            Console.Write("Kérem a meghajtóhoz tartozó sorszámot:");
            int sorsz = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (drives[sorsz].IsReady)
            {
                Console.WriteLine("Meghajtó neve : " + drives[sorsz].Name);
                Console.WriteLine("Kötetcimke : " + drives[sorsz].VolumeLabel);
                Console.WriteLine("Fájlrendszer: " + drives[sorsz].DriveFormat);
                Console.WriteLine("Típus: " + drives[sorsz].DriveType);
                double telitettseg = 100 - ((drives[sorsz].AvailableFreeSpace / (float)drives[sorsz].TotalSize) * 100);
                Console.WriteLine("Telítettség %-ban: {0:0.00} %", telitettseg);

                Console.WriteLine("Teljes méret:\t{0:0.00} MB\n\t\t{1:0.00} GB", drives[sorsz].TotalSize / BytesInMB, drives[sorsz].TotalSize / BytesInGB);
                Console.WriteLine();
            }
            else Console.WriteLine("Az eszköz nem áll készen!");

            Console.ReadLine();
        }
    }
}