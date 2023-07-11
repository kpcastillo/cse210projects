public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, string address, string email): base(title, description, date, time, address)
    {
        _email = email;
    }
    public void Confirmation()
    {

    }
    public void FullDetailReception()
    {
       // Full details - Lists all of the above, plus type of event and information specific to that event type. 
       //For receptions this includes an email for RSVP.
        Console.WriteLine();
        Console.WriteLine("RECEPTION EVENT:");
        StandarDetail();
        Console.WriteLine($"RSVP email: {_email}");
    }
}