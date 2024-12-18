public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; private set; }
    public int Points { get; private set; }
    public bool IsComplete { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract void DisplayGoal();
}