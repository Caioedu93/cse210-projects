public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int totalScore = 0;

    public static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Eternal Quest - Menu");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Display Total Score");
            Console.WriteLine("6. Show List of Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    DisplayTotalScore();
                    break;
                case "6":
                    ShowGoalList();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public static void AddGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal value: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type: ");
        string typeInput = Console.ReadLine();

        Goal goal;

        switch (typeInput)
        {
            case "1":
                goal = new Goal(name, value);
                break;
            case "2":
                goal = new EternalGoal(name, value);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistGoal(name, value, targetCount);
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not added.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine("Goal added successfully.");
    }

    public static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available. Please add goals first.");
            return;
        }

        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        int goalIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.MarkComplete();
            totalScore += goal.Value;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public static void SaveGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to save.");
            return;
        }

        {
        {
        Console.WriteLine("----- Save Goals -----");
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.GetType().Name);
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Value);
                    writer.WriteLine(goal.IsCompleted);

                    if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine(eternalGoal.CompletionCount);
                    }
                    else if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine(checklistGoal.TargetCount);
                        writer.WriteLine(checklistGoal.CompletionCount);
                    }
                }

                Console.WriteLine("Goals saved successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving goals: " + ex.Message);
        }
    }
    }

    }

    public static void LoadGoals()
    {
        {
        Console.WriteLine("----- Load Goals -----");
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                goals.Clear();

                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    string name = reader.ReadLine();
                    int value = int.Parse(reader.ReadLine());
                    bool isCompleted = bool.Parse(reader.ReadLine());

                    switch (goalType)
                    {
                        case "Goal":
                            goals.Add(new Goal(name, value) { IsCompleted = isCompleted });
                            break;
                        case "EternalGoal":
                            int completionCount = int.Parse(reader.ReadLine());
                            goals.Add(new EternalGoal(name, value)
                            {
                                CompletionCount = completionCount,
                                IsCompleted = isCompleted
                            });
                            break;
                        case "ChecklistGoal":
                            int targetCount = int.Parse(reader.ReadLine());
                            int completionCountChecklist = int.Parse(reader.ReadLine());
                            goals.Add(new ChecklistGoal(name, value, targetCount)
                            {
                                CompletionCount = completionCountChecklist,
                                IsCompleted = isCompleted
                            });
                            break;
                        default:
                            Console.WriteLine("Invalid goal type found in the file.");
                            break;
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading goals: " + ex.Message);
        }
    }
    }

    public static void DisplayTotalScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public static void ShowGoalList()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goal List:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string progress = goal.GetProgress();
            string completionStatus = goal.IsCompleted ? "[X]" : "[ ]";

            Console.WriteLine($"{i + 1}. {goal.Name} - {completionStatus} - {progress}");
        }
    }
}