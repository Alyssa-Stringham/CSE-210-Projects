public class EternalGoal : Goal
{
    // eternal (never gets checked off)
    //      What is the name of your goal? 
    //      What is a short description of your goal? 
    //      How many points do you want accociated with this goal?     
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
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
}
