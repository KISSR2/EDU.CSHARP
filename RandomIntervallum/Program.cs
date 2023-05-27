using System;

namespace RandomIntervallum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] szamok = new int[40];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(100, 1000);

                Console.Write(szamok[i]);

                if (i < szamok.Length - 1)
                    Console.Write("\n ");
            }
            Console.WriteLine();

            int a;

            do
            {
                Console.WriteLine("Kérek egy háromjegyű számot!");
                a = int.Parse(Console.ReadLine());
            } while (a < 100 || a >= 1000);

            int db = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] >= a - 50 && szamok[i] < a + 50)
                {
                    db++;
                }
            }
            Console.WriteLine("Intervallumba eső számok: {0}", db);
            Console.ReadKey();
        }
    }
}