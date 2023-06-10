using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int podstawa, potega, wynik, i;

        Console.WriteLine("Program sluzy do potegowania liczb." + "Prosze podac podstawe potegi: ");
        podstawa = (int)inputValue();
        Console.WriteLine("Prosze podac do jakiej potegi podniesc liczbe z podstawy: ");
        potega = (int)inputValue();
        wynik = (int)Math.Pow(podstawa, potega);
        Console.WriteLine("Wynikiem potegowania jest: " + wynik);
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
