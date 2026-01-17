using System.IO;
public class Journal
{   
    public List<Entry> _entry;
    public void AddEntry(Entry _entry)
    {
        DateTime today = DateTime.Now;        
        _entry._dateText = today.ToShortDateString();
        _entry.DisplayEntries();        
        Prompts _promptText = new Prompts();
        _entry._promptText = _promptText.CreatePrompt();
        _entry._entryText = Console.ReadLine();
    }
    public void DisplayAll(List<Entry> _entry)
    {
        foreach (Entry entry in _entry)
        {
            entry.DisplayEntries();
        }
    }
    public void SaveToFile(List<Entry> _entry)
    {
        Console.WriteLine("Enter the file name: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entry)
            {
                outputFile.WriteLine($"{e._dateText} ~|~ {e._promptText} ~|~ {e._entryText}");
            }
        }   
    }
    public List<Entry> LoadFromFile()
    {
        List<Entry> _entry = new List<Entry>();        
        Console.WriteLine("Enter the file name: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string [] parts = line.Split("~|~");
            Entry newEntry = new Entry();
            newEntry._dateText = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entry.Add(newEntry);
        }
        return _entry;      
    }
}