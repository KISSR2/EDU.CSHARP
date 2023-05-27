using System;

namespace RandomPárosSzámok
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region TÖMB FELTÖLTÉS, VÉLETLENSZAM GENERÁLÁSSAL

            Random r = new Random();
            int[] tomb1 = new int[21];
            int i;

            for (i = 0; i < 20; i++)
            {
                tomb1[i] = r.Next(0, 100);
            }

            #endregion TÖMB FELTÖLTÉS, VÉLETLENSZAM GENERÁLÁSSAL

            #region PÁROSSZÁM VIZSGÁLAt

            for (i = 0; i <= 20; i++)
            {
                if (tomb1[i] % 2 == 0)
                {
                    Console.Write("{0}, ", tomb1[i]);
                }
            }

            #endregion PÁROSSZÁM VIZSGÁLAt

            Console.ReadKey();
        }
    }
}