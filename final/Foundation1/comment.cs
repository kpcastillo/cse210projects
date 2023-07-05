public class Comments
{
    public string _person;
    public string _comment;
    public Comments(string person, string comment)
    {
        _person = person;
        _comment = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_comment} , {_person}");
    }
}