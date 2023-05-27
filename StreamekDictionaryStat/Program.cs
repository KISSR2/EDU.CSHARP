using System;
using System.Collections.Generic;
using System.IO;

namespace StreamekDictionaryStat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string inFileName = "data.txt";
            StreamReader sr = new StreamReader(inFileName);
            string str = sr.ReadToEnd();
            string result = string.Empty;
            while (str.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                dict.Add(str[0], count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.WriteLine("A szövegfájlban található szövegben lévő karakterek statisztikája!");
            foreach (KeyValuePair<char, int> chara in dict)
            {
                Console.WriteLine("Karakter: {0}\t Darabszám: {1}",
                    chara.Key, chara.Value);
            }
            Console.ReadKey();
        }
    }
}