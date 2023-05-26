using System;
public class Reference{
    // Keeps track of the book, chapter, and verse information.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _secondVerse;
    public Reference (string book, int chapter, int verse){

    } 
    public Reference (string book, int chapter, int verse, int secondVerse){
        book = _book;
        chapter = _chapter;
        verse = _verse;
        secondVerse = _secondVerse;

    }
    public void GetReference(){
        if (_secondVerse == 0){
            Console.WriteLine($"{_book}, {_chapter}:{_verse}.");

        }
        else{
            Console.WriteLine($"{_book}, {_chapter}:{_verse}-{_secondVerse}.");
        }
    

        
    }


}



