using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cw10_wypisywanie_cyfr_z_liczby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LiczbaSlownie;
            double cyfra;
            Console.WriteLine("Wpisz liczbę przynajmniej 3-cyfrową: ");
            LiczbaSlownie = (Console.ReadLine());
            int LiczbaSlownieDlugosc = LiczbaSlownie.Length;
            if (LiczbaSlownie.Length >= 3)
            {
                double liczba = double.Parse(LiczbaSlownie);
                for (int i = LiczbaSlownieDlugosc; i > 0; i--)
                {
                    cyfra = liczba % 10;
                    Console.WriteLine((long)cyfra);
                    liczba /= 10;


                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Liczba jest zbyt krótka, wpisz przynajmniej 3-cyfrową. ");
                LiczbaSlownie = (Console.ReadLine());
                if (LiczbaSlownie.Length >= 3)
                {
                    double liczba = double.Parse(LiczbaSlownie);
                    for (int i = LiczbaSlownieDlugosc; i > 0; i--)
                    {
                        cyfra = liczba % 10;
                        Console.WriteLine((long)cyfra);

                        liczba /= 10;
                    }
                    }
                else
                    {
                        Console.WriteLine("Niestety nie słuchasz, zamykam program.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.ReadLine();
                }
            }

        }


    }

    



