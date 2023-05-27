using System;

namespace MátrixIdőre
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Futtatás megkezdése (Számlálás kezdete)

            var ido = DateTime.Now;
            Console.WriteLine("Kezdés ideje: {0:T}\n", ido);

            #endregion Futtatás megkezdése (Számlálás kezdete)

            #region Mátrix létrehozása és kiiratása 100x100

            int[,] matrix = new int[100, 100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
            }

            #endregion Mátrix létrehozása és kiiratása 100x100

            #region Futtatás befejezése (Számlálás befejezése) különbségidő meghatározása)

            var ido2 = DateTime.Now;
            Console.WriteLine("\n\nKezdete:{0:T} ", ido);
            Console.WriteLine("Vége: {0:T} ", ido2);
            Console.WriteLine("Különbség: {0:T}", ido2 - ido);

            #endregion Futtatás befejezése (Számlálás befejezése) különbségidő meghatározása)

            Console.ReadKey(false);
            Console.ReadKey();
        }
    }
}