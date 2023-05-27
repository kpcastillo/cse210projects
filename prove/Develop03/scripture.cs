using System;
using System.Collections.Generic;
public class Scripture{
    private string _scripture; 
    public Scripture (){
    }
    public Scripture (string scripture){
        scripture = _scripture;
       
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

}