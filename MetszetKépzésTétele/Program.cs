using System;

namespace MetszetKépzésTétele
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int N = 5;
            string[] A = new string[N];
            const int M = 4;
            string[] B = new string[N];
            string[] C = new string[M];

            int i, j, db;

            for (i = 0; i < N; i++)
            {
                Console.Write("Add meg az 'A' tömb {0}. szövegét: ", i);
                A[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");

            for (i = 0; i < M; i++)
            {
                Console.Write("Add meg az 'B' tömb {0}. szövegét: ", i);
                B[i] = Console.ReadLine();
            }

            //Metszet
            db = 0;
            for (i = 0; i < N; i++)
            {
                j = 0;
                while (j < M && A[i] != B[j])
                {
                    j++;
                }
                if (j < M)
                {
                    C[db] = A[i];
                    db++;
                }
            }

            Console.WriteLine("\nKözös elemek:");
            for (i = 0; i < db; i++)
            {
                Console.Write("{0} ", C[db]);
            }

            Console.ReadKey();
        }
    }
}