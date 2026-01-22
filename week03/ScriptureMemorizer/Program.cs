using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Scripture Reference and Text");
        // start by displaying "text" and waits for user to press enter key
        Console.WriteLine("Please enter to continue or type 'quit' to finish");
        string action = Console.ReadLine();
        if (action == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
        // clears the console
        Console.Clear();
        // show new text
        Console.WriteLine("New text here"); 
        // currently only does once, change so it repeats until quit           
        }

    }
}