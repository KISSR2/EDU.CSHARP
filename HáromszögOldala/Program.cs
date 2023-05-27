using System;

namespace HáromszögOldala
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg A egy számot:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Adjon meg B egy számot:");
            int b = int.Parse(Console.ReadLine());

            //if (a%2 != b%2)
            if ((a % 2 == 0 && b % 2 == 1) || (a % 2 == 1 && b % 2 == 0))
            {
                Console.WriteLine("Adjon meg C egy számot:");
                int c = int.Parse(Console.ReadLine());

                if (a - b == c)
                    Console.WriteLine("A számok megfelelők");
                else
                    Console.WriteLine("Hiba");
            }
            else
                Console.WriteLine("Hiba");

            Console.ReadKey();
        }
    }
}