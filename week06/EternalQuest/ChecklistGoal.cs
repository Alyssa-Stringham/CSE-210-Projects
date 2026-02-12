using System.ComponentModel;

public class ChecklistGoal : Goal
{
    // checklist 
    //      What is the name of your goal? 
    //      What is a short description of your goal? 
    //      How many points do you want accociated with this goal? (base/ points per action)
    //      How many times does this goal need to be accomplished for a bonus? 
    //      What is the bonus for accomplishing the goal that many times?      
    private int _amountCompleted;
    private int _target;
    private int _bonus; 

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        // set amount to begin at 0
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        // return true if goal is complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "string";
    }
    
    public override string GetDetailsString()
    {
        return "string";
    }
}