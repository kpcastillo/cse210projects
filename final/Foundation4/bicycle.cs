public class Bicycle : Activity
{

    private int _speed;
    public Bicycle(DateOnly date, string name, int length, int speed) : base (date, name, length)
    {
        _name = "Bicycle";
        _speed = speed;
    }
    public override double Distance()
    {
        return (_speed * _lenght) / 60;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return 60 / _speed;
    }
    public override void GetSummary()
    {
        base.GetSummary();
    }
    
}