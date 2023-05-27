﻿using System;

namespace EseményparaméterOsztály
{
    internal enum IrányTípus
    { felfelé, lefelé };

    internal class KüszöbIrányArgs : EventArgs
    {
        public IrányTípus Irány { get; set; }

        public KüszöbIrányArgs(IrányTípus irány)
        {
            Irány = irány;
        }
    }

    internal class Számláló
    {
        private int aktuális = 0;
        private int küszöb;

        public int Aktuális
        {
            get { return aktuális; }
        }

        public Számláló(int küszöb)
        {
            this.küszöb = küszöb;
        }

        public delegate void Eseménykezelő(string üzenet);

        public event Eseménykezelő Változás;

        //Az EventHandler gyári delegált, void típusú, két paramétert kér: a küldő objektumot és a küldés körülményeit jelző EventArgs objektumot
        public event EventHandler KüszöbEsemény;

        public void Növel(int növekmény)
        {
            aktuális += növekmény;
            this.VáltozásTörténik();
            if (aktuális >= küszöb)
            {
                KüszöbIrányArgs args = new KüszöbIrányArgs(IrányTípus.felfelé);
                KüszöbElérése(args);
            }
        }

        public void Csökkent(int növekmény)
        {
            aktuális -= növekmény;
            this.VáltozásTörténik();
            if (aktuális <= küszöb)
            {
                KüszöbIrányArgs args = new KüszöbIrányArgs(IrányTípus.lefelé);
                KüszöbElérése(args);
            }
        }

        private void VáltozásTörténik()
        {
            if (Változás != null) Változás("A számláló értéke megváltozott!");
        }

        private void KüszöbElérése(EventArgs args)
        {
            EventHandler esemény = KüszöbEsemény;
            if (esemény != null) esemény(this, args);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Számláló sz = new Számláló(10);
            sz.Változás += SajátVáltozás;
            sz.KüszöbEsemény += Sz_KüszöbEsemény;
            sz.Növel(2);
            Console.WriteLine(sz.Aktuális);
            sz.Növel(8);
            sz.Csökkent(11);
            Console.ReadKey();
        }

        static public void SajátVáltozás(string üzenet)
        {
            Console.WriteLine(üzenet);
        }

        private static void Sz_KüszöbEsemény(object sender, EventArgs e)
        {
            Console.Write("Figyelem! A küszöböt elértük, az iránya: ");

            if (((KüszöbIrányArgs)e).Irány == IrányTípus.felfelé)
                Console.WriteLine("felfelé");
            else
                Console.WriteLine("lefelé");
        }
    }
}