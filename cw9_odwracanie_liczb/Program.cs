using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw9_odwracanie_liczb
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string liczba;
            Console.WriteLine("Wpisz liczbę, którą chcesz odwrócić:");
            liczba = Console.ReadLine();
            char[] stringArray = liczba.ToCharArray();
            Array.Reverse(stringArray);
            string odwrocona_tablica = new string(stringArray);
            Console.WriteLine("Liczba po odwróceniu to: " + odwrocona_tablica);
            Console.ReadLine();


        }
    }
}
