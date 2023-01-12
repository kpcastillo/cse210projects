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

           


        static void DisplayWelcome()
            {
                Console.WriteLine("Welcoe to the program");
            }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter yur favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int sqrNumber)
        {
             Console.WriteLine($"{name} the square of your favorite number is {sqrNumber}");
        }


    }
}