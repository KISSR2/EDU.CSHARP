using System;

namespace LegidősebbEmber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg a darabszámot");
            int db = int.Parse(Console.ReadLine());

            int minev = int.MaxValue;
            string legidos = "";

            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Kérem a nevét!");
                string nev = Console.ReadLine();
                Console.WriteLine("Kérem a születési dátumát");
                int ev = int.Parse(Console.ReadLine());

                if (ev < minev)
                {
                    minev = ev;
                    legidos = nev;
                }
            }
            Console.WriteLine("A legidősebb ember neve: {0}", legidos);
            Console.WriteLine("A legidősebb ember kora: {0}", DateTime.Now.Year - minev);

            Console.ReadKey();
        }
    }
}