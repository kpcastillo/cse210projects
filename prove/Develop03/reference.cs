using System;
public class Reference{
    // Keeps track of the book, chapter, and verse information.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _secondVerse;
    // public Reference (string book, int chapter, int verse){

    // } 
    public Reference(){
        _book = "Hebrews";
        _chapter = 11;
        _verse = 1;
    }
    public Reference (string book, int chapter, int verse, int secondVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;

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



