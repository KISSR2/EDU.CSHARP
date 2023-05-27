using System;

namespace ConsoleMenü
{
    internal class Program
    {
        public static int Szokoev(int ev)
        {
            int szokoev = 0;
            if ((ev > 1582) && (ev % 4 == 0) && (ev % 100 != 0) || (ev % 400 == 0))
            {
                szokoev++;
            }
            return szokoev;
        }

        public static void Napszamitas(int ev, int ho, int nap)
        {
            int szokoev = 0, eredmeny = 0;
            szokoev = Szokoev(ev);
            switch (ho)
            {
                case 1: eredmeny = nap; break;
                case 2: eredmeny = 31 + nap; break;
                case 3: eredmeny = 59 + nap; break;
                case 4: eredmeny = 90 + nap; break;
                case 5: eredmeny = 120 + nap; break;
                case 6: eredmeny = 151 + nap; break;
                case 7: eredmeny = 181 + nap; break;
                case 8: eredmeny = 212 + nap; break;
                case 9: eredmeny = 243 + nap; break;
                case 10: eredmeny = 273 + nap; break;
                case 11: eredmeny = 304 + nap; break;
                case 12: eredmeny = 334 + nap; break;
            }
            if (szokoev != 0 && eredmeny > 59)
            {
                Console.WriteLine("{0}.{1}.{2} dátum szökőévben van és ez az év {3}. napja!", ev, ho, nap, eredmeny + szokoev);
            }
            else if (szokoev != 0)
            {
                Console.WriteLine("{0}.{1}.{2} dátum szökőévben van és ez az év {3}. napja!", ev, ho, nap, eredmeny);
            }
            else
            {
                Console.WriteLine("{0}.{1}.{2} dátum nem szökőévben van és ez az év {3}. napja!", ev, ho, nap, eredmeny);
            }
        }

        private static void Main(string[] args)
        {
            int valasztas = 0;
            int ev = 0, ho = 0, nap = 0;
            Console.WriteLine("0 - Kilépés a programból");
            Console.WriteLine("1 - Aktuális dátum információinak lekérdezése!");
            Console.WriteLine("2 - Manuális dátum információinak lekérdezése!");

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
                        Console.WriteLine("\nA pontos dátum és idő: {0:d}", DateTime.Now);
                        ev = DateTime.Now.Year;
                        ho = DateTime.Now.Month;
                        nap = DateTime.Now.Day;
                        Console.WriteLine("\nA dátum információi: ");
                        Napszamitas(ev, ho, nap);
                    }
                    else if (valasztas == 2)
                    {
                        Console.Write("Kérem az évet: ");
                        ev = int.Parse(Console.ReadLine());
                        Console.Write("Kérem a hónapot: ");
                        ho = int.Parse(Console.ReadLine());
                        Console.Write("Kérem a napot: ");
                        nap = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nA dátum információi: ");
                        Napszamitas(ev, ho, nap);
                    }
                }
            } while (valasztas >= 0 || valasztas <= 2);
            Console.ReadKey();
        }
    }
}