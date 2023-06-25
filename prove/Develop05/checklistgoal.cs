public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    public int _numOfTimes;
    public int _timesDone;

    public ChecklistGoal(){}
    public ChecklistGoal(string name, string description, int points) : base (name, description, points){}
    public override int RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("How many times does this goal needs to be accomplished for a bonus? ");
        _numOfTimes = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        
        return _numOfTimes;
    }

    public override bool IsComplete()
    {
        _timesDone++;
        return _timesDone >= _numOfTimes;
    }
    public override void PointsMessage()
    {
        base.PointsMessage();
        if (_timesDone == _numOfTimes)
        {
            Console.WriteLine($"Congratulations! You received a bonus for completing your goal {_numOfTimes} times.");
            Console.WriteLine($"You get: {_bonusPoints} bonus points.");
        }
        
    }
    public override int PointsTracker()
    {
        return base.PointsTracker();
    }
        //_completedCount++;
            // if (_completedCount == _goalCount)
            // {
            //     _score += 10;
            // }
}