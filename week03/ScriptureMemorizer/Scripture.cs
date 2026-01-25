using System.Security.AccessControl;
using Microsoft.Win32.SafeHandles;

public class Scripture
// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text
{
    private Reference _reference; // data type = Reference (a custom class)
    private List<Word> _words; // a list of all the words in the scripture
                               // a list of Word objects (not a list of strings)
    public Scripture (Reference _reference, string text)
    // accepts both a reference and the text of the scripture
    // pass in a string that is the text of the scripture
    // create the list and split up the words in the string to create 
    //      Word objects for each one and put them in the list
    {
        List<Word> words = new List<Word>();
        string[] lines = System.IO.File.ReadAllLines(text);

        foreach (string line in lines)
        {
            string[] parts = line.Split(" ");
            Word newWord = new Word(text);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    // methods to call: Words.GetDisplayText (show word or underscores)
    {
    
    }

    public string GetDisplayText()
    //refers to text with some words shown normally, and some replaced by underscores
    {
        return "String";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}