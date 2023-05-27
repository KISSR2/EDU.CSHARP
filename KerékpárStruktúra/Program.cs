using System;
using System.Collections;

namespace Házas
{
    internal class Ház
    {
        public int méret;
        public int ár;

        public Ház(int méret, int ár)
        {
            this.méret = méret;
            this.ár = ár;
        }

        public int Méret
        {
            get { return méret; }
            set { méret = value; }
        }

        public int Ár
        {
            get { return ár; }
            set { ár = value; }
        }

        public override string ToString()
        {
            return "Ház mérete: " + méret + " ár: " + ár;
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            Hashtable hazlista = new Hashtable();
            Ház haz1 = new Ház(12, 55000);
            Ház haz2 = new Ház(10, 40000);
            Ház haz3 = new Ház(60, 150000);
            Ház haz4 = new Ház(120, 150000);
            Ház haz5 = new Ház(60, 90000);
            Ház haz6 = new Ház(90, 90000);
            Ház haz7 = new Ház(82, 120000);
            Ház haz8 = new Ház(77, 110000);
            Ház haz9 = new Ház(35, 150000);
            Ház haz10 = new Ház(40, 120000);

            try
            {
                hazlista.Add(haz1.méret, haz1.ár);
                hazlista.Add(haz2.méret, haz2.ár);
                hazlista.Add(haz3.méret, haz3.ár);
                hazlista.Add(haz4.méret, haz4.ár);
                hazlista.Add(haz5.méret, haz5.ár);
                hazlista.Add(haz6.méret, haz6.ár);
                hazlista.Add(haz7.méret, haz7.ár);
                hazlista.Add(haz8.méret, haz8.ár);
                hazlista.Add(haz9.méret, haz9.ár);
                hazlista.Add(haz10.méret, haz10.ár);


            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Hiba történt: {0}", ae.Message);
            }

            Console.ReadKey();
        }
    }
}
