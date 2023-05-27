using System;
using System.Collections.Generic;

namespace BevásárlásOsztály
{
    internal class bevasarlas
    {
        public string nev;
        public double mennyiseg;
        public int egysegar;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<bevasarlas> vasarlas = new List<bevasarlas>();

            Console.WriteLine("Hány darab áru lesz?");
            int n = int.Parse(Console.ReadLine());

            //bevasarlas[] vasarlas = new bevasarlas[n];

            for (int i = 0; i < n; i++)
            {
                bevasarlas adatok = new bevasarlas();
                Console.WriteLine("Név:");
                adatok.nev = Console.ReadLine();
                Console.WriteLine("Mennyiség:");
                adatok.mennyiseg = double.Parse(Console.ReadLine());
                Console.WriteLine("Egységár:");
                adatok.egysegar = int.Parse(Console.ReadLine());
                vasarlas.Add(adatok);
            }

            Console.WriteLine("500 Ft-nál drágább áruk:");
            for (int j = 0; j < vasarlas.Count; j++)
            {
                if (vasarlas[j].egysegar > 500)
                {
                    Console.WriteLine("Neve: {0} Mennyiség: {1} Egységár: {2}",
                        vasarlas[j].nev, vasarlas[j].mennyiseg, vasarlas[j].egysegar);
                }
            }
            double ar = 0;
            int maxar = 0;
            string aruneve = "";
            for (int k = 0; k < vasarlas.Count; k++)
            {
                if (vasarlas[k].egysegar > maxar)
                {
                    maxar = vasarlas[k].egysegar;

                    aruneve = vasarlas[k].nev;
                }
                ar += vasarlas[k].egysegar * vasarlas[k].mennyiseg;
            }
            Console.WriteLine("Legdrágább áru neve: {0}", aruneve);
            Console.WriteLine("Elköltött összeg: {0}", ar);

            Console.ReadKey();
        }
    }
}