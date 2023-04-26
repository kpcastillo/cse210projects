using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        string name = PromptUserName();

        int favNumber = PromptUserNumber();

        int squareNum = SquareNumber(favNumber);

        DisplayResult(name, squareNum);
           

        //Displays the message  
        static void DisplayWelcome()
        {
                Console.WriteLine("Welcoe to the program");
        }

        //Asks for and returns user name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        //Asks for and returns user favorite number
        static int PromptUserNumber()
        {
            Console.Write("Please enter yur favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        //Accepts an integer as a parameter and returns that number square
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        //Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int sqrNumber)
        {
            Console.WriteLine($"{name} the square of your favorite number is {sqrNumber}");
        }


    }
}