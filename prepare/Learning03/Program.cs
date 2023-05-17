using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction firstCost = new Fraction();
        Fraction secondConst = new Fraction(6);
        Fraction thirdConst = new Fraction(6,7);

        Console.WriteLine(firstCost.GetFractionString());
        Console.WriteLine(firstCost.GetDecimalValue());

        Console.WriteLine(secondConst.GetFractionString());
        Console.WriteLine(secondConst.GetDecimalValue());

        Console.WriteLine(thirdConst.GetFractionString());
        Console.WriteLine(thirdConst.GetDecimalValue());



    }
    
}