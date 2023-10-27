using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string fileName = $"c:/test/test_filip_Kuzba.txt";

        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);
            int count = content.Count(c => c == 'a');
            Console.WriteLine($"Liczba wystąpień litery 'a' w pliku: {count}");
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}