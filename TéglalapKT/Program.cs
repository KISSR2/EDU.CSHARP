using System;

namespace TéglalapKT
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a magasságot!");
            double magassag = double.Parse(Console.ReadLine());

            Console.WriteLine("Kérlek add meg a szélességét!");
            double szelesseg = double.Parse(Console.ReadLine());

            if (magassag <= 0 || szelesseg <= 0)
            {
                Console.WriteLine("**** HIBÁS ADATOKAT ADTÁL MEG!****");
                Console.ReadKey();
                return;
            }

            double kerulet = 2 * (magassag + szelesseg);
            double terulet = magassag * szelesseg;
            Console.WriteLine("A téglalap kerülete: {0} és területe: {1}", kerulet, terulet);
            Console.ReadKey();
        }
    }
}