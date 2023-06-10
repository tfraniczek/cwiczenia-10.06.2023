using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int liczba, wieksza, mniejsza, odpowiedz;

        liczba = random.Next(20) + 1;
        Console.WriteLine("Komputer wylosuje liczbe z przedzialu 1 do 20, jeśli propozycja jest mniejsza od szukanej liczby wpisz wartość ujemną, a dodatnią jeśli propozycja jest większa. Wpisz zero jeśli komputer trafi prawidłową liczbę.");
        Console.WriteLine("Czy masz na myśli liczbę " + liczba + " ?");
        odpowiedz = (int)inputValue();
        while (odpowiedz != 0)
        {
            if (odpowiedz > 0)
            {
                liczba = liczba - random.Next(3);
            }
            else
            {
                liczba = liczba + random.Next(3);
            }
            Console.WriteLine("Czy masz na myśli liczbę " + liczba + " ?");
            odpowiedz = (int)inputValue();
        }
        Console.WriteLine("Zgadłem!");
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
