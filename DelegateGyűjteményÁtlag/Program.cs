using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateGyűjteményÁtlag
{
    internal delegate double Ertek(List<int> lista);

    internal class Program
    {
        public static double atlag(List<int> lista)
        {
            double sum = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                sum += lista[i];
            }
            return sum / lista.Count();
        }

        public static double maselemek(List<int> lista)
        {
            double k = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < atlag(lista))
                {
                    k++;
                }
            }
            return (int)k;
        }

        private static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Ertek szamtaniatlag = new Ertek(atlag);
            Console.WriteLine("A számok számtani átlaga: " + szamtaniatlag(lista));
            Ertek kisebbatlah = new Ertek(maselemek);
            Console.WriteLine("Az átlagtól kissebb értékek darabszáma: " + kisebbatlah(lista));
            Console.ReadKey();
        }
    }
}