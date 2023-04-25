using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, Type 0 when finished.");
        
    //declaring the new list
        List<int> numbers = new List<int>();

        int  userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber !=0)
            {
            numbers.Add(userNumber);
            }
           
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float avarage = ((float)sum)/numbers.Count;
        Console.WriteLine($"The avarage is: {avarage}");

        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The max number is {maxNumber}");
    }
}