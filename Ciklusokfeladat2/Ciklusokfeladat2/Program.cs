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
        }
    }
}
