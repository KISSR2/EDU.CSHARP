using System;

namespace UnióTétel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Unió tétel");
            int[] a = { 3, 5, 8, 4 };
            int[] b = { 2, 1, 7, 9 };
            int[] c = new int[18];

            int i, j, k = 0;
            int n = a.Length, m = b.Length;

            //Unió tétel
            j = 0;
            for (i = 0; i < n; i++)
            {
                c[i] = a[i];
            }
            k = n;
            for (j = 0; i < m; i++)
            {
                i = 0;
                while (i < n && b[j] != a[i])
                {
                    i++;
                }
                if (i == n)
                {
                    c[k] = b[j];
                    k++;
                }
            }
            // tomb kiiratása
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            // tomb kiiratása II.
            for (i = 0; i < m; i++)
            {
                Console.Write("{0} ", b[i]);
            }

            Console.ReadKey();
        }
    }
}