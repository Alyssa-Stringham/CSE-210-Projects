using System.Runtime.CompilerServices;

public class Reference
// Keeps track of the book, chapter, and verse information

// Key Behaviors
// Get the Display Text of the reference (string combining book, chapter, and verse/ verses)
// Best to use a constructor to set data elements

// METHOD NAMES
// GetDisplayText(): string
// possible getters and setters

// MEMBER VARIABLES
// book (string)
// chapter (int)
// verse (int)
// second/ end verse of range

// CONSTRUCTOR
// Two different constructors (to account for cases where there is a single verse or multiple verses)
//      first: receives book, chapter, and verse
//      second: receives book, chapter, start verse, and end verse
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        // need to figure out how to format if only one verse
        string completeReference= $"{_book} {_chapter}: {_verse}-{_endVerse}";
        return completeReference;
    }
}