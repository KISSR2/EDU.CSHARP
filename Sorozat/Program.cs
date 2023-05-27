using System;

namespace Sorozat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int szam = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", szam);
                szam = szam + i + 1;
            }
            Console.ReadKey();
        }
    }
}