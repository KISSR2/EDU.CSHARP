using System;
using System.Collections.Generic;

namespace NőkOsztály
{
    internal class no
    {
        public string nev;
        public string telszam;
        public double mellboseg;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<no> nok = new List<no>();
            no ujno;
            do
            {
                Console.WriteLine("Kérem a nő / leány nevét!");
                ujno = new no();
                ujno.nev = Console.ReadLine();
                if (ujno.nev != "")
                {
                    nok.Add(ujno);
                }
            } while (ujno.nev != "");

            // Legnagyobb mellbőségű nő sorszáma
            int sorszam = 0;

            for (int i = 0; i < nok.Count; i++)
            {
                Console.WriteLine("Add meg {0} adatait!", nok[i].nev);
                Console.WriteLine("  telefonszám:");
                nok[i].telszam = Console.ReadLine();
                Console.WriteLine("  mellbőség:");
                nok[i].mellboseg = double.Parse(Console.ReadLine());

                if (nok[i].mellboseg > nok[sorszam].mellboseg)
                {
                    sorszam = i;
                }
            }

            Console.WriteLine("Neve: {0} telefonszáma: {1}", nok[sorszam].nev, nok[sorszam].telszam);
            Console.ReadKey();
        }
    }
}