using System;

namespace Szövegkezelés
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str1, str2, str3, str5;
            int totalWidth1 = 30;                   //Megadja hogy mennyi a táv oldalról!
            int totalWidth2 = 20;
            string str4;                            // szövegbeolvasás

            Console.WriteLine("Kérem a nevedet:");
            str4 = Console.ReadLine();              //str4-be való szövegbekérés

            str2 = str4.PadLeft(totalWidth1);       //bal oldali margó
            str3 = str4.PadRight(totalWidth2);      //jobb oldali margó
            str1 = str4.ToUpper();                  //teljes nagybetűs
            str5 = str4.ToLower();                  //teljes kisbetűs

            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n", str2, str3, str1, str5); // string kiiratás
            Console.ReadKey();
        }
    }
}