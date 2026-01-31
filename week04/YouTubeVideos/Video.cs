using System.Net;

public class Video
{
    private string _author;
    private string _title;
    private int _length;
    public List<Comments> _comments = new List<Comments>();
 
    private int NumberOfComments()
    {
        int commentNumber = _comments.Count();
        return commentNumber;
    }

    public void SetVideoValues(string author, string title, int length)
    {
        _author = author; 
        _title = title;
        _length = length;
        
        string videoDetails = $"{title} {author} {length}";
    }

    public void DisplayVideo()
    {
       int commentNumber = NumberOfComments();
       Console.WriteLine($"\n{_title}: {_author} \n Length in Seconds: {_length}, Number of Comments: {commentNumber}");
       Console.WriteLine("Comments:");
       foreach (Comments comment in _comments)
        {
            comment.DisplayComment();
        }
    } 
}