using System;

namespace TömbFeltöltésKiválasztás
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region TÖMBFELTÖLTÉS

            Console.WriteLine("Kérem a hőmérsékletek darabszámát!");
            int N = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int[] tomb = new int[N];
            int i, sorszam;

            for (i = 0; i < N; i++)
            {
                tomb[i] = r.Next(-15, 10);
                Console.Write("{0} ", tomb[i]);
            }

            #endregion TÖMBFELTÖLTÉS

            #region KIVÁLASZTÁS TÉTELE

            i = 0;
            while (i < N && tomb[i] <= 5)
            {
                i++;
            }
            sorszam = i;
            Console.WriteLine();
            Console.WriteLine("Az első 5-től nagyobb homerseklet a {0}. helyen van ", sorszam + 1);
            Console.WriteLine("Értéke:? {0}", tomb[i]);
            Console.ReadKey();

            #endregion KIVÁLASZTÁS TÉTELE
        }
    }
}