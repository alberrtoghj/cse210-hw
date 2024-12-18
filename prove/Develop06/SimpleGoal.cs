public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }
    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"'{Name} completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"'{Name}' is already completed. ");
        }
    }

    public override string GetStatus()
    {
        return IsComplete ? "[X]" : "[]";
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetStatus()} {Name} - {Description}");
    }
}
