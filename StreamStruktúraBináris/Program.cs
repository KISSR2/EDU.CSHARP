using System;
using System.Collections.Generic;
using System.IO;

namespace StreamStruktúraBináris
{
    internal class Program
    {
        private struct Hallgató
        {
            public string név;
            public string szak;

            public Hallgató(string név, string szak)
            {
                this.név = név;
                this.szak = szak;
            }
        }

        private static void Main(string[] args)
        {
            List<Hallgató> hallgatók = new List<Hallgató>();
            hallgatók.Add(new Hallgató("Alap Aladár", "PTI"));
            hallgatók.Add(new Hallgató("Gipsz Jakab", "PTI"));
            hallgatók.Add(new Hallgató("Miskolci Eni", "PTI"));
            hallgatók.Add(new Hallgató("Kovács Emese", "PED"));
            hallgatók.Add(new Hallgató("Braun Ádám", "BIO"));
            Console.WriteLine("Hallgató neve \t\t Szakja");

            foreach (Hallgató egy_hallgató in hallgatók)
            {
                Console.WriteLine(egy_hallgató.név + " \t\t " + egy_hallgató.szak);
            }
            //Kiiratás
            try
            {
                FileStream fs = new FileStream("hallgatók.bin", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                foreach (Hallgató egy_hallgató in hallgatók)
                {
                    bw.Write(egy_hallgató.név);
                    bw.Write(egy_hallgató.szak);
                }

                Console.WriteLine("Adatok fájlba történő írása sikeresen megtörtént!");
                Console.WriteLine();
                bw.Close();
                fs.Close();
            }
            catch (IOException ioexp)
            {
                Console.WriteLine("Sikertelen a bináris fájlba történő mentés! \nHibaleírás: {0}", ioexp.Message);
            }

            Console.ReadKey();
        }
    }
}