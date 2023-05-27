using System;

namespace HőmérsékleMaxIndex
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kérem a megmért hőmérésékletek darabszámát!");
            int db = Convert.ToInt32(Console.ReadLine());

            int[] s = new int[db];
            int i, max, maxhely;

            for (i = 0; i < db; i++)
            {
                Console.WriteLine("Add meg a {0}. hőmérsékletet!", i);
                s[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = s[0];
            maxhely = 0;
            for (i = 1; i < db; i++)
            {
                if (max < s[i])
                {
                    max = s[i];
                    maxhely = i;
                }
            }
            Console.WriteLine("A legmelegebb hőmérséklet: {0}", max);
            Console.WriteLine("Indexe: {0}", maxhely);
            Console.ReadKey();
        }
    }
}