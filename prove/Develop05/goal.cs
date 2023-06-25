public abstract class Goal{
    protected string _name;
    protected string _description;
    protected int _points;
    
    public Goal(){}
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = int.Parse(Console.ReadLine());
        return _points;

    }
    public abstract bool IsComplete();
    public virtual void PointsMessage(){
        Console.WriteLine($"Goal '{_name}' marked complete!");
        Console.WriteLine($"Congratulations you just earned {_points} points!");
    }
    public virtual int PointsTracker(){

        _points++;
        return _points;
    }
    //public abstract void DisplayGoal();
}