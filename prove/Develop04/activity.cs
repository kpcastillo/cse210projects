public class Activity{

    protected string _activityName;
    protected int _time;
    protected string _description;
  
    public Activity(){}
    public Activity(string activityName, string description){
        _activityName = activityName;
        _description = description;
    }
  
    public int StartingMsg(string activityN, string aDescription){
        //provides the name of the activity, & a description
        Console.WriteLine($"Welcome to the {activityN} ");
        Console.WriteLine($"{aDescription}");
        //and asks for and sets the duration of the activity in seconds. 
        Console.WriteLine("How many seconds would you like to set for the activity?");
        string time = Console.ReadLine();
        _time = int.Parse(time);
        //Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.Clear();
        Console.WriteLine("Prepare to begin");
        Animation();
        return _time;
    }
    public void Animation()
    {

       List<string> animation = new List<string>{
           "|", "/", "-","\\",
           "|","/", "-","\\"
       };
       DateTime startTime = DateTime.Now;
       DateTime endingTime = startTime.AddSeconds(8);

       int i = 0;

       while (DateTime.Now < endingTime)
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
    public void Countdown()
    {
        for (int i=5; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
         }
    }
    public void EndingMsg(string activityName, int time)
    {
        Console.Clear();
        Console.WriteLine($"\nGood job.");
        Thread.Sleep(2000);
        Console.WriteLine($"You completed the {activityName} for {time} seconds.");
        Thread.Sleep(3000);     
        Animation();
    }
    public string ChooseRandom(string[] promptList){
        Random random = new Random(); 
        int listCount = promptList.Length;
        int index = random.Next(listCount);
        string randomPrompt = promptList[index];
        return randomPrompt;
    }
}