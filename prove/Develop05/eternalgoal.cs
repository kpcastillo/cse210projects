public class EthernalGoal : Goal
{
    public EthernalGoal(){}
    public EthernalGoal(string name, string description, int points) : base (name, description, points){}
    public override bool IsComplete(){
        return false;
    }
    // public override int RecordEvent(){
    //     base.RecordEvent();
    // }
    public override void PointsMessage(){}
    // public override int PointsTracker(){
    //     return 1;
    // }
    
}