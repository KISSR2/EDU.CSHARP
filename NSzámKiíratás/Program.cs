using System;

namespace NSzámKiíratás
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Meddig irassam ki a számokat: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}