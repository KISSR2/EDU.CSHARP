using System;
using System.Collections.Generic;

namespace EmberekOsztály
{
    internal class Ember
    {
        public string nev;
        public int kor;
        public string email;
    }

    internal class Program
    {
        private static void Kiir(Ember e)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Neve: {0}", e.nev);
            Console.WriteLine("Kora: {0}", e.kor);
            Console.WriteLine("E-mail: {0}", e.email);
            Console.WriteLine("\n");
        }

        private static void Main(string[] args)
        {
            List<Ember> emberek = new List<Ember>();
            string uj;

            do
            {
                Console.WriteLine("Rögzitel adatot (I/N)?");
                uj = Console.ReadLine();

                if (uj == "i" || uj == "igen" || uj == "I")
                {
                    Ember a = new Ember();
                    Console.WriteLine("Írja be a nevét!");
                    a.nev = Console.ReadLine();
                    Console.WriteLine("Írja be a korát!");
                    a.kor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Írja be az e-mail címét!");
                    a.email = Console.ReadLine();
                    emberek.Add(a);
                }
            } while (uj != "nem" && uj != "n" && uj != "N");

            foreach (Ember x in emberek)
            {
                Kiir(x);
            }

            Console.ReadKey();
        }
    }
}