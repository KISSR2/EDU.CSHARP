using System;

namespace RandomSzámTömb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random r = new Random();
            int[] T = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                T[i] = T[i] + r.Next(1, 50);
                Console.Write("{0}, ", T[i]);
            }

            Console.ReadKey();
        }
    }
}