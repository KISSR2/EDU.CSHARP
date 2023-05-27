using System;

namespace Tippelő
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 101);

            int szam;

            do
            {
                Console.WriteLine("Kérem a számot:");
                szam = int.Parse(Console.ReadLine());

                if (x > szam)
                {
                    Console.WriteLine("Nagyobb lett a tippnél!");
                }
                else if (x < szam)
                {
                    Console.WriteLine("Kissebb lett a tippnél!");
                }
            } while (x != szam);

            Console.WriteLine("Eltaláltad a számot amely a {0}", x);
            Console.ReadKey();
        }
    }
}