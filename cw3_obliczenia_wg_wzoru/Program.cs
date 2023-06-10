using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int m, n, k, nSilnia, kSilnia, i, j;

        Console.WriteLine("Podaj liczbe n. Musi byc wieksza niz 5");
        n = (int)inputValue();
        if (n >= 5)
        {
        }
        else
        {
            Console.WriteLine("Podales liczbe mniejsza niz 5, podaj prawidlowa wartosc.");
            n = (int)inputValue();
            if (n >= 5)
            {
            }
            else
            {
                Console.WriteLine("To nadal za mala liczba. Uruchom program ponownie");
            }
        }
        Console.WriteLine("Podaj liczbe k. Musi byc wieksza niz 5.");
        k = (int)inputValue();
        if (k >= 5)
        {
        }
        else
        {
            Console.WriteLine("Podales liczbe mniejsza niz 5, podaj prawidlowa wartosc.");
            k = (int)inputValue();
            if (k >= 5)
            {
            }
            else
            {
                Console.WriteLine("To nadal za mala liczba. Uruchom program ponownie");
            }
        }
        nSilnia = 1;
        for (i = 1; i <= n; i++)
        {
            nSilnia = nSilnia * i;
        }
        kSilnia = 1;
        for (j = 1; j <= k; j++)
        {
            kSilnia = kSilnia * j;
        }
        m = (int)((double)(nSilnia - kSilnia) / kSilnia);
        Console.WriteLine("Wynik obliczen to " + m);
        Console.ReadLine();
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
