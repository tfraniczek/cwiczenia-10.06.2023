using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int kwota, miesiace, oprocentowanie, wynik, belka, poBelce;

        Console.WriteLine("Wprowadz kwote oszczednosci");
        kwota = (int)inputValue();
        Console.WriteLine("Wprowadz czas trwania lokaty w miesiacach.");
        miesiace = (int)inputValue();
        Console.WriteLine("Wprowadz oprocentowanie w skali roku.");
        oprocentowanie = (int)inputValue();
        oprocentowanie = (int)((double)oprocentowanie / 100 / 12);
        wynik = (int)((double)(kwota * (1 + oprocentowanie) * miesiace) / 100);
        belka = (int)(wynik * 0.19);
        Console.WriteLine("Zarobisz przed opodatkowaniem " + wynik + " zl podatek Belki wyniesie " + belka + " zl");
        poBelce = wynik - belka;
        Console.WriteLine("Po opodatkowaniu zarobisz " + poBelce + " zl");
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
