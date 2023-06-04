public class BreathingActivity : Activity{

    public BreathingActivity(string activityName, int time, string description): base (activityName, time, description){
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public int SetAcivityTime(){
        return 1;
    }
    

    //The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    // After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
    // After each message, the program should pause for several seconds and show a countdown.
    // It should continue until it has reached the number of seconds the user specified for the duration.
    // The activity should conclude with the standard finishing message for all activities.
}