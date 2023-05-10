using System;

    public class Display
    {
        public List<NewEntry> _entries = new List<NewEntry>(); 

        public void DisplayJournal()
        {
            Console.WriteLine("Displaying your Journal.");

            foreach(NewEntry entry in _entries)
            {
                entry.ShowDateAndEntry();
            }
        }




    }