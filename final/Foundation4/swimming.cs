public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateOnly date, string name, int length, int laps) : base (date, name, length)
    {
        _name = "Swimming";
        _laps = laps;
    }
    public override double Pace()
    {
        return _lenght / Distance();
    }
    public override double Speed()
    {
        return Distance() / _lenght;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000;
    }
    public override void GetSummary()
    {
        base.GetSummary();
    }
}