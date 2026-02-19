using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        List<Activity> activities = new List<Activity>();

        SwimmingActivity swimming = new SwimmingActivity("13 May 2023", 60, 40);
        activities.Add(swimming);
        //Console.WriteLine(swimming.GetSummary());
        SwimmingActivity s2 = new SwimmingActivity("01 Aug 2023", 30, 25);
        activities.Add(s2);

        RunningActivity running = new RunningActivity("04 Sep 2024", 60, 12);
        activities.Add(running);
        //Console.WriteLine(running.GetSummary());
        RunningActivity r2 = new RunningActivity("17 Oct 2024", 45, 9);
        activities.Add(r2);

        CyclingActivity cycling = new CyclingActivity("22 Mar 2025", 60, 15);
        //Console.WriteLine(cycling.GetSummary());
        activities.Add(cycling);
        CyclingActivity c2 = new CyclingActivity("07 Apr 2025", 75, 20);
        activities.Add(c2);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}