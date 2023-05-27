using System;
using System.Collections.Generic;
using System.IO;

namespace Videótéka
{
    internal enum Mufajok
    { akcio, drama, thriller, scifi, romantikus, vigjatek };

    internal class Film
    {
        protected string cim;

        public string Cim
        {
            get { return cim; }
        }

        protected int hossz;

        public int Hossz
        {
            get { return hossz; }
        }

        protected Mufajok mufaj;

        public Mufajok Mufaj
        {
            get { return mufaj; }
        }

        protected List<Ember> szereplok;

        public List<Ember> Szereplok
        {
            get { return szereplok; }
        }

        private Ember rendezo;

        public Ember Rendezo
        {
            get { return rendezo; }
        }

        private int bemutatasEve;

        public int BemutatasEve
        {
            get { return bemutatasEve; }
        }

        public Film(string cim, int hossz, Mufajok mufaj,
          string rendezoNeve, int bemutatasEve)
        {
            if (cim != "")
                this.cim = cim;
            else
                throw new Exception("Filmcím nem lehet üres!");

            if (hossz > 0)
                this.hossz = hossz;
            else
                throw new Exception("Film hossza csak pozitív lehet!");

            this.mufaj = mufaj;

            this.szereplok = new List<Ember>();

            this.rendezo = new Ember(rendezoNeve, Szerepek.rendezo);

            if (bemutatasEve >= 1900 && bemutatasEve <= DateTime.Now.Year)
                this.bemutatasEve = bemutatasEve;
            else
                throw new Exception("Bemutatás éve csak 1900 és az mostani év között lehet!");
        }

        public void SzereplotHozzaad(string szereploNeve, Szerepek szerep)
        {
            szereplok.Add(new Ember(szereploNeve, szerep));
        }

        public void Kiir()
        {
            Console.WriteLine("Címe: {0}", cim);
            Console.WriteLine("Hossza: {0}", hossz);
            Console.WriteLine("Műfaja: {0}", mufaj);
            Console.WriteLine("Rendezője: {0}", rendezo.Nev);

            foreach (Ember ember in szereplok)
                Console.WriteLine("{0}: {1}", ember.Szerep, ember.Nev);

            Console.WriteLine("Bemutatás éve: {0}", bemutatasEve);
        }
    }

    internal enum Szerepek
    {
        rendezo, foszereplo, mellekszereplo,
        producer, statiszta
    };

    internal class Ember
    {
        private string nev;

        public string Nev
        {
            get { return nev; }
        }

        private Szerepek szerep;

        public Szerepek Szerep
        {
            get { return szerep; }
        }

        public Ember(string nev, Szerepek szerep)
        {
            if (nev != "")
                this.nev = nev;
            else
                throw new Exception("Ember neve nem lehet üres!");

            this.szerep = szerep;
        }
    }

    internal class Program
    {
        private static List<Film> filmek;

        private static char Fomenu()
        {
            Console.WriteLine("F: Film hozzáadása");
            Console.WriteLine("L: Filmek listázása");
            Console.WriteLine("T: Film törlése");
            Console.WriteLine("K: Film keresése");
            Console.WriteLine("X: Kilépés");

            return Console.ReadKey(true).KeyChar;
        }

        private static void FilmetHozzaad()
        {
            Console.WriteLine("Add meg a film címét!");
            string cim = Console.ReadLine();
            Console.WriteLine("Add meg a film hosszát percekben!");
            int hossz = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a film műfaját (akcio, drama, thriller, scifi, romantikus)!");
            Mufajok mufaj = (Mufajok)Enum.Parse(typeof(Mufajok),
              Console.ReadLine());
            Console.WriteLine("Add meg a rendező nevét!");
            string rendezoNeve = Console.ReadLine();
            Console.WriteLine("Add meg a bemutatás évét (1900 és a mostani év között)!");
            int bemutatasEve = int.Parse(Console.ReadLine());

            try
            {
                filmek.Add(new Film(cim, hossz, mufaj, rendezoNeve, bemutatasEve));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void FilmeketBetolt()
        {
            StreamReader reader;

            try
            {
                reader = new StreamReader("filmek.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Nem találom a fájlt!");
                return;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Azonosíthatatlan input-output hiba!");
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Azonosíthatatlan hiba!");
                Console.WriteLine(ex.Message);
                return;
            }

            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();

                string[] szavak = sor.Split('|');

                string cim = szavak[0];
                int hossz = int.Parse(szavak[1]);
                Mufajok mufaj =
                  (Mufajok)Enum.Parse(typeof(Mufajok), szavak[2]);
                string rendezo = szavak[3];
                int ev = int.Parse(szavak[4]);

                filmek.Add(new Film(cim, hossz, mufaj, rendezo, ev));
            }

            reader.Close();
        }

        private static void Main(string[] args)
        {
            filmek = new List<Film>();

            FilmeketBetolt();

            char c;

            do
            {
                //Console.Clear();
                c = char.ToUpper(Fomenu());

                switch (c)
                {
                    case 'F':
                        FilmetHozzaad();
                        break;

                    case 'L':
                        FilmekListaza();
                        break;
                }

                //        Console.ReadKey(true);
            } while (c != 'X');
        }

        private static void FilmekListaza()
        {
            foreach (Film film in filmek)
            {
                film.Kiir();
                Console.WriteLine("==============================");
            }
        }
    }
}