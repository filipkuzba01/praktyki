using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] imiona = { "Ania", "Kasia", "Basia", "Zosia", "Dagna", "Jadwiga", "Grażyna", "Monika", "Kinga", "Helena", "Wanda", "Krystyna" };
        string[] nazwiska = { "Kowalska", "Nowak", "Kwiatkowska", "Grzybowski", "Woźniak", "Kruk", "Lewandowska", "Pracuś", "Zając", "Boryś" };
        Random random = new Random();
        string fileName = $"users-{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.csv";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("LP,Imię,Nazwisko,Rok urodzenia");

            for (int i = 1; i <= 100; i++)
            {
                string imie = imiona[random.Next(imiona.Length)];
                string nazwisko = nazwiska[random.Next(nazwiska.Length)];
                int rokUrodzenia = random.Next(1990, 2001);

                writer.WriteLine($"{i},{imie},{nazwisko},{rokUrodzenia}");
            }
        }

        Console.WriteLine($"Plik CSV został wygenerowany: {fileName}");
    }
}