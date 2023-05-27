using System;
using System.Collections.Generic;

namespace TáplálékTápértékOOEnumOsztály
{
    internal class Taplalek
    {
        private string nev;

        public string Nev
        {
            set
            {
                if (value != "")
                    nev = value;
                else
                    Console.WriteLine("A név nem lehet üres!");
            }
            get
            {
                return nev;
            }
        }

        private int ertek;

        public int Ertek
        {
            get { return ertek; }
            set
            {
                if (value > 0)
                    ertek = value;
                else
                    Console.WriteLine("Az érték csak pozitív lehet!");
            }
        }

        private double suly;

        public double Suly
        {
            get { return suly; }
            set
            {
                if (value > 0)
                    suly = value;
                else
                    Console.WriteLine("A súly csak pozitív lehet!");
            }
        }

        private bool etelE;

        public bool EtelE
        {
            get { return etelE; }
            set { etelE = value; }
        }

        public Taplalek(string nev, int ertek, double suly, bool etelE)
        {
            Nev = nev;
            Ertek = ertek;
            Suly = suly;
            EtelE = etelE;
        }
    }

    internal class Kereskedo
    {
        protected List<Taplalek> taplalekLista;

        private double maxTeherbiras;

        public double MaxTeherbiras
        {
            get { return maxTeherbiras; }
            set
            {
                if (value > 0)
                    maxTeherbiras = value;
                else
                    Console.WriteLine("A teherbírás csak pozitív lehet!");
            }
        }

        private double SzabadTeherbiras
        {
            get
            {
                double szumma = 0;
                foreach (Taplalek taplalek in taplalekLista)
                    szumma += taplalek.Suly;

                return MaxTeherbiras - szumma;
            }
        }

        public Kereskedo(double maxTeherbiras)
        {
            MaxTeherbiras = maxTeherbiras;
            taplalekLista = new List<Taplalek>();
        }

        public virtual bool Bepakol(Taplalek taplalek)
        {
            if (SzabadTeherbiras >= taplalek.Suly)
            {
                foreach (Taplalek taplalek2 in taplalekLista)
                    if (taplalek.Nev == taplalek2.Nev)
                    {
                        taplalek2.Suly += taplalek.Suly;
                        taplalek2.Ertek += taplalek.Ertek;
                        return true;
                    }

                taplalekLista.Add(taplalek);

                return true;
            }
            else
                return false;
        }

        public int Osszertek(string nev)
        {
            int szumma = 0;
            foreach (Taplalek taplalek in taplalekLista)
                if (taplalek.Nev == nev)
                    szumma += taplalek.Ertek;

            return szumma;
        }

        public virtual double Eladas(string nev, double mennyiseg)
        {
            foreach (Taplalek taplalek in taplalekLista)
                if (taplalek.Nev == nev)
                {
                    if (taplalek.Suly > mennyiseg)
                    {
                        taplalek.Suly -= mennyiseg;
                        return mennyiseg;
                    }
                    else
                    {
                        //            double eladott = taplalek.Suly;
                        taplalekLista.Remove(taplalek);
                        return taplalek.Suly;
                    }
                }

            return 0;
        }

        public List<Taplalek> Listaz(bool etelE)
        {
            List<Taplalek> cuccok = new List<Taplalek>();

            foreach (Taplalek taplalek in taplalekLista)
                if (taplalek.EtelE == etelE)
                    cuccok.Add(taplalek);

            return cuccok;
        }
    }

    internal class JoKereskedo : Kereskedo
    {
        private int penz;

        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }

        public JoKereskedo(double maxTeherbiras, int penz) :
          base(maxTeherbiras)
        {
            Penz = penz;
        }

        public override bool Bepakol(Taplalek taplalek)
        {
            if (taplalek.Ertek > penz)
                return false;

            if (base.Bepakol(taplalek))
            {
                penz -= taplalek.Ertek;
                return true;
            }
            else
                return false;
        }

        public override double Eladas(string nev, double mennyiseg)
        {
            double eladott = base.Eladas(nev, mennyiseg);

            foreach (Taplalek taplalek in taplalekLista)
                if (taplalek.Nev == nev)
                {
                    penz += (int)(eladott * taplalek.Ertek);
                    return eladott;
                }

            return 0;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();

            JoKereskedo keri = new JoKereskedo(rnd.Next(20, 50001), rnd.Next(10000, 10000001));

            keri.Bepakol(new Taplalek("Boci csoki", 185, 15, true));
            keri.Bepakol(new Taplalek("Omnia", 2000, 30, false));

            Console.WriteLine("\nA kereskedőnél {0} Ft van\n", keri.Penz);

            List<Taplalek> etelek = keri.Listaz(true);
            Console.WriteLine("\n");
            List<Taplalek> italok = keri.Listaz(false);

            Console.WriteLine("\nÉtelek\n");
            foreach (Taplalek etel in etelek)
                Console.WriteLine(etel.Nev);

            Console.WriteLine("\nItalok\n");
            foreach (Taplalek ital in italok)
                Console.WriteLine(ital.Nev);
            Console.ReadKey();
        }
    }
}