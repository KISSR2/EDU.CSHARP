using System;

namespace ZsidóVerseny
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] J = new int[300];
            int[] Z = new int[300];
            int jakob = 0;
            int zakarias = 0;

            Random rnd = new Random();

            for (int n = 0; n < 300; n++)
            {
                J[n] = rnd.Next(80, 101);
                Z[n] = rnd.Next(80, 101);

                if (J[n] > Z[n])
                {
                    jakob++;
                }
                else if (J[n] < Z[n])
                {
                    zakarias++;
                }
            }

            if (jakob > zakarias)
            {
                Console.WriteLine("Jakob nyert!");
            }
            else if (zakarias < jakob)
            {
                Console.WriteLine("Zakarias nyert!");
            }
            else
            {
                Console.WriteLine("Az eredmeny dontetlen!");
            }
            Console.ReadKey();
        }
    }
}