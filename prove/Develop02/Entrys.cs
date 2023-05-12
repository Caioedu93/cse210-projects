using System;

class Entry
{
    public string prompt;
    public string response;
    public string date;

    public Entry(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public void Display()
    {
        Console.WriteLine(date);
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine();
    }
}
