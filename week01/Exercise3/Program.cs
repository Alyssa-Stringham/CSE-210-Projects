using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Console.Write("What is the magic number? ");
        //string numberString = Console.ReadLine();
        //int number = int.Parse(numberString);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        int guess = -1;
        do
        { 
        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        guess = int.Parse(guessString);   
            if (number != guess)
            {
                if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
    }
}