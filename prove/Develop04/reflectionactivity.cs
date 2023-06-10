public class ReflectionActivity : Activity{

    private string[] _reflectionPrompts;
    private string[] _questions;
    public ReflectionActivity(): base (){
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


    }
    //public ReflectionActivity(string activityName, int time, string description): base (activityName, time, description){
      //  
    //}
    public string RandomReflection(){
        string[] reflectionPrompt = new string[]{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        return "";
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
            return "";

    }


//The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// After the starting message, select a random prompt to show the user question
// After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list
// After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
// It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.
}