using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonokLINQ
{
    internal class Telefonok
    {
        public int telar { get; set; }
        public string telgyarto { get; set; }

        public Telefonok(int telar, string telgyarto)
        {
            this.telar = telar;
            this.telgyarto = telgyarto;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Telefonok> termekek = new List<Telefonok>();
            termekek.Add(new Telefonok(88000, "XIAOMI"));
            termekek.Add(new Telefonok(125000, "SAMSUNG"));
            termekek.Add(new Telefonok(112000, "XIAOMI"));
            termekek.Add(new Telefonok(65000, "HUAWEI"));
            termekek.Add(new Telefonok(220000, "APPLE"));
            termekek.Add(new Telefonok(420000, "APPLE"));
            termekek.Add(new Telefonok(100000, "XIAOMI"));
            termekek.Add(new Telefonok(56000, "LG"));
            termekek.Add(new Telefonok(90000, "LG"));
            termekek.Add(new Telefonok(180000, "SAMSUNG"));
            termekek.Add(new Telefonok(135000, "HUAWEI"));
            termekek.Add(new Telefonok(129000, "HUAWEI"));
            termekek.Add(new Telefonok(45000, "HUAWEI"));
            termekek.Add(new Telefonok(72000, "SONY"));
            termekek.Add(new Telefonok(88990, "SAMSUNG"));

            #region A legolcsóbb telefon adatai

            Console.WriteLine("A legolcsóbb telefon adatai:\n");
            var eredmeny = (from adat in termekek
                            orderby adat.telar ascending
                            select adat).Take(1);
            Console.WriteLine("Gyártó \t Ár");
            foreach (var termek in eredmeny)
            {
                Console.WriteLine(termek.telgyarto + " \t " + termek.telar + " Ft\n");
            }

            #endregion A legolcsóbb telefon adatai

            #region A telefonok darabszáma gyártónként

            Console.WriteLine("A telefonok darabszáma gyártónként:\n");
            Console.WriteLine("Gyártó \t\t Darab");
            foreach (var item in (termekek.GroupBy(info => info.telgyarto)
                    .Select(group => new { Gyarto = group.Key, Darab = group.Count() })
                    .OrderByDescending(x => x.Darab)))
            {
                Console.WriteLine("{0}\t\t {1}", item.Gyarto, item.Darab);
            }

            #endregion A telefonok darabszáma gyártónként

            Console.ReadKey();
        }
    }
}