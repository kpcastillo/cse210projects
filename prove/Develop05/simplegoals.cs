public class SimpleGoal : Goal
{
    public SimpleGoal(){}
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}
    //public override int RecordEvent();
    public override bool IsComplete(){
        return true;
    }
    public override void PointsMessage(){}
    // public override int PointsTracker(){
    //     return 1;
    // }
    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

}