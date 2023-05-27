using System;

//KISS RÓBERT - NEPTUN: J74B48
namespace DelegáltMűvelet
{
    internal class muveletek
    {
        public static int osszead(int i, int k)
        {
            return i + k;
        }

        public static int szorzas(int i, int k)
        {
            return i * k;
        }
    }

    internal class Program
    {
        private delegate int muvelet(int i, int k);

        private static void Main(string[] args)
        {
            int valasztas = 0;
            int a = 0, b = 0;

            Console.WriteLine("Kérlek válassz a funkciók közül!");
            Console.WriteLine("0 -- Kilépés a programból");
            Console.WriteLine("1 -- Két tetszőleges szám összeadása.");
            Console.WriteLine("2 -- Két tetszőleges szám szorzása.");

            do
            {
                Console.Write("\nKérem a használni kíván funkció sorszámát: ");
                valasztas = int.Parse(Console.ReadLine());
                if (valasztas < 0 || valasztas > 2)
                {
                    Console.WriteLine("\nA megadott menüpont érvénytelen!");
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
                        Console.Write("Kérem az első számot: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Kérem a második számot: ");
                        b = int.Parse(Console.ReadLine());
                        muvelet m = new muvelet(muveletek.osszead);
                        Console.WriteLine(m(a, b));
                    }
                    else if (valasztas == 2)
                    {
                        Console.Write("Kérem az első számot: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Kérem a második számot: ");
                        b = int.Parse(Console.ReadLine());
                        muvelet m = new muvelet(muveletek.szorzas);
                        Console.WriteLine(m(a, b));
                    }
                }
            } while (valasztas >= 0 || valasztas <= 2);
            Console.ReadKey();
        }
    }
}