using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNum = int.Parse(Console.ReadLine());

        Random RandomGenerator = new Random();
        int magicNum = RandomGenerator.Next(1,101);


        Console.Write("Would you like to play? ");
        string userAnswear = Console.ReadLine();

        while (userAnswear == "yes")
        {
            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());

            while (userGuess != magicNum)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > magicNum)
                {
                    Console.WriteLine("Guess Lower! ");
                }
                else if (userGuess < magicNum)
                {
                    Console.WriteLine("Guess Higher!");
                }
                else 
                {
                    Console.WriteLine("You guessed it! ");
                }
            }
            Console.Write("Would you like to play? ");
            userAnswear = Console.ReadLine();

           //  for (int i = userGuess; i>1; i++)
            //{
            //    Console.WriteLine(i);
            //}
        }

    
         
    }
}