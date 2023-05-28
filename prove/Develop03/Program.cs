using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer program");

        Reference ref1 = new Reference();
        Scripture scr1 = new Scripture ();
        HideWord refAndScrip = new HideWord(ref1, scr1);

        refAndScrip.HideWordFromSentece();



    }
}