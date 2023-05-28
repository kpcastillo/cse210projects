using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer program");
        
        Reference ref1 = new Reference("Hebrews", 11, 1);
        Scripture scr1 = new Scripture ("eNow faith is the substance of things hoped for, the evidence of things not seen");
        HideWord refAndScrip = new HideWord(ref1, scr1);
        // HideWord refAndScrip = new HideWord();
        // refAndScrip._reference = ref1;
        // refAndScrip._scripture = scr1;

        refAndScrip.HideWordFromSentece();



    }
}