using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml.Serialization;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();        
        int userChoice = 0;
        while (userChoice !=5)
        {
            //Console.WriteLine("Hello World! This is the Journal Project.");
            Console.WriteLine("Welcome to the Journal Entry Program!");
            Console.WriteLine("Please select an action from the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter the number corresponding with your desired action: ");
            string userAction = Console.ReadLine();
            userChoice = int.Parse(userAction);
        
        if (userChoice == 1)// write
        {
            Entry newEntry = new Entry();
            theJournal.AddEntry(newEntry);
        }

        else if (userChoice == 2)// display
        {
            theJournal.DisplayAll();
        }

        else if (userChoice == 3)//load
        {
            Console.WriteLine("Enter the file name: ");
            string file = Console.ReadLine();
            theJournal.LoadFromFile(file);
        }
        
        else if (userChoice == 4)// save
        {
            Console.WriteLine("Enter the file name: ");
            string file = Console.ReadLine();
            theJournal.SaveToFile(file); 
        }

        else if (userChoice == 5)
        {
            System.Environment.Exit(0);
        }
    }
    }

}