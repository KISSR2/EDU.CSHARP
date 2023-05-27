using System;

namespace Elágazás_IF_Parse_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a neved!");
            string nev = Console.ReadLine();
            Console.WriteLine("Kérlek add meg a születési évedet!");
            ushort ev = ushort.Parse(Console.ReadLine());

            if (2019 - ev >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("**** + 18 ****");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Menj aludni, vár az ágyikó!");
            }

            Console.ReadKey();
        }
    }
}