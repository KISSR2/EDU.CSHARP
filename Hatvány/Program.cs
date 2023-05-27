using System;

namespace Hatvány
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kérem a számot: ");
            int n = int.Parse(Console.ReadLine());
            int szam = 1;
            Console.WriteLine("\n{0} hatványai: \n", n);
            for (int i = 0; i <= 16; i++)
            {
                Console.WriteLine("{0}", szam);
                szam *= n;
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}