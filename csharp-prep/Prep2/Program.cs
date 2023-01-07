using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int userGrade = int.Parse(Console.ReadLine());

        string letter = "";

        if (userGrade > 90 || userGrade == 90)
        {
            letter = "A";
    
        }
        else if(userGrade > 80 || userGrade == 80)
        {
            letter = "B";
        }
         else if(userGrade > 70 || userGrade == 70)
        {
            letter = "C";
        }
         else if(userGrade > 60 || userGrade == 60)
        {
            letter = "D";
        }
         else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (userGrade > 70)
        {
            Console.WriteLine("Congratulations you passed!!!");
        }
        else
        {
            Console.WriteLine("You did not pass, better luck next time.");
        }


    }
}