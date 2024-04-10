// Class responsible for managing goals
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1; // Start at level 1
    }

    // Method to display player's current score and level
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Current Level: {_level}");
    }

    // Method to list names of each goal
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    // Method to list details of each goal
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Method to create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());
        string type, name, description;
        int points, target, bonus;

        switch (choice)
        {
            case 1:
                type = "SimpleGoal";
                break;
            case 2:
                type = "EternalGoal";
                break;
            case 3:
                type = "ChecklistGoal";
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Simple Goal.");
                type = "SimpleGoal";
                break;
        }

        Console.Write("Enter the name of the goal: ");
        name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        description = Console.ReadLine();
        Console.Write("Enter the points associated with the goal: ");
        points = int.Parse(Console.ReadLine());

        if (type == "ChecklistGoal")
        {
            Console.Write("Enter the target number of times to accomplish the goal: ");
            target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points for achieving the target: ");
            bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            _goals.Add((Goal)Activator.CreateInstance(Type.GetType(type), name, description, points));
        }
    }

    // Method to record an event for a goal
    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in _goals)
        {
            if (goal._shortName == goalName)
            {
                goal.RecordEvent();
                _score += goal._points; // Update player's score
                CheckLevelUp(); // Check for level up
                break;
            }
        }
    }

    // Method to check if the player has reached the next level
    private void CheckLevelUp()
    {
        int levelThreshold = _level * 1000; // Level up every 1000 points
        if (_score >= levelThreshold)
        {
            _level++;
            Console.WriteLine($"Congratulations! You've reached Level {_level}!");
        }
    }

    // Method to save goals to a file
    public void SaveGoals()
    {
        Console.Write("Enter the name of the file to store the goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}.");
    }

    // Method to load goals from a file
    public void LoadGoals()
    {
        _goals.Clear(); // Clear existing goals
        Console.Write("Enter the name of the file to load the goals from: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }
        Console.WriteLine($"Goals loaded from {filename}.");
    }
}