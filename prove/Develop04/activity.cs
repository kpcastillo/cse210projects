public class Activity{

    protected string _activityName;
    protected int _time;
    protected string _description;
    protected string _message;
    protected string[] _listForRandom;
    public Activity(){}
    public Activity(string activityName, string description){
        _activityName = activityName;
        _description = description;
    }
    // public Activity(string activityName, int time, string description){
    //     _activityName = activityName;
    //     _time = time;
    //     _description = description;
    // }
    public int StartingMsg(){
        //provides the name of the activity, & a description
        Console.WriteLine($"Welcome to the {_activityName} ");
        Console.WriteLine($"{_description}");
        //and asks for and sets the duration of the activity in seconds. 
        Console.WriteLine("How many seconds would you like to set for the activity?");
        string time = Console.ReadLine();
        _time = int.Parse(time);
        //Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.WriteLine("Prepare to begin");
        Console.Clear();
        Animation(5000);
        return _time;
    }
    public void Animation(int time)
    {

       List<string> animation = new List<string>{
           "|", "/", "-","\\",
           "|","/", "-","\\"
       };
       DateTime startTime = DateTime.Now;
       DateTime endingTime = startTime.AddSeconds(12);

       int i = 0;

       while (startTime < endingTime)
       {
           string a = animation[i];
           Console.Write(a);
           Thread.Sleep(1000);
           Console.Write("\b \b");

           i++;
           if (i >= animation.Count)
           {
               i =  0;
           }
       }

    }
    public void Countdown(int time)
    {
        for (int i=time; i>0; i--){
            Console.Write(i);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done.");
    }
    public void EndingMsg()
    {
        Console.WriteLine($"Good job.");
        Thread.Sleep(5000);
        Console.WriteLine($"You completed the {_activityName} for {_time} seconds.");
        Thread.Sleep(5000);     
        Animation(5000);
    }
    public string ChooseRandom(string[] promptList){
        Random random = new Random(); 
        int listCount = promptList.Length;
        int index = random.Next(listCount);
        string randomPrompt = promptList[index];
        return randomPrompt;
    }
}