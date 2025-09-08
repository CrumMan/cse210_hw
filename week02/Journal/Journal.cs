using System.Diagnostics.Metrics;
using System.Text.Json;

namespace week02.Journal
{
    public class Journal
    {
        List<string> journalEntries = new List<string>();

        public void AddEntry(string _entry)
        {
            journalEntries.Add(_entry);
        }
        public void DisplayAll()
        {
            int count = 1;
            foreach (string entry in journalEntries)
            {
                System.Console.WriteLine($"{count}:  {entry}");
                count++;
            }
        }
        public void SaveToFile()
        {
            string jsonString = JsonSerializer.Serialize(journalEntries);
            File.WriteAllText("journalEntries.json", jsonString);
        }
        public void LoadFromFile()
        {
            string filePath = "journalEntries.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                journalEntries = JsonSerializer.Deserialize<List<string>>(jsonString) ?? new List<string>();
            }
        }
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
        public void DeleteAllEntries()
        {
            journalEntries.Clear();
        }

    }
}