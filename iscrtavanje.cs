using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class iscrtavanje
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite koliko želilte iscrtavanja");
            int k = int.Parse(Console.ReadLine());
            int i;
            if (k % 2 == 0)
            {
                i = 0; }
            else { 
                i = 1;
            }
            int d = i;
            for (; i <= k; i+=2)
            {
                for (int s = 1; s <=i; s++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
            for (k -= 2; k >= d; k -= 2)
            {
                for (int s = 1; s <= k; s++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}