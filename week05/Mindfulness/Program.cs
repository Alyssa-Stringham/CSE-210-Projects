using System;
// Project enhancememt: For the reflecting activity, the program will select a random question 
// that has not already been shown to the user
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int userChoice = 0;
        while (userChoice !=4)
        {
            Console.WriteLine("Menu Options: \n 1. Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit"); 
            Console.WriteLine("Select an option from the menu: ");
            string userEntered = Console.ReadLine();
            userChoice = int.Parse(userEntered);

            if (userChoice == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity...");
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
            }

            else if (userChoice == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity...");
                reflecting.DisplayStartingMessage();
                reflecting.Run();
                reflecting.DisplayEndingMessage();
            }

            else if (userChoice == 3)
            {
                ListingActivity listing = new ListingActivity("Listing", "This activity...");
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }

            else if (userChoice == 4)
            {
                System.Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Invalid Entry. Please select a valid choice. ");
            }
        }
    }
}