using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percentage: ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade <90 && grade >=80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class. ");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class. Try agian. ");
        }
    }
}