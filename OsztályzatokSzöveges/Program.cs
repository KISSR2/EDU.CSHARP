using System;

namespace OsztályzatokSzöveges
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int jegy;
            int db = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Kérem az osztályzatot: ");
                jegy = int.Parse(Console.ReadLine());
                if (jegy <= 5 && jegy > 0)
                {
                    db++;
                    sum += jegy;
                }
                else
                    Console.WriteLine("Hibás adat!");
                break;
            } while (true);

            if (sum / db < 2)
            {
                Console.WriteLine("Megbukott!");
            }

            Console.ReadKey();
        }
    }
}