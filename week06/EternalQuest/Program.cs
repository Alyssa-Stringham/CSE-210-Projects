using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager gm = new GoalManager();
        gm.Start();
        
        // ideas for enhancement: 
        //      add ideas for gameification (levelign up, earning certain bonuses, etc.)
        //      add additional kinds of goals (ex. ability to make progress toward a large goal, 
        //          or losing points for bad habits - negative goals)
    }
}