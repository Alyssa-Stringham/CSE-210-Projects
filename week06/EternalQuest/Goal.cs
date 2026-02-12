// name, description, and point value
public abstract class Goal
{
   private string _goalName;
   private string _description;
   private int _points;

    public Goal(string name, string description, int points)
    {
        
    }

    public abstract void RecordEvent();
        // mark complete, add times done for checklist, return point value

    public abstract bool IsComplete();
        // return true if goal is complete

    public virtual string GetDetailsString()
    {
        // returns details of goal that can be shown in list
        // include checkbox, name, description
        // in checklist - overridden to show number of times goal done so far
        return "string";
    }
   
    public abstract string GetStringRepresentation();
        // provides all details of goal 
        // able to save to file and load from file
}