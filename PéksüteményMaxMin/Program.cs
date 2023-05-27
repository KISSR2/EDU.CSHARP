using System;

namespace PéksüteményMaxMin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("BEMENET");

            #region TÖMB LÉTREHOZÁSA, MAJD FELTÖLTÉSÜK
            int[] tomb1 = new int[5];
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Add meg a {0}. péksütemény árát: ", i);
                tomb1[i] = Convert.ToInt32(Console.ReadLine());
            }
            #endregion TÖMB LÉTREHOZÁSA, MAJD FELTÖLTÉSÜK
            #region VÉLETLENSZÁM GENERÁLÁS
            Random r = new Random();
            int[] tomb2 = new int[5];

            for (i = 0; i < 5; i++)
            {
                tomb2[i] = r.Next(1, 100);
            }
            #endregion VÉLETLENSZÁM GENERÁLÁS

            #region KIIRATÁS
            Console.WriteLine("Kimenet");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\n{0}. Péksütemény ára: {1} Ft", i, tomb1[i]);
                Console.WriteLine("{0}. Péksütemény eladásainakszáma: {1} db", i, tomb2[i]);
            }
            #endregion KIIRATÁS
            # region VIZSGÁLAT, LEGOLCSÓBB KIVÁLASZTÁSA.
            int min, minhely;
            i = 0;
            min = tomb1[0];
            minhely = 0;
            for (i = 0; i < 5; i++)
            {
                if (min < tomb1[i])
                {
                    min = tomb1[i];
                    minhely = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nA {0}. a legolcsóbb péksütemény az összes közül!", i);
            #endregion

            #region LEGTOBB ELADÁS VIZSGÁLATA
            int max, maxhely;
            max = tomb2[0];
            maxhely = 0;
            for (i = 1; i < 5; i++)
            {
                if (max < tomb2[i])
                {
                    max = tomb2[i];
                    maxhely = i;
                }
            }
            Console.WriteLine("\nA legtöbb eladás: {0} darab volt.", max);
            #endregion
            #region LEGKEVESEBB BEVÉTEL
            int[] bev = new int[5];

            for (i = 0; i < 5; i++)
            {
                bev[i] = tomb1[i] * tomb2[i];
            }

            i = 0;
            min = bev[i];
            for (i = 0; i < 5; i++)
            {
                if (min > bev[i])
                {
                    min = bev[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("A legkevesebb bevétel: {0} forint volt!", min);
            #endregion
            Console.ReadKey();
        }
    }
}