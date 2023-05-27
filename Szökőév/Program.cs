using System;

namespace Szökőév
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ev;
            Console.Write("Kérem az évet: ");
            ev = int.Parse(Console.ReadLine());

            if ((ev % 4 == 0) && (ev % 100 != 0) || (ev % 400 == 0))
            {
                Console.WriteLine("A megadott év {0} szökőév!", ev);
            }
            else
            {
                Console.WriteLine("A megadott év {0}  nem szökőév!", ev);
            }
            Console.ReadKey();
        }
    }
}