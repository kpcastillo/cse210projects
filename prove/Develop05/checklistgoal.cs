public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _numOfTimes;
    public override string RecordEvent()
    {
        return "";
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override void PointsMessage()
    {
        
    }
    public override int PointsTracker()
    {
        return 1;
    }
}