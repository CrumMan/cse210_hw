using System.Text.RegularExpressions;

namespace week02.Journal
{
    public class Entry
    {
        PromptGenerator prompt = new();
        string _date = "";
        //make prompt text
        public string _promptText = "";

        string _entryText = "";
        public string _entry = "";
        public void GatherInfo()
        {
            _date = DateTime.Now.ToString("MM/dd/yyy");
            System.Console.WriteLine("Entry:");
            _entryText = Console.ReadLine();
            if (_promptText != "") _entry = $"{_date}: {_promptText} {_entryText}";
            else _entry = $"{_date}: {_entryText}";
        }
        public void GetRandomPrompt()
        {
            _promptText = prompt.GetRandomPrompt();
            System.Console.WriteLine(_promptText);

        }
        public void Display()
        {
            System.Console.WriteLine(_entry);
        }

    }
}