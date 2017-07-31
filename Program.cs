using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public int izracundana(int dan, int mjesec, int godina)
        {
            try
            {
                DateTime dt = new DateTime(godina, mjesec, dan);
                return dt.DayOfYear;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("unjeli ste krivi datum");
                return 0;
            }
        }
        static void Main(string[] args)
        { int d, m, g;
            Console.WriteLine("unesite datum d,m,g sa tockom");
            var datum = Console.ReadLine();
            d = int.Parse(datum.Split('.')[0]);
            m = int.Parse(datum.Split('.')[1]);
            g = int.Parse(datum.Split('.')[2]);
            Program n = new Program();
            int a=n.izracundana(d, m, g);
            if (a > 0)
            {
                Console.WriteLine("{0} dan u godini", a);
            }

            
        }

    }
}
