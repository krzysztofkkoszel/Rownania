using System;


class Rownanie
{
    static void Main()
    {
    poczatekprogramu:

        Console.WriteLine("Program rozwiązujący równania kwadratowe w postaci: Ax*x + Bx + C \nProszę podać współczynnik 'A'");

        string a = Console.ReadLine();

        Console.WriteLine("Proszę podać współczynnik 'B'");

        string b = Console.ReadLine();

        Console.WriteLine("Proszę podać współczynnik 'C'");

        string c = Console.ReadLine();

        double liczba1, liczba2, liczba3;

        try
        {
            liczba1 = Convert.ToDouble(a);
            liczba2 = Convert.ToDouble(b);
            liczba3 = Convert.ToDouble(c);
        }

        catch (Exception)
        {
            Console.WriteLine("Proszę wpisać poprawne wartości (liczby) dla współczynników równania\n");
            goto poczatekprogramu;
        }


        if (liczba1 == 0)
        {
            Console.WriteLine("W równaniu kwadratowym współczynnik 'A' nie może równać się 0\n");
            goto poczatekprogramu;
        }

        double delta = (liczba2 * liczba2) - 4 * (liczba1 * liczba3);

        if (delta < 0)
        {
            Console.WriteLine($"Wyróżnik równania wynosi: {delta}, Wykres równania nie ma miejsc zerowych.");
        }

        else if (delta == 0)
        {
            double rozw1 = (-liczba2) / (liczba1 * 2);

            Console.WriteLine($"Wyróżnik równania wynosi: {delta}, Wykres równania ma jedno miejsce zerowe: {rozw1}");
        }

        else if (delta > 0)
        {
            double rozw2 = ((-liczba2) - (Math.Sqrt(delta))) / (liczba1 * 2);

            double rozw3 = ((-liczba2) + (Math.Sqrt(delta))) / (liczba1 * 2);

            Console.WriteLine($"Wyróżnik równania wynosi: {delta} \nWykres równania ma dwa miejsca zerowe:\n {rozw2} i {rozw3}");
        }

        Console.WriteLine("\nProszę nacisnąć klawisz 'Enter', aby zakończyć działanie programu.");
        Console.ReadLine();

    }

}