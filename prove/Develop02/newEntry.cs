using System;

    public class NewEntry
    {
        public string _date;

        public string _entry;

        public string _prompt;

        public void ShowDateAndEntry()
        {

            Console.WriteLine($"{_date} | {_prompt} | {_entry}");
        }
    }