public class Activity{

    protected string _activityName;
    protected int _time;
    protected string _description;
    public Activity(){}
    public Activity(string activityName, int time, string description){
        _activityName = activityName;
        _time = time;
        _description = description;
    }
    public string StartingMsg(){
        //provides 
        //the name of the activity, a description, and asks for and sets the /
        //duration of the activity in seconds. Then, it should tell the user 
        //to prepare to begin and pause for several seconds.

        return "";
    }
    public string Animation(){
        // spinner, a countdown timer, or periods being displayed 
        //to the screen.
        return "";

    }
    public string EndingMsg(){
        // tells the 
        //user they have done a good job, and pause and then tell them the 
        //activity they have completed and the length of time and pauses for several 
        //seconds before finishing.
        return "";

    }
    
//Each activity should start with a common starting message 
// Each activity should end with a common ending message 
// Whenever the application pauses it should show some kind of animation to the user
}