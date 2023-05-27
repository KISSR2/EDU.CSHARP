using System;

namespace Elágazás_IF_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kérlek, írd be a vezetéknevedet!");
            string vnev = Console.ReadLine();

            Console.WriteLine("Kérlek, írd be, hogy a keresztnevedet!");
            string knev = Console.ReadLine();

            Console.WriteLine("Milyen nemzetiségű vagy? (angol/magyar)!");
            string nemzetiseg = Console.ReadLine();

            if (nemzetiseg == "magyar")
            {
                Console.WriteLine("Jó napot, {0} {1}", vnev, knev);
            }
            else
            {
                Console.WriteLine("Hello, {1} {0}", vnev, knev);
            }
            Console.ReadKey();
        }
    }
}