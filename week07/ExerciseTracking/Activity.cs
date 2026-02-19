using System.Runtime.InteropServices;

public abstract class Activity
{
    // track date and length in minutes
    protected string _date; 
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public virtual string GetSummary() 
    {
        double _distance = CalculateDistance(); 
        double _speed = CalculateSpeed();
        double _pace = CalculatePace(); 
        string activity = ActivityType();
        // 03 Nov 2022 Activity (30 minutes) - Distance: 3.0 miles, Speed: 6.0 mph, Pace: 10.0 min per mile
        // 03 Nov 2022 (30 minutes) - Distance: 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km        
        return $"{_date} {activity} ({_minutes} min) - Distance: {_distance.ToString("0.##")} kilometers, Speed: {_speed.ToString("0.##")} kph, Pace: {_pace.ToString("0.##")} min per km";
    }    
    protected abstract double CalculateDistance();

    protected abstract double CalculateSpeed();

    protected abstract double CalculatePace(); 

    protected abstract string ActivityType();
}