using System;

namespace ProgramozásiTételekTömb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int N = 10;
            int M = 10;
            int P = 20;

            int[] A = new int[N];
            int[] B = new int[M];
            int[] C = new int[P];

            Random r = new Random();

            int i, osszeg, darab, max, maxhely, db, j, k, sorszam, ker;
            bool van;

            int valasz = 1;

            while (valasz != 0)
            {
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - 'A' Tömb feltölése véletlen számokkal ");
                Console.WriteLine("2 - 'B' Tömb feltölése véletlen számokkal ");
                Console.WriteLine("3 - 'A' Tömb elemeinek kiirasa");
                Console.WriteLine("4 - 'B' Tömb elemeinek kiirasa");
                Console.WriteLine("5 - 'C' Tömb elemeinek kiirasa");
                Console.WriteLine("6 - 'A' Tömb elemeinek összege");
                Console.WriteLine("7 - 'B' Tömb Páros elemeinek megszámlálása");
                Console.WriteLine("8 - 'A' Tömbben van-e 80-tól nagyobb száűm (eldöntés)");
                Console.WriteLine("9 - 'A' Tömb legnagyobb eleme és indexe");
                Console.WriteLine("10 - 'B' Tömb legnagyobb eleme és indexe");
                Console.WriteLine("11 - 'A' Tömb Páros elemeinek kivállogatása a 'B' tömbbe");
                Console.WriteLine("12 - 'A' Tömb Páros és Páratlan elemeinek szétválogatása a 'B' és 'C' tömbbe");
                Console.WriteLine("13 - 'A' és 'B' tomb közös elemei a 'C' tömbbe (metszet)");
                Console.WriteLine("14 - 'A' és 'B' tömb Uniója a 'C' tömbbe");
                Console.WriteLine("15 - 'C' tömbben hányadik az első 20-tól nagyobb szám (kiválasztás)");
                Console.WriteLine("16 - Kérjünk be egy számot, majd nézzük meg hogy szerepel-e a 'C' tömbben (lineáris keresés)");
                Console.WriteLine("\nKérem válassz a funkciók közül:");

                valasz = Convert.ToInt32(Console.ReadLine());

                #region 1 - 'A' Tömb feltöltése véletlen számokkal

                if (valasz == 1)
                {
                    Console.Clear();
                    N = 10;
                    for (i = 0; i < N; i++)
                    {
                        A[i] = r.Next(1, 100);
                        Console.Write("{0} ", A[i]);
                    }
                }

                #endregion 1 - 'A' Tömb feltöltése véletlen számokkal

                #region 2 - 'B' Tömb feltöltése véletlen számokkal

                else if (valasz == 2)
                {
                    Console.Clear();
                    M = 10;
                    for (i = 0; i < N; i++)
                    {
                        B[i] = r.Next(1, 100);
                        Console.Write("{0} ", B[i]);
                    }
                }

                #endregion 2 - 'B' Tömb feltöltése véletlen számokkal

                #region 3 - 'A' Tömb elemeinek kiirasa

                else if (valasz == 3)
                {
                    Console.Clear();
                    for (i = 0; i < N; i++)
                    {
                        Console.WriteLine("{0} ", A[i]);
                    }
                }

                #endregion 3 - 'A' Tömb elemeinek kiirasa

                #region 4 - 'B' Tömb elemeinek kiirasa

                else if (valasz == 4)
                {
                    Console.Clear();
                    for (i = 0; i < M; i++)
                    {
                        Console.WriteLine("{0} ", B[i]);
                    }
                }

                #endregion 4 - 'B' Tömb elemeinek kiirasa

                #region 5 - 'C' Tömb elemeinek kiirasa

                else if (valasz == 5)
                {
                    Console.Clear();
                    for (i = 0; i < P; i++)
                    {
                        Console.WriteLine("{0} ", C[i]);
                    }
                }

                #endregion 5 - 'C' Tömb elemeinek kiirasa

                #region 6 - 'A' Tömb elemeinek összege

                else if (valasz == 6)
                {
                    Console.Clear();
                    osszeg = 0;
                    for (i = 0; i < N; i++)
                    {
                        osszeg = osszeg + A[i];
                    }
                    Console.WriteLine("Az 'A' tömb elemeinek összege: {0}", osszeg);
                }

                #endregion 6 - 'A' Tömb elemeinek összege

                #region 7 - 'B' Tömb Páros elemeinek megszámlálása

                else if (valasz == 7)
                {
                    Console.Clear();
                    darab = 0;
                    for (i = 0; i < M; i++)
                    {
                        if (B[i] % 2 == 0)
                        {
                            darab++;
                        }
                    }
                    Console.WriteLine("A 'B' tömb Páros elemeinek száma: " + darab);
                }

                #endregion 7 - 'B' Tömb Páros elemeinek megszámlálása

                #region 8 - 'A' Tömbben van-e 80-tól nagyobb száűm (eldöntés)

                else if (valasz == 8)
                {
                    Console.Clear();
                    i = 0;
                    while (i < N && A[i] <= 80)
                    {
                        i++;
                    }

                    if (i < N)
                    {
                        Console.WriteLine("Van ilyen !");
                        Console.WriteLine("Helye: {0}. elem!", i);
                    }
                    else
                    {
                        Console.WriteLine("Nem található!");
                    }
                }

                #endregion 8 - 'A' Tömbben van-e 80-tól nagyobb száűm (eldöntés)

                #region 9 - 'A' Tömb legnagyobb eleme és indexe

                else if (valasz == 9)
                {
                    Console.Clear();
                    max = A[0];
                    maxhely = 0;
                    for (i = 0; i < N; i++)
                    {
                        if (max < A[i])
                        {
                            max = A[i];
                            maxhely = i;
                        }
                    }
                    Console.WriteLine("'A' Tömb legnagyobb eleme: {0}", max);
                    Console.WriteLine("Indexe: {0}", maxhely);
                }

                #endregion 9 - 'A' Tömb legnagyobb eleme és indexe

                #region 10 - 'B' Tömb legnagyobb eleme és indexe

                else if (valasz == 10)
                {
                    Console.Clear();
                    max = B[0];

                    for (i = 0; i < M; i++)
                    {
                        if (B[max] < B[i])
                        {
                            max = i;
                        }
                    }
                    Console.WriteLine("'B' Tömb legnagyobb eleme: {0}", B[max]);
                    Console.WriteLine("Indexe: {0}", max);
                }

                #endregion 10 - 'B' Tömb legnagyobb eleme és indexe

                #region 11 - 'A' Tömb Páros elemeinek kivállogatása a 'B' tömbbe

                else if (valasz == 11)
                {
                    Console.Clear();
                    db = 0;
                    for (i = 0; i < N; i++)
                    {
                        if (A[i] % 2 == 0)
                        {
                            B[db] = A[i];
                            db++;
                        }
                    }
                    M = db;
                    Console.WriteLine("A kiválogatás kész!");
                }

                #endregion 11 - 'A' Tömb Páros elemeinek kivállogatása a 'B' tömbbe

                #region 12 - 'A' Tömb Páros és Páratlan elemeinek szétválogatása a 'B' és 'C' tömbbe

                else if (valasz == 12)
                {
                    Console.Clear();
                    j = 0; k = 0;

                    for (i = 0; i < N; i++)
                    {
                        if (A[i] % 2 == 0)
                        {
                            B[j] = A[i];
                            j++;
                        }
                        else
                        {
                            C[k] = A[i];
                            k++;
                        }
                    }
                    M = j;
                    P = k;
                    Console.WriteLine("A szétválogatás kész!");
                }

                #endregion 12 - 'A' Tömb Páros és Páratlan elemeinek szétválogatása a 'B' és 'C' tömbbe

                #region 13 - 'A' és 'B' tomb közös elemei a 'C' tömbbe (metszet)

                else if (valasz == 13)
                {
                    Console.Clear();
                    db = 0;
                    for (i = 0; i < N; i++)
                    {
                        j = 0;
                        while ((j < M) && (A[i] != B[j]))
                        {
                            j++;
                        }
                        if (j < M)
                        {
                            C[db] = A[i];
                            db++;
                        }
                    }
                    P = db;
                    Console.WriteLine("A metszetképzés kész!");
                }

                #endregion 13 - 'A' és 'B' tomb közös elemei a 'C' tömbbe (metszet)

                #region 14 - 'A' és 'B' tömb Uniója a 'C' tömbbe

                else if (valasz == 14)
                {
                    Console.Clear();
                    for (i = 0; i < N; i++)
                    {
                        C[i] = A[i];
                    }
                    db = N;
                    for (j = 0; j < M; j++)
                    {
                        i = 0;
                        while (i < N && A[i] != B[j])
                        {
                            i++;
                        }
                        if (i == N)
                        {
                            C[db] = B[j];
                            db++;
                        }
                    }
                    P = db;
                    Console.WriteLine("Az unióképzés kész!");
                }

                #endregion 14 - 'A' és 'B' tömb Uniója a 'C' tömbbe

                #region 15 - 'C' tömbben hányadik az első 20-tól nagyobb szám (kiválasztás)

                else if (valasz == 15)
                {
                    Console.Clear();
                    i = 0;
                    while (i < P && C[i] <= 20)
                    {
                        i++;
                    }
                    sorszam = i;
                    Console.WriteLine("Az első 20-tól nagybb szám az {0}. helyen áll", sorszam);
                    Console.WriteLine("Értéke: {0}", C[i]);
                }

                #endregion 15 - 'C' tömbben hányadik az első 20-tól nagyobb szám (kiválasztás)

                #region 16 - Kérjünk be egy számot, majd nézzük meg hogy szerepel-e a 'C' tömbben (lineáris keresés)

                else if (valasz == 16)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem a keresett számot!");
                    ker = Convert.ToInt32(Console.ReadLine());

                    i = 0;
                    van = false;
                    while (i < P && ker != C[i])
                    {
                        i++;
                    }
                    if (i < P)
                    {
                        van = true;
                    }
                    if (van)
                    {
                        Console.WriteLine("Megvan a szám, indexe: " + i);
                    }
                    else
                    {
                        Console.WriteLine("Nincs meg a keresett szám!");
                    }
                }

                #endregion 16 - Kérjünk be egy számot, majd nézzük meg hogy szerepel-e a 'C' tömbben (lineáris keresés)

                #region Kilépés

                else if (valasz == 0)
                {
                    Console.Clear();
                    Console.WriteLine("A program kilép");
                }

                #endregion Kilépés

                else
                {
                    Console.WriteLine("Nincs ilyen menüpont");
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}