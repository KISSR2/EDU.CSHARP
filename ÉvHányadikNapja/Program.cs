using System;

namespace ÉvHányadikNapja
{
    internal class Program
    {
        private static int Szokoev(int ev)
        {
            int szokoev = 0;
            if ((ev > 1582) && (ev % 4 == 0) && (ev % 100 != 0) || (ev % 400 == 0))
            {
                szokoev++;
            }
            return szokoev;
        }

        private static void Main(string[] args)
        {
            int ev = 0, ho = 0, nap = 0, szokoev = 0;
            int eredmeny = 0;
            Console.Write("Kérem az évet: ");
            ev = int.Parse(Console.ReadLine());
            Console.Write("Kérem a hónapot: ");
            ho = int.Parse(Console.ReadLine());
            Console.Write("Kérem a napot: ");
            nap = int.Parse(Console.ReadLine());

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
                Console.WriteLine("{0}.{1}.{2} dátumb szökőévben van és ez az év {3}. napja!", ev, ho, nap, eredmeny + szokoev);
            }
            else if (szokoev != 0)
            {
                Console.WriteLine("{0}.{1}.{2} dátumb szökőévben van és ez az év {3}. napja!", ev, ho, nap, eredmeny);
            }
            else
            {
                Console.WriteLine("{0}.{1}.{2} dátumb nem szökőévben van és ez az év {3}. napja!", ev, ho, nap, eredmeny);
            }

            Console.ReadKey();
        }
    }
}