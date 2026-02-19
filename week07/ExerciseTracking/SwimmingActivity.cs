public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    protected override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000;
        // Miles swimming laps * 50 / 1000 * 0.62
        return distance;
    }

    protected override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        double speed = distance / _minutes * 60;
        // (distance / minutes) * 60
        // 60 / pace
        return speed;
    }

    protected override double CalculatePace()
    {
        double distance = CalculateDistance();
        double pace = _minutes / distance;
        // minutes per mile or km
        // minutes/ distance
        // 60 / speed
        return pace;
    }

    protected override string ActivityType()
    {
        return "Swimming";
    }
    public override string GetSummary()
    {
        double distance = CalculateDistance(); 
        double speed = CalculateSpeed();
        double pace = CalculatePace();
        string activity = ActivityType();
       
        return $"{_date} {activity} ({_minutes} min) - Distance: {distance} kilometers, Speed: {speed} kph, Pace: {pace} min per km, Laps: {_laps}";
    }
}