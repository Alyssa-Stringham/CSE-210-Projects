public class Entry
{
    public string _dateText;
    public string _promptText;
    public string _entryText;
    public void DisplayEntries()
    {
        Console.WriteLine($"Date: {_dateText}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}