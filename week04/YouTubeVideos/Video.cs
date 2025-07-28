public class Video
{
    // Objects or variables
    public string _title;
    public string _author;
    public int _duration;
    private List<Comment> _comments = new List<Comment>();

    // Constructor that is invocked by a key word
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    // Methods to display
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}

