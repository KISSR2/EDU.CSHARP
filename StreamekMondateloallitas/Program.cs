using System;
using System.IO;

//KISS RÓBERT NEPTUN: J74B48
namespace StreamekMondateloallitas
{
    internal class Program
    {
        public static void alanybovites(string szó)
        {
            try
            {
                FileStream fr = File.Open(@"alany.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fr);
                string alany = sr.ReadLine();
                sr.Close();
                fr.Close();

                if (!alany.Contains(szó))
                {
                    alany = alany + " " + szó;
                    File.WriteAllText(@"alany.txt", alany);
                }
                Console.WriteLine("Sikeres mentés!");
            }
            catch (IOException io)
            {
                Console.WriteLine("Hiba a fájl bővítésekor!\nHiba:" + io.Message);
            }
        }

        public static void allitmanybovites(string szó)
        {
            try
            {
                FileStream fr = File.Open(@"allitmany.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fr);
                string állítmány = sr.ReadLine();
                sr.Close();
                fr.Close();

                if (!állítmány.Contains(szó))
                {
                    állítmány = állítmány + " " + szó;
                    File.WriteAllText(@"allitmany.txt", állítmány);
                }
                Console.WriteLine("Sikeres mentés!");
            }
            catch (IOException io)
            {
                Console.WriteLine("Hiba a fájl bővítésekor!\nHiba:" + io.Message);
            }
        }

        public static void targybovites(string szó)
        {
            try
            {
                FileStream fr = File.Open(@"targy.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fr);
                string tárgy = sr.ReadLine();
                sr.Close();
                fr.Close();

                if (!tárgy.Contains(szó))
                {
                    tárgy = tárgy + " " + szó;
                    File.WriteAllText(@"targy.txt", tárgy);
                }

                Console.WriteLine("Sikeres mentés!");
            }
            catch (IOException io)
            {
                Console.WriteLine("Hiba a fájl bővítésekor!\nHiba:" + io.Message);
            }
        }

        private static void Main(string[] args)
        {
            int valasztas = 0, bovit = 0;

            string alany, állítmány, tárgy, bovitem;

            string[] MAlany;
            string[] MÁllitmány;
            string[] MTárgy;

            FileStream fr;
            StreamReader sr;
            Random rnd = new Random();

            Console.WriteLine("0 - Kilépés a programból");
            Console.WriteLine("1 - Mondatalkotás");
            Console.WriteLine("2 - Szókincsbővítés");

            do
            {
                Console.Write("\nKérem a használni kíván funkció sorszámát: ");
                valasztas = int.Parse(Console.ReadLine());
                if (valasztas < 0 || valasztas > 2)
                {
                    Console.WriteLine("\nA megadott menüpont érvénytelen!");
                }
                else
                {
                    if (valasztas == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A program kilép....");
                        break;
                    }
                    else if (valasztas == 1)
                    {
                        fr = File.Open(@"alany.txt", FileMode.Open);
                        sr = new StreamReader(fr);
                        alany = sr.ReadLine();
                        MAlany = alany.Split(' ');

                        sr.Close();
                        fr.Close();

                        fr = File.Open(@"allitmany.txt", FileMode.Open);
                        sr = new StreamReader(fr);
                        állítmány = sr.ReadLine();
                        MÁllitmány = állítmány.Split(' ');

                        sr.Close();
                        fr.Close();

                        fr = File.Open(@"targy.txt", FileMode.Open);
                        sr = new StreamReader(fr);
                        tárgy = sr.ReadLine();
                        MTárgy = tárgy.Split(' ');

                        sr.Close();
                        fr.Close();

                        //Console.WriteLine(alany + állítmány + tárgy);

                        int akn = rnd.Next(MAlany.Length);
                        int áln = rnd.Next(MÁllitmány.Length);
                        int tán = rnd.Next(MTárgy.Length);

                        Console.WriteLine(MAlany[akn] + " " + MÁllitmány[áln] + " " + MTárgy[tán] + ".");
                    }
                    else if (valasztas == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Mely szavak gyűjteményét szeretnéd bőiteni?");
                        Console.WriteLine("0 -- Vissza a főmenübe");
                        Console.WriteLine("1 -- Alany szavak");
                        Console.WriteLine("2 -- Állítmány szavak");
                        Console.WriteLine("3 -- Tárgy szavak");
                        do
                        {
                            Console.Write("\nKérem a funkció sorszámát! ");
                            bovit = int.Parse(Console.ReadLine());
                            if (bovit < 0 || bovit > 3)
                            {
                                Console.WriteLine("\nA megadott menüpont érvénytelen!");
                            }
                            else
                            {
                                if (bovit == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("0 - Kilépés a programból");
                                    Console.WriteLine("1 - Mondatalkotás");
                                    Console.WriteLine("2 - Szókincsbővítés");
                                    break;
                                }
                                else
                                {
                                    Console.Write("Kérem a szót:");
                                    bovitem = Console.ReadLine();
                                    if (bovit == 1)
                                        alanybovites(bovitem);
                                    else if (bovit == 2)
                                        allitmanybovites(bovitem);
                                    else if (bovit == 3)
                                        targybovites(bovitem);
                                }
                            }
                        } while (bovit >= 0 || bovit <= 3);
                    }
                }
            } while (valasztas >= 0 || valasztas <= 2);
            Console.ReadKey();
        }
    }
}