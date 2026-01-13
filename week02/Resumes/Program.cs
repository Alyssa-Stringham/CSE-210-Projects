using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Jr. Software Engineer";
        job1._startYear = 2011;
        job1._endYear = 2018; 

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2025;

        //Console.WriteLine($"{job1._company}");
        //Console.WriteLine($"{job2._company}");
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "John Paul";
        
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        //Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.DisplayResume();
    }
}
