// track name of the person who made the comment
// track the text of the comment 
public class Comments
{
    private string _name;
    private string _commentText; 

    public void SetComment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: '{_commentText}' ");
    }
}