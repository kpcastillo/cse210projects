public class BreathingActivity : Activity{

    public BreathingActivity(): base (){
        _activityName = "BreathingActivity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void DisplayBreathingAct(){
        Activity act1 = new Activity();
        int time = act1.StartingMsg();
        Console.WriteLine(act1);
        
    }
    

    //The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    // After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
    // After each message, the program should pause for several seconds and show a countdown.
    // It should continue until it has reached the number of seconds the user specified for the duration.
    // The activity should conclude with the standard finishing message for all activities.
}