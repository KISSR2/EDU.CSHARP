using System;

namespace AlgoritmusMátrixok
{
    internal class Program
    {
        private static Random rnd = new Random();

        private static int[,] osszead(int[,] tomb1, int[,] tomb2)
        {
            if (tomb1.GetLength(0) != tomb2.GetLength(0) || tomb1.GetLength(1) != tomb2.GetLength(1))
            {
                Console.WriteLine("Hiba");
                return null;
            }

            int[,] osszegtomb = new int[tomb1.GetLength(0), tomb1.GetLength(1)];
            for (int i = 0; i < tomb1.GetLength(0); i++)
            {
                for (int j = 0; j < tomb1.GetLength(1); j++)
                {
                    osszegtomb[i, j] = tomb1[i, j] + tomb2[i, j];
                }
            }
            return osszegtomb;
        }

        private static void kiir(int[,] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write("{0}  ", t[i, j]);
                }
                Console.WriteLine();
            }

            return;
        }

        private static int[,] transzponalt(int[,] x)
        {
            int[,] transztomb = new int[x.GetLength(1), x.GetLength(0)];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    transztomb[j, i] = x[i, j];
                }
            }
            return transztomb;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Kérem a tömb sorainak számát: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a tömb oszlopainak számát: ");
            int o = int.Parse(Console.ReadLine());

            int[,] matrix = new int[s, o];
            int[,] matrix2 = new int[s, o];

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < o; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    matrix2[i, j] = rnd.Next(-100, 100);
                }
            }

            Console.WriteLine("\nElső tömb\n");
            kiir(matrix);
            Console.WriteLine("\nMásodik tömb\n");
            kiir(matrix2);
            Console.WriteLine("\nÖsszeg tömb\n");
            kiir(osszead(matrix, matrix2));
            Console.WriteLine("\nTranszponált\n");
            kiir(transzponalt(matrix));

            Console.ReadLine();
        }
    }
}