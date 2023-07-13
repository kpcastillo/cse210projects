public class RunningActivity : Activity
{
    private int _distance;

public RunningActivity(DateOnly date, string name, int length, int distance): base(date, name, length)
{
    _distance = distance;
    _name = "Running";
}
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        double speed = _distance/_lenght * 60;
        return speed;
    }
    public override double Pace()
    {
        double pace = 60 / Speed();
        return pace;
    }
    public override void GetSummary()
    {
        base.GetSummary();
    }
}