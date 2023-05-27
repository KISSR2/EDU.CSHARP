using System;

namespace DolgozoRáérés
{
    internal class Program
    {
        [Flags]
        private enum Hét
        { Hétfő = 1, Kedd = 2, Szerda = 4, Csütörtök = 8, Péntek = 16 };

        private static void Main(string[] args)
        {
            Hét Attila = Hét.Hétfő;
            Hét Miklós = Hét.Kedd;
            Hét Sándor = Hét.Csütörtök;
            Hét Gréta = Hét.Péntek;
            Hét Alex = Hét.Csütörtök;
            var bejelölt = Attila | Miklós | Sándor | Gréta | Alex;
            Console.WriteLine("Bejelölt hetek: " + bejelölt);
            Console.WriteLine("Attila: " + Attila + "\nMiklós: " + Miklós + "\nSándor: " + Sándor + "\nGréta: " + Gréta + "\nAlex: " + Alex + "\n");

            if (Attila == Hét.Péntek)
            {
                Console.WriteLine("Van olyan aki a pénteket jelölte be!");
            }
            else if (Miklós == Hét.Péntek)
            {
                Console.WriteLine("Van olyan aki a pénteket jelölte be!");
            }
            else if (Sándor == Hét.Péntek)
            {
                Console.WriteLine("Van olyan aki a pénteket jelölte be!");
            }
            else if (Gréta == Hét.Péntek)
            {
                Console.WriteLine("Van olyan aki a pénteket jelölte be!");
            }
            else if (Alex == Hét.Péntek)
            {
                Console.WriteLine("Van olyan aki a pénteket jelölte be!");
            }
            else Console.WriteLine("Nincs olyan aki a pénteket jelölte be!");

            Console.WriteLine("A dolgozók többsége a {0} napot jelölték be!");
            Console.ReadKey();
        }
    }
}