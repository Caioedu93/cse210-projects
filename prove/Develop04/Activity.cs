using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    public Activity()
    {
        duration = 0;
    }

    public void Start()
    {
        ShowStartingMessage();
        Thread.Sleep(3000);
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
        Console.WriteLine("Begin!");
        Thread.Sleep(1000);

        PerformActivity();

        Console.WriteLine("Great job!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed the {GetType().Name} activity for {duration} seconds.");
        Thread.Sleep(3000);
        Console.WriteLine();
    }

    protected abstract void ShowStartingMessage();
    protected abstract void PerformActivity();
}