using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string name = PromptName();

        int number = PromptNumber();

        int numberSquare = SquareNumber(number);

        DisplayResult(name, numberSquare);

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;     
    }

    static int PromptNumber()        
    {
        Console.Write("Enter your favorite number (as an integer)");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square; 
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}