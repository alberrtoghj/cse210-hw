using System.Runtime.InteropServices.Marshalling;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            var goal = _goals[goalIndex];
            goal.RecordEvent();
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                _score += checklistGoal.Points + checklistGoal.BonusPoints;
            }
            else
            {
                _score += goal.Points;
            }
        }
    }
    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Description}|{goal.Points}|{goal.GetStatus()}");
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                _score = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split('|');
                    string type = line[0];
                    string name = line[1];
                    string description = line[2];
                    int points = int.Parse(line[3]);
                }
            }
        }
    }
}