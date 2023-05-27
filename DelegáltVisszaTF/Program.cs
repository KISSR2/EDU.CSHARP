using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegáltVisszaTF
{
    internal delegate bool Visszert(List<int> lista);

    internal class Program
    {
        public static bool neg(List<int> lista)
        {
            int vanjelző = 0;
            foreach (int i in lista)
            {
                if (i < 0)
                {
                    vanjelző = 1;
                    break;
                }
            }
            if (vanjelző == 1)
                return true;
            else
                return false;
        }

        public static bool mas(List<int> lista)
        {
            bool mase = lista.Distinct().Count() == lista.Count();
            return mase;
        }

        private static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1, 2, -3, 2, 5, 6 };
            Visszert eredmeny;
            eredmeny = new Visszert(neg);
            Console.WriteLine("Van-e benne negatív: " + eredmeny(lista));
            eredmeny = new Visszert(mas);
            Console.WriteLine("Egyedi-e mind: " + eredmeny(lista));
            Console.ReadKey();
        }
    }
}