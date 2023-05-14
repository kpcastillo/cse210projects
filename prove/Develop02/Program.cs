using System;
using System.IO;
using System.Collections.Generic;
partial class Program
{
        static void Main(string[] args)
    {
        Display myJournal = new Display();

        List<string> promptList = new List<string>{
                "What was the best part of your day?",
                "What was the one challenging part of your day?",
                "What is something you are thankfull for today?",
                "What made you feel the spirit today? ",    
                "What was your main goal for today?"                
            };
        List<string> scriptures = new List<string>{
                "Jeremiah 17:7 Blessed is the man that trusteth in the Lord, and whose hope the Lord is.",
                "Psalm 34:4 I sought the Lord, and he heard me, and delivered me from all my fears.",
                "Hebrews 11:1 Now faith is the substance of things hoped for, the evidence of things not seen.",
                "Romans 15:13 Now the God of hope fill you with all joy and peace in believing, that ye may abound in hope, through the power of the Holy Ghost.",    
                "Alma 36:3 Whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day."                
            };
    
        
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

        while (choice != 5)
        {
            if(choice == 1)
            //After writing an entry user will have a scripture displayed. This will be an encouraging scripture which will make two things: 
            //Make the writter feel good and encourage him/her to come back, and remind the writer to study the scriptures.
            {
                Random random = new Random(); 
                int index = random.Next(promptList.Count);
                string prompt = promptList[index];

                Console.WriteLine(prompt);

                Random randomScripture = new Random(); 
                int indexS = random.Next(scriptures.Count);
                string scripture = scriptures[indexS];

                NewEntry entry1 = new NewEntry();
                entry1._date = DateTime.Now.ToShortDateString();
                entry1._entry = Console.ReadLine();
                entry1._prompt = prompt;
                entry1._scripture = scripture;
                myJournal._entries.Add(entry1);

            //After writing an entry user will have a scripture displayed. This will be an encouraging scripture which will make two things: 
            //Make the writter feel good and encourage him/her to come back, and remind the writer to study the scriptures.
                Console.WriteLine("Thank you for your entry.\n");
                Console.WriteLine($"Your scripture of the day is: {scripture}");
                
            }
            else if (choice == 2)
            {
                Console.WriteLine("Displaying your journal entries: ");
                Console.WriteLine();
                
                myJournal.DisplayJournal();
                Console.WriteLine();

            }
            else if (choice ==3)
            {
                Console.WriteLine("What is the filename? ");
                string fileRead = Console.ReadLine();
                Console.WriteLine($"Displaying from file {fileRead}....\n ");
                
                

                string[] lines = System.IO.File.ReadAllLines(fileRead);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    Console.WriteLine();
                }

            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                Console.WriteLine($"Saving your journal into {fileName} file.\n");

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    
                    foreach(NewEntry entry in myJournal._entries){
                        outputFile.WriteLine(entry);

                    }
                                
                }
                
            }
            
            Console.WriteLine("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Good Bye!");

    }
}