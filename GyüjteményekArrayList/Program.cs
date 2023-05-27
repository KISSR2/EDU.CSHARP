using System;
using System.Collections;

namespace Gyüjtemények
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Nem billentyűzetről történő feltöltés

            ArrayList mylist = new ArrayList();
            mylist.Add("A");
            mylist.Add("B");
            mylist.Add("C");
            mylist.Add("D");
            mylist.Add("E");
            mylist.Add("F");
            mylist.Add("G");
            mylist.Add("H");

            Console.WriteLine("A gyűjteménybe felvitt elemek: ");
            foreach (string value in mylist)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Feltöltöttek száma\t " + mylist.Count + " db");
            Console.WriteLine("Kapacitás\t\t " + mylist.Capacity + " db\n");

            #endregion Nem billentyűzetről történő feltöltés

            #region Billentyűzetről történő feltöltés

            int i, n;
            Console.Write("Hány elemű legyen a gyűjtemény: ");
            n = int.Parse(Console.ReadLine());
            ArrayList mylist1 = new ArrayList(n);

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0}. elem: ", i);
                mylist1.Add(Console.ReadLine());
            }

            Console.WriteLine("A gyűjteménybe felvitt elemek: ");
            foreach (string value in mylist1)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Feltöltöttek száma\t " + mylist1.Count + " db");
            Console.WriteLine("Kapacitás\t\t " + mylist1.Capacity + " db\n");

            #endregion Billentyűzetről történő feltöltés

            Console.ReadKey();
        }
    }
}