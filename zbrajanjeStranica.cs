using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class zbrajanjeStranica
    {
        public int zbrajanje(int zbr)
        {
            int k=0;
            if (zbr < 1)
            {
                return 0;
            }
            for(int s = 1; s <= zbr; s++)
            {
                if(s>0 && s < 10)
                {
                    ++k;
                }
                if(s>9&& s < 100)
                {
                    k += 2;
                }
                else if(s>99 && s < 1000)
                {
                    k += 3;
                }
                else if(s>999 && s < 10000)
                {
                    k += 4;
                }
                
            }
            return k;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("unesite broj stranica");
            int k=int.Parse(Console.ReadLine());
            zbrajanjeStranica n = new zbrajanjeStranica();
            int s=n.zbrajanje(k);
            Console.WriteLine("zbroj stranica je {0}", s);
        }
    }
}
