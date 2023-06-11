using System.Media;
using System.Windows;
using System;
public class MeditationActivity : Activity{

    public MeditationActivity(){}

    public MeditationActivity(string activityName, string description): base (activityName, description){
       
    }

    public void DisplayMeditation(){
        Activity actM = new Activity();
        int time = actM.StartingMsg("Meditation Activity", "This activity will helh you decrease stress. It can also improve symptoms of stress-related conditions.  \nFocus through regular meditation may increase memory and mental clarity.");
        Console.Clear();
        actM.Countdown();
        Thread.Sleep(1000);
        Console.WriteLine("Close your eyes, relax and meditate until you hear the bell.");
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(time);

        while (DateTime.Now < endtime)
       {
           actM.Animation();
           Thread.Sleep(1000); 
       }
       Console.Beep();
    //    SoundPlayer player = new SoundPlayer(@"C:\bell.wav");
    //     try
    //     {
    //         player.Play();
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine("Error playing sound: " + ex.Message);
    //     }

       EndingMsg("Meditation Activity", time);
    }
    
}
