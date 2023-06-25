using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalTrack goalList = new GoalTrack();
       // Console.WriteLine("Hello Develop05 World!");
        //List<int> points = new List<int>{};
        //int pointsCount = points.Sum(points[i]);
        Console.WriteLine("Welcome to the Goal Quest program.\n");
        int score = goalList.DisplayScore();
        //Console.WriteLine(score);
        Console.WriteLine("\nMenu Options:\n1.Create New Goal\n2.List Goals");
        Console.WriteLine("3.Save Goals\n4.Load Goals\n5.Record Goals\n6.Quit");
        Console.WriteLine("Select From the menu: ");

        int response = int.Parse(Console.ReadLine());
        
        while (response != 6)
        {
            if (response ==1)
            {
                Console.WriteLine("The types of goals are:\n1.Simple Goals\n2.Ethernal Goasl\n3.ChecklistGoals");
                Console.WriteLine("Which type of goal would you like to create?");
                int goalResponse = int.Parse(Console.ReadLine());
            
                if (goalResponse  == 1)
                {
                    SimpleGoal sGoal = new SimpleGoal();
                    sGoal.RecordEvent();
                    goalList.AddGoal(sGoal);
                    continue;

                }
                else if (goalResponse == 2)
                {
                    EthernalGoal eGoal = new EthernalGoal();
                    eGoal.RecordEvent();
                    goalList.AddGoal(eGoal);
                }
                else if (goalResponse == 3)
                {
                    ChecklistGoal cGoal = new ChecklistGoal();
                    cGoal.RecordEvent();
                    goalList.AddGoal(cGoal);
                }
                else
                {
                    Console.WriteLine("Not a valid choice.");
                }
            }
            else if(response == 2)
            {
                goalList.DisplayGoal();
            }
            else if(response ==3)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                outputFile.WriteLine($"{goalList.DisplayScore()}\n{goalList.DisplayGoal}");
            }
            else if(response == 4)
            {
                Console.WriteLine("What is the filename? ");
                string fileRead = Console.ReadLine();
                Console.WriteLine($"Displaying from file {fileRead}....\n ");
                
                string[] lines = System.IO.File.ReadAllLines(fileRead);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    Console.WriteLine();
                }
            }
             else if(response == 5)
            {
                Console.WriteLine("Which goal would you like to record? ");
                string goalN = Console.ReadLine();
                goalList.RecordGoal(goalN);
            }
            else
            {
                Console.WriteLine("Not a valid entery.");
            }

            //Console.WriteLine($"\nYou have {pointsCount} points.");
            Console.WriteLine("Menu Options:\n1.Create New Goal\n2.List Goals");
            Console.WriteLine("3.Save Goals\n4.Load Goals\n5.Record Goals\n5.Quit");
            Console.WriteLine("Select From the menu: ");
        }

        Console.Clear();
        Console.WriteLine("Good Bye!");

    }
}