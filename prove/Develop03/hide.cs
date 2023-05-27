using System;
public class HideWord{
    // Manipulate a single word inside the scripture sentence.
    private Reference _reference;
    private Scripture _scripture;
    public HideWord (){
    }
    public HideWord (Reference reference, Scripture scripture){
        scripture = _scripture;
        reference = _reference;
    }
    
    public void HideWordFromSentece (){
        

        Console.Clear();
        Console.WriteLine($"{_reference} {_scripture}");

        
       // Random random = new Random(); 
         //   int index = random.Next(wordsSplit.Length);
           // string words = wordsSplit[index];
                //string hiddenWord = words.Replace("_");
                //string hiddenWord = words.Insert(0, "_");
        
       
      //  while (scriptureLenght > 0){
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                return;
            
            

      //  }
        //if statement.

        // This will start by displaying "AAA" and waiting for the user to press the enter key
        //Console.WriteLine("AAA");
        //Console.ReadLine();

        // This will clear the console
        //Console.Clear();

        // This will show "BBB" in the console where "AAA" used to be
        //Console.WriteLine("BBB");
        
    }

    

}
