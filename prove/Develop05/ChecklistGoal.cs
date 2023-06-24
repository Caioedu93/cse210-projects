public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletionCount { get; set; }
    private bool isGoalCompleted;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CompletionCount = 0;
        isGoalCompleted = false;
    }

    public override void MarkComplete()
    {
        if (isGoalCompleted)
            return;

        CompletionCount++;
        if (CompletionCount == TargetCount)
        {
            isGoalCompleted = true;
            IsCompleted = true;
            Value += 500;
        }
    }

    public override string GetProgress()
    {
        string progress = isGoalCompleted ? "[X]" : "[ ]";
        return $"{progress} Completed {CompletionCount}/{TargetCount} times";
    }
}