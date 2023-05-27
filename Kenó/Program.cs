using System;
using System.Collections.Generic;

namespace Kenó
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Random rmd = new Random();

            bool megtalaltam = false;

            for (int i = 0; i < 20; i++)
            {
                int n = rmd.Next(1, 81);

                for (int j = 0; j < szamok.Count; j++)
                {
                    if (n == szamok[j])
                    {
                        megtalaltam = true;
                    }
                }

                if (megtalaltam == false)
                {
                    szamok.Add(n);
                }

                megtalaltam = false;
            }

            foreach (int x in szamok)
            {
                Console.WriteLine("{0}", x);
            }

            Console.ReadKey();
        }
    }
}