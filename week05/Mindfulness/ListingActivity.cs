public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description)
    {
   
    }

    public void Run()
    {
        List<string> _userItems = new List<string>();
        _count = 0;
        
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in . . . ");
        ShowCountDown(5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string newItem = Console.ReadLine();
            _count += 1; 
            _userItems.Add(newItem);
        }
        Console.WriteLine($"You listed {_count} items! ");
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        string prompt1 = "Who are some people you appreciate in your life? ";
        _prompts.Add(prompt1);
        string prompt2 = "What are some of your personal strengths? ";
        _prompts.Add(prompt2);
        string prompt3 = "Who have you helped this week? ";
        _prompts.Add(prompt3);
        string prompt4 = "When have you felt the Holy Ghost this month? ";
        _prompts.Add(prompt4);        
        string prompt5 = "Who are some of your perssonal heroes? ";
        _prompts.Add(prompt5);        
        string prompt6 = "What have you learned this week? ";
        _prompts.Add(prompt6);

        string[] randomItemArray = Random.Shared.GetItems(_prompts.ToArray(), 1);
        string randomPrompt = randomItemArray[0];
        Console.WriteLine(randomPrompt);
        
        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> _userList = new List<string>();
        return _userList;
    }
}