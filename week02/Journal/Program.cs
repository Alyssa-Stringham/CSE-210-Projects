using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 1;
        while (userChoice !=5)
        {
            Console.WriteLine("Hello World! This is the Journal Project.");
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

        if (userChoice == 1)
        {
            Journal theJournal = new Journal();
            Entry anEntry = new Entry();             
            theJournal.AddEntry(anEntry);
        }

        else if (userChoice == 2)
        {
            Journal theJournal = new Journal();
            List<Entry> anEntry = new List<Entry>(); 
            theJournal.DisplayAll(anEntry);
        }

        else if (userChoice == 3)
        {
            Journal theJournal = new Journal();
            theJournal.LoadFromFile();
        }
        
        else if (userChoice == 4)
        {
            Journal theJournal = new Journal();
            List<Entry> _entries = new List<Entry>();
            theJournal.SaveToFile(_entries);    
        }

        else if (userChoice == 5)
        {
            System.Environment.Exit(0);
        }
    }
    }

}