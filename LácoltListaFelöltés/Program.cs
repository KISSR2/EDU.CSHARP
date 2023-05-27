using System;
using System.Collections.Generic;

namespace LácoltListaFelöltés
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double n = 1;
            LinkedList<double> lcnlista = new LinkedList<double>();
            do
            {
                lcnlista.AddLast(n);
                n++;
            } while (n < 21);
            foreach (double item in lcnlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}