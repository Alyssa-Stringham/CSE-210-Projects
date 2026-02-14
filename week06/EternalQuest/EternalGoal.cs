public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
       _points = points;  
    }

    public override void RecordEvent()
    {
       Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        //provide all the details of a goal in a way that is easy to save to a file and then load later
        return $"EternalGoal:{_goalName}~|~{_description}~|~{_points}";
    }
}
