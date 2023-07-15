public class CyclingActivity : Activity
{
    public double Speed { get; set; }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetDistance()
    {
        if (Minutes == 0)
            return 0;

        return Speed * (Minutes / 60.0);
    }

    public override double GetPace()
    {
        if (Speed == 0)
            return 0;

        return 60 / Speed;
    }
}