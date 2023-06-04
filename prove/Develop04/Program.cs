using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindful program\n choose friom the menu");
        Console.WriteLine("1. Breathing activity.");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3.Listing activity");
        Console.WriteLine("4.Quit.");
        string input = (Console.ReadLine());
        int userInput = int.Parse(input);

        while (userInput != 4){

            if (userInput == 1){
                continue;

            }
            else if(userInput == 2){
                continue;
            }
            else if(userInput == 3){
                continue;
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