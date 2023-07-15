using System;

public class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        if (distance == 0 || speed == 0 || pace == 0)
        {
            return "";
        }

        string summary = $"{Date:d MMM yyyy} ";

        if (this is RunningActivity)
        {
            summary += $"Running ({Minutes} min) - ";
        }
        else if (this is CyclingActivity)
        {
            summary += $"Cycling ({Minutes} min) - ";
        }
        else if (this is SwimmingActivity)
        {
            summary += $"Swimming ({Minutes} min) - ";
        }

        summary += $"Distance: {distance:F1} km, Speed: {speed:F1} kph, Pace: {pace:F1} min per km";

        return summary;
    }
}