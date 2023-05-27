using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerikusListaLINQ
{
    internal class Program
    {
        private enum kategoria
        { élelmiszer = 1, ital = 2, vegyi = 3, papír = 4, műszaki = 5 };

        private struct Termék
        {
            private int ID { get; set; }
            private string név { get; set; }
            private kategoria kategoria { get; set; }
            private int egysegar { get; set; }
            private int raktarkeszlet { get; set; }

            public Termék(int ID, string név, kategoria kategoria, int egysegar, int raktarkeszlet)
            {
                this.ID = ID;
                this.név = név;
                this.kategoria = kategoria;
                this.egysegar = egysegar;
                this.raktarkeszlet = raktarkeszlet;
            }

            private static void Main(string[] args)
            {
                List<Termék> termekek = new List<Termék>();
                termekek.Add(new Termék(1, "Liszt", kategoria.élelmiszer, 120, 10));
                termekek.Add(new Termék(2, "Só", kategoria.élelmiszer, 110, 15));
                termekek.Add(new Termék(3, "Cukor", kategoria.élelmiszer, 175, 25));
                termekek.Add(new Termék(4, "Pepsi", kategoria.ital, 320, 15));
                termekek.Add(new Termék(5, "Márka", kategoria.ital, 290, 5));
                termekek.Add(new Termék(6, "Hypo", kategoria.vegyi, 90, 0));
                termekek.Add(new Termék(7, "AAA Elem", kategoria.műszaki, 100, 20));
                termekek.Add(new Termék(8, "Papír", kategoria.papír, 700, 10));
                termekek.Add(new Termék(9, "Olaj", kategoria.élelmiszer, 250, 12));
                termekek.Add(new Termék(10, "Tej", kategoria.élelmiszer, 210, 48));

                #region A három legdrágább termék kilistázása

                Console.WriteLine("\n--------------------------------\n");
                var eredmeny = (from adat in termekek
                                orderby adat.egysegar descending
                                select adat).Take(3);
                Console.WriteLine("ID \t Név \t Kat. \t Ár \t RaktárK \t");
                foreach (var termek in eredmeny)
                {
                    Console.WriteLine(termek.ID + " \t " + termek.név + " \t " + termek.kategoria + " \t " + termek.egysegar + " Ft\t " + termek.raktarkeszlet + " DB");
                }
                Console.WriteLine("\n--------------------------------\n");

                #endregion A három legdrágább termék kilistázása

                #region Azon termékek (ID, név) listája amelynek raktárkészlete = 0

                var eredmeny1 = from adat in termekek
                                where adat.raktarkeszlet == 0
                                orderby adat.ID
                                select adat;

                Console.WriteLine("ID \t Név");

                foreach (var raktarkeszelet in eredmeny1)
                {
                    Console.WriteLine(raktarkeszelet.ID + " \t " + raktarkeszelet.név);
                }
                Console.WriteLine("\n--------------------------------\n");

                #endregion Azon termékek (ID, név) listája amelynek raktárkészlete = 0

                #region Azon műszaki termékek (név,ár) listája amelyeknek raktárkészlet > 5

                var eredmeny2 = from adat in termekek
                                where adat.kategoria == kategoria.műszaki && adat.raktarkeszlet > 5
                                orderby adat.ID
                                select adat;

                Console.WriteLine("ID \t Név");

                foreach (var muszakiraktar in eredmeny2)
                {
                    Console.WriteLine(muszakiraktar.ID + " \t " + muszakiraktar.név);
                }
                Console.WriteLine("\n--------------------------------\n");

                #endregion Azon műszaki termékek (név,ár) listája amelyeknek raktárkészlet > 5

                #region Kategóriánként a legolcsóbb termék neve

                var eredmény3 = (from adat in termekek
                                 orderby adat.egysegar ascending
                                 orderby adat.kategoria
                                 group adat by adat.kategoria
                                 into csoport
                                 select csoport.OrderBy(p => p.egysegar).First());
                foreach (var kategcsopot in eredmény3)
                {
                    Console.WriteLine(kategcsopot.kategoria + "\n\t" + kategcsopot.név);
                }

                Console.WriteLine("\n--------------------------------\n");

                #endregion Kategóriánként a legolcsóbb termék neve

                #region A raktárkészlet összértéke

                int sum = 0;
                for (int i = 0; i < termekek.Count; i++)
                {
                    sum = sum + (termekek[i].egysegar * termekek[i].raktarkeszlet);
                }
                Console.WriteLine("A raktárkészélet összértéke: {0} Ft", sum);

                #endregion A raktárkészlet összértéke

                Console.ReadKey();
            }
        }
    }
}