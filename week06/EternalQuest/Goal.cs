// name, description, and point value
using System.Runtime.CompilerServices;

public abstract class Goal
{
   protected string _goalName;
   protected string _description;
   protected int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points; 
    }

    public abstract void RecordEvent();
        // mark complete, add times done for checklist, return point value

    public abstract bool IsComplete();
        // return true if goal is complete

    public virtual string GetDetailsString()
    {
        string checkbox = "[ ]";        
        bool complete = IsComplete();
        if (complete == true)
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_goalName} ({_description})";
    }

    public int GetPoints()
    {
        return _points;
    }
   
    public abstract string GetStringRepresentation();
        // provides all details of goal 
        // able to save to file and load from file
}