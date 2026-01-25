using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

string action = "";
        do
        {
            
            Console.Clear();
            
            Reference r1 = new Reference("Proverbs", 3, 5, 6);
            Scripture s1 = new Scripture(r1, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths. ");            
            
            //Scripture should display once, then prompt user for action

            // if user doesn't quit, hide a few random words in the scripture, clear the console screen
            // and display the scripture again 

            // continue prompting user and hiding more words until the scripture is completely hidden 

            // when all words are hidden, program should end

            // core requirements - words can be selected completely randomly (even if already hidden)
            // stretch - try to randomly select from only the words not already hidden 
            Console.WriteLine(s1); 

            Console.WriteLine("Please enter to continue or type 'quit' to finish");
            action = Console.ReadLine(); 

        } while (action != "quit");

        if (action == "quit")
        {
            Console.Clear();
            Environment.Exit(0);
        }

    }
}