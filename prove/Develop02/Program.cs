using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> promptList = new List<string>{
                "What was the best part of your day?",
                "What was the one challenging part of your day?",
                "What is something you are thankfull for today?",
                "Chicago"                    
            };
    
        Random random = new Random(); 
        int index = random.Next(promptList.Count);
        string prompt = promptList[index];

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
            //Write a new entry - Show the user a random prompt (from a list that you create), 
            //and save their response, the prompt, and the date as an Entry.
            {
                //Console.WriteLine(promptList[index]);
                Console.WriteLine(prompt);

                NewEntry entry1 = new NewEntry();
                entry1._date = DateTime.Now.ToShortDateString();
                entry1._entry = Console.ReadLine();
                entry1._prompt = prompt;
            }
            else if (choice == 2)
            //Display the journal - Iterate through all entries in the journal
            // and display them to the screen.
            {
                Console.WriteLine("Displaying yoye journal entries: ");
                Console.WriteLine();
                Display myJournal = new Display();
                //myJournal._entry.Add(entry1);
                myJournal.DisplayJournal();

            }
            else if (choice ==3)
            //Load the journal from a file - Prompt the user for a filename and then load the journal 
            //(a complete list of entries) from that file. This should replace any entries currently stored the journal.
            {
                Console.WriteLine("What is the filename? ");
                string fileRead = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileRead);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(".");

                    string date = parts[0];
                    string prmpt = parts[1];
                    string entry = parts[1];
                }

            }
            else if (choice == 4)
            //Save the journal to a file - Prompt the user for a filename and then save the current journal 
            //(the complete list of entries) to that file location.
            
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {

                    outputFile.WriteLine();
                    
                }
                
            }
            
            Console.WriteLine("What would you like to do? ");
            choice = Console.Read();

        }

    }
}