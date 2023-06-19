public class SimpleGoal : Goal{
    public override string RecordEvent(){
        return "";
    }
     public override bool IsComplete(){
        return true;
    }
    public override void PointsMessage(){}
    public override int PointsTracker(){
        return 1;
    }

}