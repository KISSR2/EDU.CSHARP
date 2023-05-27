using System;

namespace LottóSorsoló
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hány darab számot szeretnél kisorsolni?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            int[] t = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(1, 90);
                for (int j = 0; j < i; j++)
                {
                    if (t[i] == t[j])
                    {
                        t[i] = rnd.Next(1, 90);
                        j = 0;
                    }
                }
                Console.WriteLine("{0}", t[i]);
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}