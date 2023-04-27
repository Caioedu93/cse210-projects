using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        int usernumber = -1;
        while (usernumber !=0)
        {
           Console.Write("Enter a number(0 to quit):");
           
           string userReasponse = Console.ReadLine();
           usernumber = int.Parse(userReasponse);

           if (usernumber != 0)
           {
            numbers.Add(usernumber);
           }
        } 

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
