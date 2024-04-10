public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Set to false by default
    }

    // Overrides base class method
    public override void RecordEvent()
    {
        _isComplete = true; // Mark the goal as complete
        Console.WriteLine($"Recorded event for {_shortName}."); // Example output
    }

    // Overrides base class method
    public override bool IsComplete()
    {
        return _isComplete; // Return the completion status
    }

    // Overrides base class method
    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description}"; // Example output
    }

    // Overrides base class method
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}