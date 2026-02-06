public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _name = name;  
        _description = description;
    }

    public void Run()
    {
        DisplayPrompt();

        Console.WriteLine("When you have an experience in mind, press enter to continue. ");
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(intercept:true);
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine("Now ponder each of the following questions as they relate to this question. ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(5);           
        }
 
        // as future enhancement, can make sure to select different questions (not repeat the same question)
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        string prompt1 = "Think of a time when you stood up for someone else. ";
        _prompts.Add(prompt1);
        string prompt2 = "Think of a time when you did something really difficult. ";
        _prompts.Add(prompt2);
        string prompt3 = "Think of a time when you helped someone in need. ";
        _prompts.Add(prompt3);
        string prompt4 = "Think of a time when you did something truely selfless. ";
        _prompts.Add(prompt4);
        string prompt5 = "Think of a time when you learned something new. ";
        _prompts.Add(prompt5);

        string[] randomArray = Random.Shared.GetItems(_prompts.ToArray(), 1);
        string randomPrompt = randomArray[0];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        _questions = new List<string>();
        string question1 = "Why was this experience meaningful to you? ";
        _questions.Add(question1);
        string question2 = "Have you ever done anything like this before? ";
        _questions.Add(question2);
        string question3 = "How did you get started? ";
        _questions.Add(question3);
        string question4 = "How did you feel when it was complete? ";
        _questions.Add(question4);
        string question5 = "What made this time different than other times when you were not successful? ";
        _questions.Add(question5);
        string question6 = "What is your favorite thing about this experience? ";
        _questions.Add(question6);
        string question7 = "What could you learn from this experience that applies to other situations? ";
        _questions.Add(question7);
        string question8 = "What did you learn about yourself through this experience? ";
        _questions.Add(question8);
        string question9 = "How can you keep this experience in mind in the future? ";
        _questions.Add(question9);
        
        string[] randomQuestionArray = Random.Shared.GetItems(_questions.ToArray(), 1);
        string randomQuestion = randomQuestionArray[0];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);        
    }

    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);        
    }
}