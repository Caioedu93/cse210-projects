using System;
using System.Collections.Generic;

public class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsCompleted = false;
    }

    public virtual void MarkComplete()
    {
        IsCompleted = true;
    }

    public virtual string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}