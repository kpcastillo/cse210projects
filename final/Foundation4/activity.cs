public abstract class Activity
{
    protected string _date;
    protected int _lenght;
    protected string _email;
    public virtual int Distance()
    {
        return 1;
    }
    public virtual int Speed()
    {
        return 1;
    }
    public virtual int Pace()
        {
            return 1;
        }
    public virtual void GetSummary()
    {

    }
}