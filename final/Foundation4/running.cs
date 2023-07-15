public class RunningActivity : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        if (Minutes == 0)
            return 0;

        return (Distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        if (Distance == 0)
            return 0;

        return Minutes / Distance;
    }
}