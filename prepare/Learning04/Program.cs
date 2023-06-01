using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assigment assigment1 = new Assigment("Samuel Bannet", "Multoplication");
        Console.WriteLine(assigment1.GetSummary());

        MathAssigment math1 = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssigment writ1 = new WritingAssigment("Mary Walters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writ1.GetWritingInfo());

    }
}