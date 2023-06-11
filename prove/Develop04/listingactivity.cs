public class ListingActivity : Activity{
   // private string[] _prompts;
    public ListingActivity():base (){
        _activityName = "Listing Activity";
        _description =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


    }
    public ListingActivity(string activityName, string description): base (activityName, description){
       
    }
    public string DisplayRandomPrompt(){
        string [] prompts = new string[]{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        string rPrompt = ChooseRandom(prompts);
        return rPrompt;
    }
    public int InputCount(){
        return 1;
    }
    public void DisplayListing(){
        Activity actL = new Activity();
        int time = actL.StartingMsg("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Clear();
        Console.WriteLine(DisplayRandomPrompt());
        Thread.Sleep(2000);
        actL.Countdown();
        Thread.Sleep(1000);
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(time);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        int entries = 0;

        while (DateTime.Now < endtime)
       {
           Console.WriteLine("\nWrite your entry. ");
           Console.ReadLine();

           entries++;
       }
       Console.WriteLine($"You wrote {entries} entries.");
       Thread.Sleep(2000);
       EndingMsg("Listing Activity", time);
       

    }
}