using System.Security.AccessControl;

public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;   
    }
    protected override double CalculateDistance()
    {
        double distance = _speed / 60 * _minutes;
        return distance;
    }
    protected override double CalculateSpeed()
    {
        // (distance / minutes) * 60
        // 60 / pace
        return _speed;
    }
    protected override double CalculatePace()
    {
        double pace = 60/ _speed;
        // minutes/ distance
        // 60 / speed
        return pace;
    }
    protected override string ActivityType()
    {
        return "Cycling";
    }
}