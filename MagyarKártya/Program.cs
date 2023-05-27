using System;

namespace MagyarKártya
{
    internal class Program
    {
        private enum kartyalapok
        {
            ÁSZ = 11,
            TIZ = 10,
            KILENC = 9,
            NYOLC = 8,
            HÉT = 7,
            KIRÁLY = 4,
            FELSŐ = 3,
            ALSÓ = 2,
        }

        private static void Main(string[] args)
        {
            int kartya;
            Console.WriteLine("Kérem a kártyalap pontszamat: ");
            kartya = int.Parse(Console.ReadLine());

            switch (kartya)
            {
                case 7:
                    Console.WriteLine(kartyalapok.HÉT);
                    break;

                case 8:
                    Console.WriteLine(kartyalapok.NYOLC);
                    break;

                case 9:
                    Console.WriteLine(kartyalapok.KILENC);
                    break;

                case 10:
                    Console.WriteLine(kartyalapok.TIZ);
                    break;

                case 2:
                    Console.WriteLine(kartyalapok.ALSÓ);
                    break;

                case 3:
                    Console.WriteLine(kartyalapok.FELSŐ);
                    break;

                case 4:
                    Console.WriteLine(kartyalapok.KIRÁLY);
                    break;

                case 11:
                    Console.WriteLine(kartyalapok.ÁSZ);
                    break;

                default:
                    Console.WriteLine("Hibás kártyapontérték!");
                    break;
            }

            Console.ReadKey();
        }
    }
}