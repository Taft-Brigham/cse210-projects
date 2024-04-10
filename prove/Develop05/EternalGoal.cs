// Derived class representing an eternal goal
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional attributes needed
    }

    // Overrides base class method
    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for {_shortName}."); // Example output
    }

    // Overrides base class method
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    // Overrides base class method
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}"; // Example output
    }

    // Overrides base class method
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}