public class SimpleGoal : Goal
{
    // simple (gets checked off; once and done) 
    //      What is the name of your goal? 
    //      What is a short description of your goal? 
    //      How many points do you want accosiated with this goal?     
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // set variables for if it is complete to be false
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