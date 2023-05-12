using System;
using System.Collections.Generic;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile( string fileName)
    {
        
    {
        Console.Write("Enter the file name to save the journal: ");
        string savefileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.prompt},{entry.response},{entry.date}");
            }
        }

        Console.WriteLine($"Journal saved to {fileName}");
    }
        }

    public void LoadFromFile(string fileName)
    {
        
    {
        Console.Write("Enter the file name to load the journal: ");
        string savefileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File {fileName} does not exist.");
            return;
        }

        entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                Entry entry = new Entry(fields[0], fields[1], fields[2]);
                entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal loaded from {fileName}");
    }
    }
}
