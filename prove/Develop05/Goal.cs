// Base class for all types of goals
public abstract class Goal
{
    protected internal string _shortName;
    protected string _description;
    protected internal int _points; // Change access level to protected internal

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods to be overridden by derived classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}


// Derived class representing a simple goal
