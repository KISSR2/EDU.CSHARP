using System;

namespace SajátKivételOsztály
{
    public class SajatException : Exception
    {
        private int errorcode;

        public SajatException()
        {
            Console.WriteLine("A nullával való osztás nincs értelmezve!");
            errorcode = 1;
        }

        public int ErrorCode
        {
            get { return errorcode; }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            float szamlalo = 0, nevezo = 0;
            Console.Write("Kérem a tört számlálóját: ");
            szamlalo = float.Parse(Console.ReadLine());
            Console.Write("Kérem a tört nevezőjét: ");
            nevezo = float.Parse(Console.ReadLine());
            if (nevezo != 0)
            {
                Console.WriteLine("{0}/{1} tört értéke: {2} ", szamlalo, nevezo, (szamlalo / nevezo));
            }
            else
            {
                throw new SajatException();
            }

            Console.ReadKey();
        }
    }
}