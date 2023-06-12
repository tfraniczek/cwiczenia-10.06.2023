using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int numerPrzyblizenia, i, n;
        double wartoscPrzyblizenia;

        Console.WriteLine("Podaj wielkosc przyblizenia");
        numerPrzyblizenia = (int)inputValue();
        for (i = 1; i <= numerPrzyblizenia; i++)
        {
            wartoscPrzyblizenia = Math.Pow(numerPrzyblizenia, i) / (numerPrzyblizenia * i);
            wartoscPrzyblizenia = wartoscPrzyblizenia + Math.Pow(numerPrzyblizenia, i) / (numerPrzyblizenia * i);
        }
        Console.WriteLine("Wynik obliczen to " + wartoscPrzyblizenia);
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
