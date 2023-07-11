public class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {}
    public void SetOutdoorEvent(string weather)
    {
        _weather = weather;
    }
    public void WeatherCard()
    {
        Console.WriteLine($"The expected weather for {_date} is {_weather}");
    }
    public void FullDetailOutdoor()
    {
        Console.WriteLine();
        Console.WriteLine("OUTDOOR EVENT:");
        StandarDetail();
        WeatherCard();
      
    }
}