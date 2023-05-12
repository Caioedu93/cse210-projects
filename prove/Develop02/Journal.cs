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

    public void SaveToFile( string savefileName)
    {
        
    {
        using (StreamWriter writer = new StreamWriter(savefileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.prompt},{entry.response},{entry.date}");
            }
        }

        Console.WriteLine($"Journal saved to {savefileName}");
    }
        }

    public void LoadFromFile(string loadfileName)
    {
        
    {
        if (!File.Exists(loadfileName))
        {
            Console.WriteLine($"File {loadfileName} does not exist.");
            return;
        }

        entries.Clear();

        using (StreamReader reader = new StreamReader(loadfileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                Entry entry = new Entry(fields[0], fields[1], fields[2]);
                entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal loaded from {loadfileName}");
    }
    }
}
