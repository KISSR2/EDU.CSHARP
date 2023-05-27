using System;

namespace PI
{
    internal class Program
    {
        private static double pi(int n)
        {
            double pi = 0;
            int x = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    pi += 4 / (double)x;
                }
                else
                {
                    pi += -(4 / (double)x);
                }
                x += 2;
            }
            return pi;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(pi(1000));
            Console.ReadKey();
        }
    }
}