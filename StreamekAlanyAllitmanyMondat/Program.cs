using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamekAlanyAllitmanyMondat
{
    class Program
    {
        public static void szotar(string szó, string file)
        {
            if (file.Equals("alany"))
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
                }
                catch (IOException io)
                {
                    Console.WriteLine("Hiba a fájl bővítésekor!\nHiba:" + io.Message);
                }
                
            }
            if (file.Equals("állítmány"))
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
                }
                catch (IOException io)
                {
                    Console.WriteLine("Hiba a fájl bővítésekor!\nHiba:" + io.Message);
                }

            }
            if (file.Equals("tárgy"))
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
                }
                catch (IOException io)
                {
                    Console.WriteLine("Hiba a fájl bővítésekor!\nHiba:" + io.Message);
                }

            }
        }
        static void Main(string[] args)
        {
            string alany, állítmány, tárgy;

            string[] MAlany;
            string[] MÁllitmány;
            string[] MTárgy;

            FileStream fr;
            StreamReader sr;

            Random rnd = new Random();

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
            


            szotar("András", "alany");
            szotar("Zeus", "alany");
            szotar("Endre", "alany");
            szotar("zenél", "állítmány");
            szotar("szerel", "állítmány");
            szotar("biciklit", "tárgy");
            szotar("autót", "tárgy");
            Console.ReadKey();
        }
    }
}
