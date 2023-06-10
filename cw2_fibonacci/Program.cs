using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, i, pierwszaLiczba, drugaLiczba;

        pierwszaLiczba = 0;
        drugaLiczba = 1;
        Console.WriteLine("Program wyliczy ciag Fibonacciego dla podanej przez Ciebie liczby wyrazow, prosze podaj liczbe wyrazow: ");
        n = (int)inputValue();
        Console.WriteLine("Ciag na postac: ");
        for (i = 1; i <= n; i++)
        {
            drugaLiczba = pierwszaLiczba + drugaLiczba;
            pierwszaLiczba = drugaLiczba - pierwszaLiczba;
            Console.WriteLine(drugaLiczba);
        }
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
