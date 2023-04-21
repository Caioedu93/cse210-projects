using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade?");
        string number= Console.ReadLine();
        int Grade = int.Parse(number);
        
        if (Grade >= 94)
        {
            Console.WriteLine("Your Grade is A.");
        }
        else if (Grade >= 90)
        {
            Console.WriteLine("Your Grade is A-.");
        }
        else if (Grade >= 87)
        {
            Console.WriteLine("Your Grade is B+.");
        }
        else if (Grade >= 84)
        {
            Console.WriteLine("Your Grade is B.");
        }
        else if (Grade >= 80)
        {
            Console.WriteLine("Your Grade is B-.");
        }
        else if (Grade >= 77)
        {
            Console.WriteLine("Your Grade is C+.");
        }
        else if (Grade >= 74)
        {
            Console.WriteLine("Your Grade is C.");
        }
        else if (Grade >= 70)
        {
            Console.WriteLine("Your Grade is C-.");
        }
        else if (Grade >= 67)
        {
            Console.WriteLine("Your Grade is D+.");
        }
        else if (Grade >= 64)
        {
            Console.WriteLine("Your Grade is D.");
        }
        else if (Grade >= 60)
        {
            Console.WriteLine("Your Grade is D-.");
        }
        else 
        {
            Console.WriteLine("Your Grade is F.");
        }

        if (Grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course, try Harder next time.");
        }
    }

}