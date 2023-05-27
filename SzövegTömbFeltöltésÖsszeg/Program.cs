using System;
using System.IO;
using System.Text;

namespace SzövegTömbFeltöltésÖsszeg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamReader olvas;
            try
            {
                olvas = new StreamReader("data.txt", Encoding.Default);
                int db = Convert.ToInt32(olvas.ReadLine());
                Console.WriteLine("A tömb elemszáma: {0}\n", db);
                int i;
                int[] tomb = new int[db];
                for (i = 0; i < db; i++)
                {
                    tomb[i] = Convert.ToInt32(olvas.ReadLine());
                }
                olvas.Close();

                int osszeg = 0;
                for (i = 0; i < db; i++)
                {
                    osszeg = osszeg + tomb[i];
                }
                for (i = 0; i < db; i++)
                {
                    Console.WriteLine("A tömb {0}. eleme: {1} ", i, tomb[i]);
                }
                Console.WriteLine("\nA tömb elemeinek összege: {0}", osszeg);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("404 - Az \"data.txt\" nevű fájl nem létezik! ");
                throw;
            }
        }
    }
}