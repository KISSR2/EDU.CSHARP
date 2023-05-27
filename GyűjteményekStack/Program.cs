using System;
using System.Collections;

namespace GyűjteményekStack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 0, beker = 0;
            Console.WriteLine("Kérem a számokat!");
            Stack st = new Stack();
            do
            {
                Console.Write("{0}. érték: ", i);
                beker = int.Parse(Console.ReadLine());
                st.Push(beker);
                i++;
            } while (beker != 0);

            Console.WriteLine("\nA számok bekéréssel fordított sorrendben: \n");
            foreach (Object obj in st)
            {
                Console.Write(obj + " | ");
            }

            Console.ReadKey();
        }
    }
}