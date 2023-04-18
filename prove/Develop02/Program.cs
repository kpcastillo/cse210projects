using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        int choice = Console.Read();

        while (choice != 5)
        {
            if(choice == 1)
            {
                NewEntry entry1 = new NewEntry();
                entry1._date = DateTime.Now;
                entry1._entry = Console.ReadLine();
            }
            else if (choice == 2)
            {

            }
            else if (choice ==3)
            {

            }
            else if (choice == 4)
            {

            }
            Console.WriteLine("What would you like to do? ");
            choice = Console.Read();
        }

    }
}