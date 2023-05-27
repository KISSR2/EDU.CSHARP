using System;

namespace HónapRómai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int év = DateTime.Now.Year;
            string hó = DateTime.Now.Month.ToString();
            int nap = DateTime.Now.Day;

            if (hó == "1") { hó = "I"; }
            if (hó == "2") { hó = "II"; }
            if (hó == "3") { hó = "III"; }
            if (hó == "4") { hó = "IV"; }
            if (hó == "5") { hó = "V"; }
            if (hó == "6") { hó = "VI"; }
            if (hó == "7") { hó = "VII"; }
            if (hó == "8") { hó = "VIII"; }
            if (hó == "9") { hó = "IX"; }
            if (hó == "10") { hó = "X"; }
            if (hó == "11") { hó = "XI"; }
            if (hó == "12") { hó = "XII"; }
            Console.WriteLine("{0}.{1}.{2}", év, hó, nap);
            Console.ReadKey();
        }
    }
}