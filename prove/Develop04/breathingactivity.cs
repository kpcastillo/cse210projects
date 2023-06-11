public class BreathingActivity : Activity{

    public BreathingActivity(): base (){
        _activityName = "BreathingActivity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    public BreathingActivity(string activityName, string description): base (){
        _activityName = activityName;
        _description = description;

    }

    public void DisplayBreathingAct(){
        Activity act1 = new Activity();
        int time = act1.StartingMsg("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.");

        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(time);

        while (DateTime.Now < endtime)
       {
           Console.WriteLine($"\nBreathe in... {act1.Countdown}");
           //Console.WriteLine($"{act1.Countdown}");
           Thread.Sleep(3000);
           //Console.Write("\b \b");
           Console.WriteLine($"\nBreathe out... {Countdown}");
           Thread.Sleep(3000);
           //Console.Write("\b \b");
       }
       EndingMsg("Brething Activity", time);
    }
}