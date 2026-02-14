using System.ComponentModel;

public class ChecklistGoal : Goal
{   
    private int _amountCompleted;
    private int _target;
    private int _bonus; 

    public ChecklistGoal(string goalName, string description, int points, int target, int bonus) : base(goalName, description, points)
    {
        _target = target;
        _bonus = bonus; 
        _amountCompleted = 0;
    }
    public ChecklistGoal(string goalName, string description, int points, int target, int bonus, int amountCompleted) : base(goalName, description, points)
    {
        _target = target;
        _bonus = bonus; 
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1; 
        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
        Console.WriteLine($"Congratulations! You have earned {_points} points!");        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true; 
        }
        return false;
    }

    public override string GetStringRepresentation()
    {         
        return $"ChecklistGoal:{_goalName}~|~{_description}~|~{_points}~|~{_bonus}~|~{_target}~|~{_amountCompleted}";
    }
    
    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (_amountCompleted == _target)
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_goalName} ({_description}) -- Currently Completed {_amountCompleted} / {_target}";
    }
}