using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        Assginment testAssignment = new Assginment("Will Smith", "Fractions");
        Console.WriteLine(testAssignment.GetSummary());

        MathAssignment math1 = new MathAssignment("Betty Parker", "Multiplication", "5.4", "1-8, 12-14");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Emma Jones", "European History", "The Causes of World War 1");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());

    }
}