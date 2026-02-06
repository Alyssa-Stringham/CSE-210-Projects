public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description): base(name, description)
    {
        
    }
    public void Run()
    {

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breate out...");
            ShowCountDown(5);
            Console.WriteLine();            
        }
    }
}