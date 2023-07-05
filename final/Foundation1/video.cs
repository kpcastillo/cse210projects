public class  Video
{
    public string _title;
    public string _author;
    public string _lenght;
    public List<Comments> _commentList = new List<Comments>{};
    public Video(string title, string author, string lenght){
        _title = title;
        _author = author;
        _lenght = lenght;
    }
    public int CommentCount()
    {
        return _commentList.Count;
        
    }
    public void DisplayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Video Title: {_title}\nAuthor: {_author}\nLength:{_lenght}");
        Console.WriteLine($"Comments:");

                foreach(Comments comment in _commentList)
                {
                    comment.DisplayComment();
                }
        Console.WriteLine($"Total comments: {_commentList.Count}\n");
        CommentCount();
    }

}