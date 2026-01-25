public class Word
// Keeps track of a single word and whether it is shown or hidden.

{
   
    private string _text; // text of the word itself as a string
    private bool _isHidden; // indicates if the word is shown or hidden 

    public Word(string text)
    // accepts the text of the word and saves it as an attribute
    // sets the initial  visibility of the word (shown or hidden)
    // shouldn't need to pass in the visibility of the word; it can be set to visible by default
    {
        _text = text; 
    }

    public void Hide()
    {
       //foreach (string letter in words)
        {
            //letter.Name = "_";
        }

    }

    public void Show()
    {
        // set to default
    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    //should display either the word, or the letters of the word replaced with underscores
    {
        return "String";
    }
}