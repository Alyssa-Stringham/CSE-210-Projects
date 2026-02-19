public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    protected override double CalculateDistance()
    {
        return _distance;
    }

    protected override double CalculateSpeed() 
    {
        double speed = _distance / _minutes * 60;
        // 60 / pace
        return speed;
    }
    protected override double CalculatePace() 
    {
        double pace = _minutes / _distance;
        // minutes per mile or km
        // minutes/ distance
        // 60 / speed
        return pace;
    }

    protected override string ActivityType()
    {
        return "Running";
    }
}