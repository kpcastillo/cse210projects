public abstract class Activity
{
    protected DateOnly _date;
    protected string _name;
    protected int _lenght;
    //protected string _email;
    public Activity(DateOnly date, string name, int length)
    {
        _date = date;
        _name = name;
        _date = date;
        _lenght = length;
    }

    public abstract double Distance();
    public abstract double Speed();
    
    public abstract double Pace();
        
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_lenght}min) - Distance {Distance()}miles, Speed {Speed()}mph, Pace: {Pace()} min per mile.");

    }
}