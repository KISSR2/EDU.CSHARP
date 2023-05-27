using System;
using System.Collections.Generic;

namespace GyümölcsSzezononOOEnumOsztály
{
    internal enum szezonok
    { tavasz, nyar, osz, tel }

    internal class Gyumolcs
    {
        public int kgRaktaron;

        private int kgAr;

        public int KgAr
        {
            get
            {
                return kgAr;
            }
            set
            {
                if (value > 0)
                    kgAr = value;
                else
                    Console.WriteLine("Rossz érték lett megadva árként!");
            }
        }

        private string nev;

        public string Nev
        {
            get //olvasható
            {
                return nev;
            }
            private set //írható
            {
                if (value != "")
                    nev = value;
            }
        }

        public szezonok szezon;
        public DateTime lejarat;

        public Gyumolcs(string n, szezonok sz,
          int kgRaktaron, int kgAr, DateTime lejarat)
        {
            // MEZŐK INICIALIZÁLÁSA

            Nev = n;
            szezon = sz;
            this.kgRaktaron = kgRaktaron;
            this.kgAr = kgAr;
            this.lejarat = lejarat;
        }

        public Gyumolcs(string n, szezonok sz,
          int kgRaktaron, int kgAr, int ev, int ho, int nap)
        {
            // MEZŐK INICIALIZÁLÁSA

            nev = n;
            szezon = sz;
            this.kgRaktaron = kgRaktaron;
            this.kgAr = kgAr;
            this.lejarat = new DateTime(ev, ho, nap);
        }

        public Gyumolcs(string n, szezonok sz,
          int kgRaktaron, int kgAr)
        {
            // MEZŐK INICIALIZÁLÁSA

            nev = n;
            szezon = sz;
            this.kgRaktaron = kgRaktaron;
            this.kgAr = kgAr;
            this.lejarat = DateTime.Now.AddMonths(1); // 1 hónap múlva lejár
        }
    }

    internal class Program
    {
        private static List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();

        private static void Main(string[] args)
        {
            Gyumolcs almaGyumolcs = new Gyumolcs("alma", szezonok.osz, 1020,
              120, new DateTime(2010, 4, 17));

            gyumolcsok.Add(almaGyumolcs);

            Gyumolcs bananGyumolcs = new Gyumolcs("banán", szezonok.tel, 540,
              350);

            gyumolcsok.Add(bananGyumolcs);

            Listaz();
            Console.ReadKey();
        }

        private static void Listaz()
        {
            foreach (Gyumolcs gy in gyumolcsok)
            {
                Console.WriteLine("Gyümölcs neve: {0}", gy.Nev);
                Console.WriteLine("Szezon: {0}", gy.szezon);
                Console.WriteLine("Raktáron: {0} kg", gy.kgRaktaron);
                Console.WriteLine("Ár: {0} Ft/kg", gy.KgAr);
                Console.WriteLine("Lejárat dátuma: {0}", gy.lejarat.ToLongDateString());
                Console.WriteLine("======================");
            }
        }
    }
}