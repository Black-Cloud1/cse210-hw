public class Comment
{
    // Member variables
    public string _user;
    public string _commentText;

    // Constructor that is invocked by a key word (new Comment)
    public Comment(string user, string text)
    {
        _user = user;
        _commentText = text;
    }
}