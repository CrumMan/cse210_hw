using System;
using System.ComponentModel.Design;
using week02.Journal;

class Program
{
    static void Main(string[] args)
    {
        //instilize Journal and variables
        Entry entry = new Entry();
        Journal journal = new();
        journal.LoadFromFile();
        string input = "";
        while (input != "0")
        {
            MenuSelection();
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    System.Console.WriteLine("Yould you like a prompt? (y/n)");
                    //ask for an entry and enter the entry
                    string aff = Console.ReadLine().ToLower();
                    if (aff == "y") entry.GetRandomPrompt();
                    else entry._promptText = "";
                    System.Console.WriteLine("Entry:");
                    entry.GatherInfo();
                    entry.Display();
                    System.Console.WriteLine();
                    //add to the journal list
                    System.Console.WriteLine("Would you like to add this entry to your Journal?(y/n)");
                    aff = Console.ReadLine();
                    if (aff == "y") journal.AddEntry(entry._entry);
                    break;
                case "2":
                    System.Console.WriteLine("Displaying all Journal Entries");
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.DeleteAnEntry();
                    break;
                case "4":
                    System.Console.WriteLine("Are you sure you want to delete all your entries? (y/n)");
                    aff = Console.ReadLine();
                    if (aff == "y") journal.DeleteAllEntries();
                    break;
                case "0":
                    journal.SaveToFile();
                    break;

            }
            System.Console.WriteLine();
            System.Console.WriteLine(); ;
        }
    }
    public static void MenuSelection()
    {
        Console.WriteLine(" Select an option:\r \n 1: Add an entry\r \n 2: View all entries\r \n 3:Delete Journal Entry \r\n 4: Clear Entries \r \n 0: Exit Journal and save");
    }
}