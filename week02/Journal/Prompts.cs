using System;
using System.Collections.Generic;

public class Prompts
{ 
    public List<string> _prompts;
    
    public string CreatePrompt()
    {
        List<string> questions;
        questions = new List<string>();
        string _prompt1 = "Who was the most interesting person I interacted with today? ";
        questions.Add(_prompt1);
        string _prompt2 = "What was the best part of my day? ";
        questions.Add(_prompt2);
        string _prompt3 = "How did I see the hand of the Lord in my life today? ";
        questions.Add(_prompt3);
        string _prompt4 = "What was the strongest emotion I felt today? ";
        questions.Add(_prompt4);
        string _prompt5 = "If I had one thing I could do over today, what would it be? ";
        questions.Add(_prompt5);
        string _prompt6 = "What is one accomplishment from today that you are proud of? ";
        questions.Add(_prompt6);
        string _prompt7 = "What is one thing you did to improve your day today? ";
        questions.Add(_prompt7);  
        string[] randomItemArray = Random.Shared.GetItems(questions.ToArray(), 1);
        string randomPrompt = randomItemArray[0];
        Console.WriteLine(randomPrompt);  
        return "";
    }    
}