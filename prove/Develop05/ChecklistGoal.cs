// Derived class representing a checklist goal
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Overrides base class method
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Recorded event for {_shortName}."); // Example output
        if (_amountCompleted == _target)
        {
            _points += _bonus; // Apply bonus if the target is reached
            Console.WriteLine($"Bonus awarded for {_shortName}."); // Example output
        }
    }

    // Overrides base class method
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Overrides base class method
    public override string GetDetailsString()
    {
        return $"Completed {_amountCompleted}/{_target} times {_shortName}: {_description}"; // Example output
    }

    // Overrides base class method
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}