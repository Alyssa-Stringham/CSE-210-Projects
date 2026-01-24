using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Journal
{   
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        Prompts prompt = new Prompts();
        newEntry._promptText = prompt.CreatePrompt();
        Console.WriteLine(">");
        newEntry._entryText = Console.ReadLine();
        DateTime today = DateTime.Now;
        newEntry._dateText = today.ToShortDateString();
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntries();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._dateText} ~|~ {e._promptText} ~|~ {e._entryText}");
            }
        }   
    }
    public void LoadFromFile(string file)
    {

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            string _date = parts[0];
            string _prompt = parts[1];
            string _text = parts[2];

            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_prompt}");
            Console.WriteLine($"{_text}");
        }    
    }
}