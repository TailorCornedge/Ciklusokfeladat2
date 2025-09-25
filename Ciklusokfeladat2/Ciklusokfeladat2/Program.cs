using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusokfeladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja megy az 1. számot: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a 2. számot: ");
            int y = int.Parse(Console.ReadLine());
            if (x>y)
            {
                Console.WriteLine($"{x} a nagyobb szám. A két szám közt lévő mennyiség: {x - y - 1}");
            }
            else
            {
                Console.WriteLine($"{y} a nagyobb szám. A két szám közt lévő mennyiség: {y - x - 1}");
            }
            int szam = 1;
            List<int> list = new List<int>();
            while (szam != 0)
            {
                Console.WriteLine("Adjon meg egy számot. Ha ki szeretne lépni adja meg 0-t értéknek: ");
                szam = int.Parse(Console.ReadLine());
                list.Add(szam);
            }
            var most = (from i in list
                        group i by i into grp
                        orderby grp.Count() descending
                        select grp.Key).First();

            Console.WriteLine($"A legtöbbször megadott szám: {most}");
        }
    }
}
