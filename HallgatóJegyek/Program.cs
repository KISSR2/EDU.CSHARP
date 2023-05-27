using System;

namespace HallgatóJegyek
{
    internal class Program
    {
        private static void megváltoztat(int?[] jegyek, int hely, int jegy)
        {
            jegyek[hely] = jegy;
        }

        private static void jegyekkiír(int?[] jegyek)
        {
            foreach (var jegy in jegyek)
            {
                Console.Write(jegy + " ");
            }
        }

        private static void Main(string[] args)
        {
            int?[] jegyek = new int?[] { 1, 2, 3, 4, 5, null };
            int valasztas = 0;
            Console.WriteLine("0 - Kilépés");
            Console.WriteLine("1 - Jegyek kiírastása");
            Console.WriteLine("2 - Jegyek változtatása");

            do
            {
                Console.Write("\nKérem a használni kíván funkció sorszámát: ");
                valasztas = int.Parse(Console.ReadLine());
                if (valasztas < 0 || valasztas > 2)
                {
                    Console.WriteLine("Hibás menüpontot adtál meg!");
                }
                else
                {
                    if (valasztas == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A program kilép....");
                        break;
                    }
                    else if (valasztas == 1)
                    {
                        jegyekkiír(jegyek);
                    }
                    else if (valasztas == 2)
                    {
                        megváltoztat(jegyek, 5, 5);
                    }
                }
            } while (valasztas >= 0 || valasztas <= 2);

            Console.ReadKey();
        }
    }
}