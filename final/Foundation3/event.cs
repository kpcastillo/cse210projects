public class Event
{
    protected string _eventTitle;
    protected string _eventType;
    protected string _description;
    protected DateOnly _date;
    protected TimeOnly _time;
    protected string _address;
    public Event(string title, string description, DateOnly date, TimeOnly time, string address)
    {
        _eventTitle = title;
        _eventType = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void StandarDetail()
    {
        //Standard details - Lists the title, description, date, time, and address.
        Console.WriteLine($"\nEvent - {_eventTitle}, {_description}.");
        Console.WriteLine($"Date: {_date} {_time}, Location: {_address}\n");
    }
    public void ShortDetail()
    {
        //Short description - Lists the type of event, title, and the date.
        Console.WriteLine($"{_eventType} - {_eventTitle}, {_date}.");
    }

}