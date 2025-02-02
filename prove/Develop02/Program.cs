using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string choice = "";
        bool done = false;
       if (new FileInfo("journalbook.txt").Length != 0)
        {
            journal.loadEntries();
        } 
        while (!done)
        {
            Menu.DisplayMenu();
            Console.Write("Enter a number: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.addEntry();
            } else if (choice == "2")
            {
                journal.saveEntries();
                Console.WriteLine("Entries saved.");
            } else if (choice == "3")
            {
                journal.displayJournal();
            } else if (choice == "4")
            {   
                if (journal._changed)
                {
                    Console.Write("You have unsaved changes. Do you want to save before exiting? (y/n): ");
                    string response = Console.ReadLine();
                    if (response == "y")
                    {   
                        journal.saveEntries();
                    }
                }
                done = true;
            } else
            {
            Console.WriteLine("Invalid choice. Please try again.");
            }

        }
        
    }
    
}