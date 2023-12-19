using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "starships.txt";

        while (true)
        {
            Console.WriteLine("1. Wyświetl nazwy statków");
            Console.WriteLine("2. Dodaj nazwę statku");
            Console.WriteLine("3. Wyświetl pierwsze 10 linii pliku");
            Console.WriteLine("4. Usuń zawartość pliku");
            Console.WriteLine("5. Zapisz plik");
            Console.WriteLine("6. Wyjście");

            Console.Write("Wybierz opcję (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayNames(filePath);
                    break;
                case "2":
                    AddName(filePath);
                    break;
                case "3":
                    First10(filePath);
                    break;
                case "4":
                    Clear(filePath);
                    break;
                case "5":
                    Save(filePath);
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }

    static void DisplayNames(string filePath)
    {
        string[] starships = File.ReadAllLines(filePath);

        for (int i = 0; i < starships.Length; i++)
        {
            Console.WriteLine($"Statek nr #{i + 1} ma nazwę {starships[i]}");
        }
    }
    static void AddName(string filePath)
    {
        Console.Write("Podaj nazwę statku: ");
        string name = Console.ReadLine();

        File.AppendAllText(filePath, name + Environment.NewLine);
        Console.WriteLine("Nazwa statku została dodana.");
    }
    static void First10(string filePath)
    {
        string[] starships = File.ReadAllLines(filePath);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Statek nr #{i + 1} ma nazwę {starships[i]}");
        }
    }
    static void Clear(string filePath)
    {
        File.WriteAllText(filePath, string.Empty);
        Console.WriteLine("Zawartość pliku została usunięta.");
    }

    static void Save(string filePath)
    {
        Console.WriteLine("Zapisano plik.");
    }
}
                    
            