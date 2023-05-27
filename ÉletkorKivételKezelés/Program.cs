using System;

namespace ÉletkorKivételKezelés
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ev = 0, eletkor = 0, now = DateTime.Now.Year;
            do
            {
                Console.Write("\nKérem a születési évedet:");
                ev = int.Parse(Console.ReadLine());
                if (ev > now || ev < 0)
                {
                    Console.WriteLine("\nÉrvénytelen évszám!");
                }
                else
                {
                    eletkor = now - ev;
                    Console.WriteLine("Életkorod: {0}", eletkor);
                }
            } while (ev > now || ev < 0);

            Console.ReadKey();
        }
    }
}