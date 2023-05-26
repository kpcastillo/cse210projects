using System;
using System.Collections.Generic;
public class Scripture{
    // Keep track of the reference and text of the scripture.
    //Can Hide words and get the rendered display of the text.
    private string _scripture; 
    private Reference _reference; 
    public Scripture (){
    }
    public Scripture (Reference reference, string scripture){
        reference = _reference;
        scripture = _scripture;
       
    }

    
    private void HideWords (){
        string scripture = _scripture;
        string[] wordsSplit = scripture.Split(" ");
        int scriptureLenght = wordsSplit.Length;

        Random random = new Random(); 
            int index = random.Next(wordsSplit.Length);
            string words = wordsSplit[index];
                //string hiddenWord = words.Replace("_");
                //string hiddenWord = words.Insert(0, "_");
        for (int i = 0; i < scriptureLenght; i++){

        }

    } 
    public void Display (){

    }

}