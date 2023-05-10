using System;
using System.Collections.Generic;

    public class PromptGenerator
    {

       List<string> promptList = new List<string>{
       // string[] promptList = {
                "What was the best part of your day?",
                "What was the one challenging part of your day?",
                "What is something you are thankfull for today?",
                "Chicago"                    
            };
    
        static Random random = new Random(); 
        //string randomPrompt = random.Next(promptList.lenght);
        //string randomPrompt = promtList[random.Next(promptList.lenght)];
        //int index = random.Next(promptList.Count);
            //string randomPrompt = random.Next(promptList.lenght);
        //string randomPrompt = promtList[random.Next(promptList.lenght)];
        public void displayRandomPrompt()
        {
           // Console.WriteLine(randomPrompt);
           // Console.WriteLine(promptList[index]);
        }
        

    }