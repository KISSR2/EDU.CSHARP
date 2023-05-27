using System;

namespace RandomTomb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] szamok = new int[20];
            int[] db = new int[31];
            int a = 0;
            int b = 0;
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = rnd.Next(1, 31);
                db[szamok[i] - 1]++;

                if (i % 2 == 0)
                {
                    a += szamok[i];
                }
                else
                    b += szamok[i];
            }

            double eredmeny = 0;
            if (a < b)
            {
                eredmeny = (1 - (double)a / b) * 100;
            }
            else
            {
                eredmeny = (1 - (double)b / a) * 100;
            }
            Console.WriteLine("Eltérés:{0}", eredmeny);

            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine("A {0} szám {1} szer szerepel a tömbben", i, db[i - 1]);
            }

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}