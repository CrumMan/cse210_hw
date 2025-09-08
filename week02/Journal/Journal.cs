using System.Diagnostics.Metrics;
using System.Text.Json;

namespace week02.Journal
{
    public class Journal
    {
        //instates the jornal list for manipulation in later methods.
        List<string> journalEntries = new List<string>();

        public void AddEntry(string _entry)
        {
            journalEntries.Add(_entry);
        }
        //display all the journal entries.
        public void DisplayAll()
        {
            int count = 1;
            foreach (string entry in journalEntries)
            {
                System.Console.WriteLine($"{count}:  {entry}");
                count++;
            }
        }
        //saves the journal entry to the JSON when called
        public void SaveToFile()
        {
            string jsonString = JsonSerializer.Serialize(journalEntries);
            File.WriteAllText("journalEntries.json", jsonString);
        }
        //Loads the json when called and puts it to the journal list. If the json is empty makes the list empty.
        public void LoadFromFile()
        {
            string filePath = "journalEntries.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                journalEntries = JsonSerializer.Deserialize<List<string>>(jsonString) ?? new List<string>();
            }
        }

        //deletes a singular entry after showing the user a list of all the entries.
        public void DeleteAnEntry()
        {
            DisplayAll();
            System.Console.WriteLine("What number entry would you like to delete?");
            string entryS = Console.ReadLine();
            bool entryBool = int.TryParse(entryS, out int entry);
            try
            {
                journalEntries.RemoveAt(entry - 1);
            }
            catch { }
        }
        //deletes all the entries in the journal class when called.
        public void DeleteAllEntries()
        {
            journalEntries.Clear();
        }

    }
}