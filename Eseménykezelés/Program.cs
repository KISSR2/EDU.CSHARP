using System;

namespace Eseménykezelés
{
    internal class Számláló
    {
        private int aktuális = 0;

        public int Aktuális
        {
            get { return aktuális; }
        }

        public delegate void Eseménykezelő(string üzenet);

        public event Eseménykezelő Változás;

        public void Növel(int növekmény)
        {
            aktuális += növekmény;
            this.VáltozásTörténik();
        }

        private void VáltozásTörténik()
        {
            if (Változás != null) Változás("A számláló értéke megváltozott!");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Számláló sz = new Számláló();
            sz.Változás += SajátVáltozás;
            sz.Növel(2);
            Console.WriteLine(sz.Aktuális);
            Console.ReadKey();
        }

        static public void SajátVáltozás(string üzenet)
        {
            Console.WriteLine(üzenet);
        }
    }
}