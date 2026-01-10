using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
    
        List<int> numbers = new List<int> ();
        int addNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");        
        while (addNumber != 0)
        {
            Console.Write("Enter a number: ");
            string addNumberString = Console.ReadLine();
            addNumber = int.Parse(addNumberString);
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }

        int sum = 0;;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}. ");

        int listLength = numbers.Count;
        float average = ((float)sum) / listLength;

        Console.WriteLine($"The average is {average}. ");
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }

        Console.WriteLine($"The max is {max}. ");
    }
}