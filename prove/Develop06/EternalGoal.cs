public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }
    public override void RecordEvent()
    {
        Console.WriteLine($"'{Name}' recorded! You earned {Points} points.");
    }

    public override string GetStatus()
    {
        return "[ ] (Eternal)";
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetStatus()} {Name} - {Description}");
    }
}

