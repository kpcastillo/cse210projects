using System;
public class HideWord{
    // Manipulate a single word inside the scripture sentence.
    private Reference _reference;
    private Scripture _scripture;
    public HideWord (){
    }
    public HideWord (Reference reference, Scripture scripture){
        _scripture = scripture;
        _reference = reference;
    }
    public void HideWordFromSentece (){

        Scripture hideScripture = new Scripture();
        _scripture = hideScripture;
        string[] words = hideScripture.stringToList();
        int sLenght = hideScripture.wordCount();
        
       Random random = new Random(); 
                //string hiddenWord = words.Replace("_");
        
       
        while (sLenght > 0){
            Console.Clear();
            Console.WriteLine($"{_reference} {hideScripture}");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            int wordsToHide = random.Next(1, sLenght + 1);
            string [] wordsHidden = new string[sLenght];
            for (int i = 0; i < sLenght; i++){
                if ( i < wordsToHide)
                    wordsHidden[i] = "_____";
                else
                    wordsHidden[i] = words[i - wordsToHide];
            }  

       }
        
    }

    

}
