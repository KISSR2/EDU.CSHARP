using System;

namespace MásodfokúEgyenlet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("Adja meg a másodfokú egyenlet együtthatóit!");
            Console.WriteLine();
            Console.WriteLine("Kérem a(z) 'a' értékét: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("\n Ez az egyenlet nem lehet másodfokú!");
            }
            else
            {
                Console.WriteLine("Kérem a(z) 'b'  értékét: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kérem a(z) 'c'  értékét: ");
                c = Convert.ToDouble(Console.ReadLine());
                d = b * b - 4 * a * c;
                Console.WriteLine();
                if (d < 0)
                {
                    Console.WriteLine("Nincs valós gyöke van az egyenletnek!");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1={0} \tX2={1}", x1, x2);
                }
            }
            Console.WriteLine("\n\nNyomj le egy entert a kilépéshez...");
            Console.ReadKey(false);

            Console.ReadKey();
        }
    }
}