using System;

public class Program
{
    public static void Main(string[] args)
    {
        var activities = new Activity[]
        {
            new RunningActivity { Date = new DateTime(2022, 11, 3), Minutes = 30, Distance = 3.0 },
            new CyclingActivity { Date = new DateTime(2022, 11, 3), Minutes = 30, Speed = 20 },
            new SwimmingActivity { Date = new DateTime(2022, 11, 3), Minutes = 30, Laps = 20 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}