using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

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
            if (x > y)
            {
                Console.WriteLine($"{x} a nagyobb szám. A két szám közt lévő mennyiség: {x - y - 1}");
            }
            else
            {
                Console.WriteLine($"{y} a nagyobb szám. A két szám közt lévő mennyiség: {y - x - 1}");
            }
            int szam = 1;
            int counter = 1;
            List<int> list = new List<int>();
            while (szam != 0)
            {
                Console.WriteLine($"Adja meg a(z) {counter}. számot. Ha ki szeretne lépni adja meg 0-t értéknek: ");
                szam = int.Parse(Console.ReadLine());
                list.Add(szam);
                counter++;
            }
            var most = (from i in list
                        group i by i into grp
                        orderby grp.Count() descending
                        select grp.Key).First();

            Console.WriteLine($"A legtöbbször megadott szám: {most}");

            counter = 1;
            list.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Adja meg a(z) {counter}. számot: ");
                szam =int.Parse(Console.ReadLine());
                list.Add(szam);
                counter += 1;
            }
            int paros = 0;
            int paratlan = 0;
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    paros += 1;
                }
                else
                {
                    paratlan += 1;
                }
            }
            Console.WriteLine($"A megadott számok közül van {paros} páros, {paratlan} páratlan szám.");
            List<string> szavak = new List<string>();
            string szo = "";
            int nagyobb = 0;
            while (szo != "vége")
            {
                Console.WriteLine("Adjon meg szavakat. Adja meg azt hogy 'vége' hogy leálljon: ");
                szo = Console.ReadLine();
                szavak.Add(szo);
            }
            foreach (string i in szavak)
            {
                if (i.Length > 5)
                {
                    nagyobb += 1;
                }
            }
            Console.WriteLine($"{nagyobb} db 5 karakternél hosszab szót adott meg.");

            list.Clear();
            counter = 1;
            int osztalyzat = 0;
            while (osztalyzat != -1)
            {
                Console.WriteLine($"Adja meg a(z) {counter}. osztályzatot (1-5). Adja meg az -1-es osztályzatot hogy ne kérjen több számot: ");
                osztalyzat=int.Parse(Console.ReadLine());
                if (osztalyzat != -1)
                {
                    list.Add(osztalyzat);
                    counter += 1;
                }
                if (osztalyzat == -1)
                {
                    counter -= 1;
                }
            }
            int egy = 0;
            int kett = 0;
            int har = 0;
            int negy = 0;
            int ot = 0;
            foreach (int i in list)
            {
                if (i == 1)
                {
                    egy += 1;
                }
                else if (i == 2)
                {
                    kett += 1;
                }
                else if (i == 3) { 
                har += 1;
                }
                else if (i == 4)
                {
                    negy += 1;
                }
                else
                {
                    ot += 1;
                }
            }
            double sum = egy * 1 + kett * 2 + har * 3 + negy * 4 + ot * 5;
            double atlag = sum / counter;
            Console.WriteLine($"egyes: {egy}; kettes: {kett}; hármas: {har}; négyes: {negy}; ötös: {ot}");
            Console.WriteLine($"Átlag: {atlag}");

            Console.WriteLine("Adjon meg egy számot: ");
            szam=int.Parse( Console.ReadLine() );
            for (int i = 1; i < 11; i++)
            {
                if ((szam*i) % 3 == 0)
                {
                    Console.WriteLine($"Szorozva {i} = {szam * i}");
                }
            }
            counter = 1;
            while ( counter < 11)
            {
                string poz = "";
                string par = "";
                string oszt = "";
                Console.WriteLine($"Adja meg a(z) {counter}. számot: ");
                szam=int.Parse(Console.ReadLine());
                if (szam > 0)
                {
                    poz = "pozitív";
                }
                else
                {
                    poz = "negatív";
                }
                if (szam % 2 == 0)
                {
                    par = "páros";
                }
                else
                {
                    par = "páratlan";
                }
                if (szam % 3 == 0) {
                    oszt = "igen";
                }
                else
                {
                    oszt = "nem";
                }
                Console.WriteLine($"Ez a szám: {poz}; {par}; oztható hárommal: {oszt}");
                counter++;
            }

            counter = 1;
            string jelsz = "";
            while (counter !=3) {
                Console.WriteLine($"Adja meg a jelszót ({counter}) ('titok')");
                jelsz = Console.ReadLine();
                if (jelsz == "titok")
                {
                    counter++;
                }
                else
                {
                    counter=1;
                }
                        }
            List<char> bigyók = new List<char>();
            Console.WriteLine("A jelszó megegyezik. adjon meg egy szöveget: ");
            string körte =Console.ReadLine();
            foreach (char s in körte)
            {
                bigyók.Add(s);
            }
            bigyók.Reverse();
            körte = "";
            foreach (char s in bigyók) { 
            körte+= s;
            }
            Console.WriteLine(körte);
        }
    }
}
