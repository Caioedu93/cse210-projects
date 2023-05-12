using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool done = false;
        while (!done)
        {
            Console.WriteLine("1. Add new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter a menu option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Today.ToShortDateString();
                    Entry entry = new Entry(prompt, response, date);
                    journal.AddEntry(entry);
                    Console.WriteLine();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter a filename to save to: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.Write("Enter a filename to load from: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file.");
                    break;
                case "5":
                    done = true;
                    Console.WriteLine("Good Bye");
                    break;
                    
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
