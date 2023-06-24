public class EternalGoal : Goal
{
    public int CompletionCount { get; set; }

    public EternalGoal(string name, int value) : base(name, value)
    {
        CompletionCount = 0;
    }

    public override void MarkComplete()
    {
        CompletionCount++;
    }

    public override string GetProgress()
    {
        return $"Completed {CompletionCount} time(s)";
    }
}        