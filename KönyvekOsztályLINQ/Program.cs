using System;
using System.Collections.Generic;
using System.Linq;

namespace KönyvekOsztályLINQ
{
    internal enum tipus
    { szépirodalom = 1, ifjúsági = 2, idegen_nyelv = 3, tudományos = 4, kortárs = 5 };

    internal class Könyvek
    {
        public string kcím { get; set; }
        public int kár { get; set; }
        public tipus kategoria { get; set; }

        public Könyvek(string kcím, int kár, tipus kategoria)
        {
            this.kcím = kcím;
            this.kár = kár;
            this.kategoria = kategoria;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Könyvek> termekek = new List<Könyvek>();
            termekek.Add(new Könyvek("Könyv1", 1200, tipus.idegen_nyelv));
            termekek.Add(new Könyvek("Könyv2", 1000, tipus.szépirodalom));
            termekek.Add(new Könyvek("Könyv3", 100, tipus.szépirodalom));
            termekek.Add(new Könyvek("Könyv4", 2200, tipus.kortárs));
            termekek.Add(new Könyvek("Könyv5", 4200, tipus.szépirodalom));
            termekek.Add(new Könyvek("Könyv6", 1120, tipus.kortárs));
            termekek.Add(new Könyvek("Könyv7", 152, tipus.kortárs));
            termekek.Add(new Könyvek("Könyv8", 99, tipus.kortárs));

            #region LINQ 1. Hány kortárs könyv olcsóbb 4000 Ft-nál?

            var eredmeny1 = (from adat in termekek
                             where adat.kategoria == tipus.kortárs && adat.kár < 4000
                             select adat).Count();
            Console.WriteLine("4000 Ft olcsóbb kortárs könyvek száma: {0} db\n", eredmeny1);

            #endregion LINQ 1. Hány kortárs könyv olcsóbb 4000 Ft-nál?

            #region LINQ 2. Mi a legdrágább könyv címe?

            Console.WriteLine("A legdrágább könyv adatai:\n");
            var eredmeny = (from adat in termekek
                            orderby adat.kár descending
                            select adat).Take(1);
            Console.WriteLine("Név\t  Kategória\t  Ár");
            foreach (var termek in eredmeny)
            {
                Console.WriteLine(termek.kcím + "\t  " + termek.kategoria + "\t  " + termek.kár + " Ft\n");
            }

            #endregion LINQ 2. Mi a legdrágább könyv címe?

            #region LINQ 3. Melyik típusú könyvből van a legtöbb?

            Console.WriteLine("A legtöbb könyv típusa és darabszáma:\n");
            Console.WriteLine("Típus \t\t Darab");
            foreach (var item in (termekek.GroupBy(info => info.kategoria)
                    .Select(group => new { Tipus = group.Key, Count = group.Count() })
                    .OrderByDescending(x => x.Tipus)).Take(1))
            {
                Console.WriteLine("{0} \t {1}", item.Tipus, item.Count);
            }

            #endregion LINQ 3. Melyik típusú könyvből van a legtöbb?

            Console.ReadKey();
        }
    }
}