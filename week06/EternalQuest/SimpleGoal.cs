public class SimpleGoal : Goal
{     
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

        _points = points; 
        _isComplete = false; 
        // set variables for if it is complete to be false
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {

        _points = points; 
        _isComplete = isComplete; 
        // set variables for if it is complete to be false
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    

    public override bool IsComplete()
    {
        if (_isComplete ==true)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
       //provide all the details of a goal in a way that is easy to save to a file and then load later 
        return  $"SimpleGoal:{_goalName}~|~{_description}~|~{_points}~|~{_isComplete}";
    }   
}