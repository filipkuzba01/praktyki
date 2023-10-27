using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj ścieżkę do pliku tekstowego:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            int replaceCount = content.Split(new string[] { "praca" }, StringSplitOptions.None).Length - 1;

            if (replaceCount >= 5)
            {
                string newContent = content.Replace("praca", "job");
                string newFilePath = Path.GetFileNameWithoutExtension(filePath) + "changed" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                File.WriteAllText(newFilePath, newContent);
                Console.WriteLine($"Zamieniono 'praca' na 'job' i zapisano do pliku: {newFilePath}");
            }
            else
            {
                Console.WriteLine("W tekście nie występuje co najmniej 5 razy słowo 'praca'.");
            }
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}