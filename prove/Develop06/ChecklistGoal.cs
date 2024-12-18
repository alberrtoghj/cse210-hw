using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _completedCount;
    private int _bonusPoints;

    public int BonusPoints => _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints)
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _completedCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_completedCount < _requiredCount)
        {
            _completedCount++;
            Console.WriteLine($"'{Name}' progress: {_completedCount}/{_requiredCount}. You earned {Points} points!");

            if (_completedCount == _requiredCount)
            {
                IsComplete = true;
                Console.WriteLine($"'{Name}' is already completed.");
            }
       }
    }
        public override string GetStatus()
        {
           return IsComplete ? $"[X] Completed {_completedCount}/{_requiredCount}" : $"[ ] {_completedCount}/{_requiredCount}";
        }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetStatus()} {Name} - {Description}");
    }
}
