using System;
using System.IO;

namespace Fájlmásolás
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path;
            string path2;
            string path3;
            Console.Write("Másolandó fájl neve, és kiterjesztése: ");
            path = Console.ReadLine();
            Console.Write("Cél teljes útvonala, és másolt fálj neve: ");
            path2 = Console.ReadLine();
            path3 = @"" + path2 + "";
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path)) { }
                }
                if (File.Exists(path3))
                    File.Delete(path3);

                File.Move(path, path3);
                Console.WriteLine("Sikeres áthelyezés történt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Áthelyezés sikertelen: {0}", e.ToString());
            }
            Console.ReadKey();
        }
    }
}