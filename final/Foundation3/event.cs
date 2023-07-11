public class Event
{
    protected string _eventTitle;
    protected string _eventType;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    public Event(string title, string description, string date, string time, string address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public Event(){}
    public void StandarDetail()
    {
        //Standard details - Lists the title, description, date, time, and address.
        Console.WriteLine($"\nEvent - {_eventTitle}.");
        Console.WriteLine($"-{_description}-.");
        Console.WriteLine($"DATE: {_date} {_time}, Location: {_address}");
    }
    public void ShortDetail()
    {
        //Short description - Lists the type of event, title, and the date.
        Console.WriteLine($"\nEVENT: {_eventType} - {_eventTitle} - {_date}.\n");
    }

}