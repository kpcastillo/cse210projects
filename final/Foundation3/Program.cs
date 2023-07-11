using System;

class Program
{
    static void Main(string[] args)
    {
        //one event of each type and sets all of their values. Then, for event event, 
        //call each of the methods to generate the marketing messages and output their results to the screen.
        LectureEvent lecture1 = new LectureEvent("Investing in TreasuryDirect", "Learn how to invest in low risk goverment backed up investments", "08/15/2023", "8:00PM", "8900 Convention Center DR Los Angeles CA", "John Doe", 200);
        lecture1.FullDetailLecture();
        lecture1.ShortDetail();

        Reception reception1 = new Reception("Smith-Wang Wedding", "Mayra Wang and Ivan Smith wedding", "05/11/24", "7:20PM", "4321 Las Vegas BLVD Las Vegas NV", "maywang@gmail.com");
        reception1.FullDetailReception();
        reception1.ShortDetail();

        OutdoorEvent outdoor1 = new OutdoorEvent("Afternooon Tea", "Join us for an afterrnoon full of friendship, tea, and treats", "09/20/2023", "2:30PM", "123 Garden Cir Houston TX");
        outdoor1.SetOutdoorEvent("78 degrees Farenheit, Sunny with wind 5mph.");
        outdoor1.FullDetailOutdoor();
        outdoor1.ShortDetail();


    }
}