using System;

namespace RandomÖsszeg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(10, 101);

            int[] szamok = new int[n];
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(-999, 1000);
                if (x < -99 || x > 99)
                    szamok[i] = x;
                else
                    i--;
            }
            int k = rnd.Next(2, 11);
            int osszeg = 0;
            for (int j = 0; j < n; j++)
            {
                if (szamok[j] % k == 0)
                {
                    osszeg += szamok[j];
                }
            }
            Console.WriteLine("Összeg:{0}", osszeg);
            Console.ReadKey();
        }
    }
}