using System;

namespace TTömbFeltöltés
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region tömbök feltötlése

            const int N = 100;
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            #endregion tömbök feltötlése

            #region 2-vel osztható számok

            int Adb = 0, Bdb = 0, i, j;
            for (i = 2; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    A[Adb] = i;
                    Adb++;
                }
            }
            for (i = 0; i < Adb; i++)
            {
                Console.Write("\nKettővel osztható számok: {0} ", A[i]);
            }

            #endregion 2-vel osztható számok

            #region 3-al osztható számok

            for (i = 3; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    B[Bdb] = i;
                    Bdb++;
                }
            }
            Console.WriteLine();
            for (i = 0; i < Adb; i++)
            {
                Console.Write("\nHáromal osztható számok: {0} ", B[i]);
            }

            #endregion 3-al osztható számok

            #region Metszet

            int Cdb = 0;
            for (i = 0; i < Adb; i++)
            {
                j = 0;
                while (j < Bdb && A[i] != B[j])
                {
                    j++;
                }
                if (j < Bdb)
                {
                    C[Cdb] = A[i];
                    Cdb++;
                }
            }
            Console.WriteLine();
            for (i = 0; i < Cdb; i++)
            {
                Console.Write("\nMetszet: {0} ", C[i]);
            }

            #endregion Metszet

            Console.ReadKey();
        }
    }
}