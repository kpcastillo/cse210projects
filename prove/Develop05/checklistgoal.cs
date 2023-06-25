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
        _timesDone++;
        return _timesDone;
    }

    public override bool IsComplete()
    {
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