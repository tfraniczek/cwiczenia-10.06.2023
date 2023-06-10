using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6_sprawdza_czyX_jest_silniaN
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int x, n, nSilnia, i;
            {
                Console.WriteLine("Program sprawdzi czy podana liczba X jest silnia podanej liczby n.");
                Console.WriteLine("Podaj liczbe X");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj liczbe N");
                n = int.Parse(Console.ReadLine());

                nSilnia = 1;
                for (i = 1; i <= n; i++)
                {
                    nSilnia = nSilnia * i;
                }

                if (nSilnia == x)
                {
                    Console.WriteLine("Podany X jest silnia liczby N");
                }
                else
                {
                    Console.WriteLine("Podany X nie jest silnia liczby N");
                }
                Console.ReadLine();
            }
        }
    }
}
