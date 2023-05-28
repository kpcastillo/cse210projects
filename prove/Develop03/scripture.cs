using System;
using System.Collections.Generic;
public class Scripture{
    private string _scripture; 
    public Scripture (){
        _scripture = "Now faith is the substance of things hoped for, the evidence of things not seen";
    }
    public Scripture (string scripture){
        _scripture = scripture;
       
    }
    public string[] stringToList (){
      
        string scripture = _scripture;
        string[] wordsSplit = _scripture.Split(" ");
        return wordsSplit;
    }
    public int wordCount(){
        int scriptureLenght = stringToList().Length;
        return scriptureLenght;
    }

    // public void DisplayScripture(){
    //     string[] scripToHide = stringToList();
    //     int lenght = wordCount();
        
    // }
}