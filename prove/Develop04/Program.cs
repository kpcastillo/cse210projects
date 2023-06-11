using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindful program\nChoose from the menu");
        Console.WriteLine("1. Breathing activity.");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3.Listing activity");
        Console.WriteLine("4.Quit.");
        string input = (Console.ReadLine());
        int userInput = int.Parse(input);

        while (userInput != 4){

            if (userInput == 1){
                BreathingActivity breath = new BreathingActivity();
                breath.DisplayBreathingAct();

            }
            else if(userInput == 2){
                ReflectionActivity reflection1 = new ReflectionActivity();
                reflection1.DisplayReflection();
            }
            else if(userInput == 3){
                ListingActivity listing1 = new ListingActivity();
                listing1.DisplayListing();
            }
            else{
                Console.WriteLine("Not a valid coice");
            }
            Console.WriteLine("Choose friom the menu: ");
            Console.WriteLine("1. Breathing activity.");
            Console.WriteLine("2. Reflection activity.");
            Console.WriteLine("3.Listing activity.");
            Console.WriteLine("4.Quit.");
            input = (Console.ReadLine());
            userInput = int.Parse(input);

        }
        Console.WriteLine("Thank you for using the mindful program.");

    }
}