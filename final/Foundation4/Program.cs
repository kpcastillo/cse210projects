using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        DateOnly date = new DateOnly();
        // Once you have the classes in place, write a program that creates at least one activity of each type. 
        // Put each of these activities in the same list. 
        // Then iterate through this list and call the GetSummary method on each item and display the results.
        RunningActivity running = new RunningActivity(date, "Running", 30, 10);
        activityList.Add(running);
        Bicycle bike = new Bicycle(date, "Bicycle", 60, 15);
        activityList.Add(bike);
        Swimming swim = new Swimming(date, "Swimming", 45, 22);
        activityList.Add(swim);

        foreach( Activity activity in activityList)
        {
            activity.GetSummary();
        }

    }
}