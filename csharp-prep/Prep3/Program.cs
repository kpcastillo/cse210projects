using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNum = int.Parse(Console.ReadLine());
        //Console.Write("What is your guess? ");
        //int userGuess = int.Parse(Console.ReadLine());

        Random RandomGenerator = new Random();
        int magicNum = RandomGenerator.Next(1,101);

        int userGuess = -1;

        while (!(userGuess == magicNum))

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
        
        for (int i = userGuess; i>1; i++)
        {
            Console.WriteLine(i);
        }
        


    }
}