public class SwimmingActivity : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        if (Minutes == 0)
            return 0;

        return (Laps * 50 / 1000.0) / (Minutes / 60.0);
    }

    public override double GetPace()
    {
        if (Laps == 0)
            return 0;

        return Minutes / (Laps * 50 / 1000.0);
    }
}