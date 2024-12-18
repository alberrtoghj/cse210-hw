public class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine("1. Create Goal\n2. Record Event\n3. Display Goals\n4. Display Score\n5. Save Goals\n6. Load Goals\n7. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose goal type (1: Simple, 2: Eternal, 3: Checklist):");
                    string type = Console.ReadLine();
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter description:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter points:");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "1")
                        manager.AddGoal(new SimpleGoal(name, description, points));
                    else if (type == "2")
                        manager.AddGoal(new EternalGoal(name, description, points));
                    else if (type == "3")
                    {
                        Console.WriteLine("Enter required count:");
                        int requiredCount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter bonus points:");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, description, points, requiredCount, bonusPoints));
                    }
                    break;
                case "2":
                    manager.DisplayGoals();
                    Console.WriteLine("Enter goal number to record event:");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(goalIndex);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.DisplayScore();
                    break;
                case "5":
                    Console.WriteLine("Enter file path to save:");
                    string savePath = Console.ReadLine();
                    manager.SaveGoals(savePath);
                    break;
                case "6":
                    Console.WriteLine("Ente file path to load:");
                    string loadPath = Console.ReadLine();
                    manager.LoadGoals(loadPath);
                    break;
                case "7":
                    return;
            }
        }
    }
}