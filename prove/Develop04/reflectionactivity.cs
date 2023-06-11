public class ReflectionActivity : Activity{

    // private string[] _reflectionPrompts;
    // private string[] _questions;
    public ReflectionActivity(): base (){
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public ReflectionActivity(string activityName, string description): base (activityName, description){
        _activityName = activityName;
        _description = description;
  
    }
    public string RandomReflection(){
        string[] reflectionPrompts = new string[]{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        string selectReflection = ChooseRandom(reflectionPrompts);
        return selectReflection;
    }
    public string DisplayQuestions(){
            string [] questions = new string[]{
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
            string selectQuestion =ChooseRandom(questions);
            return selectQuestion;

    }
    public void DisplayReflection(){
        Activity actR = new Activity();
        int time = actR.StartingMsg("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.Clear();
        Console.WriteLine(RandomReflection());
        actR.Countdown();
        Thread.Sleep(1000);
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(time);

        while (DateTime.Now < endtime)
       {
           Console.WriteLine();
           Console.WriteLine(DisplayQuestions());
           Console.ReadLine();
           actR.Animation();
           Thread.Sleep(1000);
           Console.WriteLine();
           Console.WriteLine(DisplayQuestions());
           Console.ReadLine();
           actR.Animation();
           Thread.Sleep(1000);
           
       }
       EndingMsg("Reflection Activity", time);
      

    }
}