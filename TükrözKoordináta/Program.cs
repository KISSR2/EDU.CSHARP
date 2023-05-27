using System;

namespace TükrözKoordináta
{
    internal class Program
    {
        private static void tükröz(int x, int y)
        {
            x *= -1;
            Console.WriteLine("Tükrözve:" + x + "," + y);
        }

        private static void Main(string[] args)
        {
            tükröz(5, 2);
            Console.ReadKey();
        }
    }
}