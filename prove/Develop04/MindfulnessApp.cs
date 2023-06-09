using System;

public class MindfulnessApp
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");
            int choice = int.Parse(Console.ReadLine());

            Activity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.WriteLine();
                    continue;
            }

            Console.WriteLine();
            activity.Start();
        }
    }
}