// _book: string
// _chapter: int
// _verse: int
// _endVerse: int

// Reference(book: string, chapter: int, verse: int)
// Reference(book: string, chapter: int, startVerse: int, endVerse: int)

// GetDisplayText(): string

public class Reference
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
        // call something to get text of scripture here
        string completeScripture = $"{_book} {_chapter}: {_verse}";
        return "string";
    }
}