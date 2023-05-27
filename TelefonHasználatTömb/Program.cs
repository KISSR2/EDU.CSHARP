using System;

namespace TelefonHasználatTömb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] heti = { 4, 2, 3, 6, 4, 3, 4 };
            int N = heti.Length;

            int i = 0;
            while (i < N && heti[i] <= 5)
            {
                i++;
            }
            if (i < N)
            {
                Console.WriteLine("Volt olyan nap amikor 5 óránál többet telefonoztál!");
                Console.WriteLine("A {0}. napon volt ", i);
            }
            else
            {
                Console.WriteLine("Nem volt olyan nap!");
            }

            Console.ReadKey();
        }
    }
}