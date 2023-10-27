using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            double kurs = 0.23;

            Console.WriteLine("-- KONWERSJA WALUTY --");
            Console.WriteLine("Aktualny kurs: " + kurs);
            Console.WriteLine("Podaj ilość w PLN: ");
            int podane;
            try
            {
                podane = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("> Błąd: " + e.Message);
                podane = 0;
            }
            if (podane > 0)
            {
                Console.WriteLine(podane + " PLN wynosi " + (podane * kurs) + " USD");
                Console.WriteLine("Wciśnij przycisk aby zakończyć");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Kwota muśi być większa niż zero");
                Main(args);
            }
        }
    }
}