using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment name1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(name1.GetSummary());

        
        MathAssignment name2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(name2.GetSummary());
        Console.WriteLine(name2.GetHomeworkList());

        WritingAssignment name3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(name3.GetSummary());
        Console.WriteLine(name3.GetWritingInformation());
    }
}