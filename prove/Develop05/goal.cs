public class Goal{
    private string _name;
    private string _description;
    private int _points;

    public virtual string RecordEvent(){
        return "";
    }
    public virtual bool IsComplete(){
        return true;
    }
    public virtual void PointsMessage(){}
    public virtual int PointsTracker(){
        return 1;
    }


}