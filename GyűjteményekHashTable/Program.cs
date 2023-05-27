using System;
using System.Collections;

namespace GyűjteményekHashTable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(4545, "Gyulaháza");
            hashtable.Add(4600, "Kisvárda");
            hashtable.Add(4400, "Nyíregyháza");
            hashtable.Add(1820, "Budapest");
            hashtable.Add(4546, "Anarcs");

            int beker;

            Console.Write("Kérem az adatot:");
            beker = int.Parse(Console.ReadLine());

            object value = hashtable[beker];
            if (value is string)
            {
                Console.WriteLine("A megkapott adat [{0}] >> [{1}]", beker, value);
            }
            else
            {
                Console.WriteLine("A megkapott adat [{0}] nem található!", beker);
            }

            Console.ReadKey();
        }
    }
}