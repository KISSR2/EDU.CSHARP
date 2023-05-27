using System;

namespace KétSzóUniója
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string A, B;
            char[] C = new char[30];

            Console.WriteLine("Kerem az első szót:");
            A = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Kerem a második szót:");
            B = Console.ReadLine();

            int i, j, db;
            int N = A.Length;
            int M = B.Length;

            for (i = 0; i < N; i++)
            {
                C[i] = A[i];
            }
            db = N;
            for (j = 0; j < M; j++)
            {
                i = 0;
                while (i < N && A[i] != B[j])
                {
                    i++;
                }
                if (i == N)
                {
                    C[db] = B[j];
                    db++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("A két szó uniója:");
            for (i = 0; i < db; i++)
            {
                Console.Write("{0} ", C[i]);
            }
            Console.ReadKey();
        }
    }
}