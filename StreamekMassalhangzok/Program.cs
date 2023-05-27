using System;

namespace StreamekMassalhangzok
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int darab = 0;
            int n = 0, i;
            string szo;

            Console.Write("Kérem a mondatot: ");
            szo = Console.ReadLine();
            char[] karakterek = szo.ToCharArray();
            n = karakterek.Length;

            for (i = 0; i < karakterek.Length; i++)
            {
                if (i != n - 1 && karakterek[i] == 'c' && karakterek[i + 1] == 's')
                    darab++;
                if (i != n - 1 && karakterek[i] == 'd' && karakterek[i + 1] == 'z')
                    darab++;
                if (i != n - 1 && karakterek[i] == 'd' && karakterek[i + 1] == 'z' && karakterek[i + 2] == 's')
                    darab++;
                if (i != n - 1 && karakterek[i] == 'g' && karakterek[i + 1] == 'y')
                    darab++;
                if (i != n - 1 && karakterek[i] == 'l' && karakterek[i + 1] == 'y')
                    darab++;
                if (i != n - 1 && karakterek[i] == 'n' && karakterek[i + 1] == 'y')
                    darab++;
                if (i != n - 1 && karakterek[i] == 's' && karakterek[i + 1] == 'z')
                    darab++;
                if (i != n - 1 && karakterek[i] == 't' && karakterek[i + 1] == 'y')
                    darab++;
                if (i != n - 1 && i != 0 && karakterek[i] == 'z' && karakterek[i + 1] == 's' && karakterek[i - 1] != 'd')
                    darab++;
            }

            Console.WriteLine("Mássalhangzók száma: " + darab);

            string modosult = szo.Replace("cs", "CS").
                                       Replace("dzs", "DZS").
                                       Replace("dz", "DZ").
                                       Replace("gy", "GY").
                                       Replace("ly", "LY").
                                       Replace("ny", "NY").
                                       Replace("sz", "SZ").
                                       Replace("ty", "TY").
                                       Replace("zs", "ZS");
            Console.WriteLine("----------------------------------- ");
            Console.WriteLine("Az eredeti mondat: ");
            Console.WriteLine(szo);
            Console.WriteLine("----------------------------------- ");
            Console.WriteLine("Az mássalhangzócserés mondat: ");
            Console.WriteLine(modosult);

            Console.ReadKey();
        }
    }
}