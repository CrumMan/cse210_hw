using System.ComponentModel;
using System.Text.RegularExpressions;

namespace week02.Journal
{
    public class Entry
    {
        //creates a prompt instance cause this is the only class that accesses the prompt generatoe
        PromptGenerator prompt = new();
        //make prompt text
        string _date = "";
        public string _promptText = "";

        string _entryText = "";
        public string _entry = "";
        public void GatherInfo()
        {
            //instate the entry instance variables except prompt.
            _date = DateTime.Now.ToString("MM/dd/yyy");
            System.Console.WriteLine("Entry:");
            _entryText = Console.ReadLine();
            //one line if else statement makes the entry variable dependant on if the propt variable is present.(tetrary statement could possibly be used here but I chose not to to make my mind understand it better)
            if (_promptText != "") _entry = $"{_date}: {_promptText} {_entryText}";
            else _entry = $"{_date}: {_entryText}";
        }
        //instate the random prompt variable when needed.
        public void GetRandomPrompt()
        {
            _promptText = prompt.GetRandomPrompt();
            System.Console.WriteLine(_promptText);

        }
        //displays the current entry that is in the temp file.
        public void Display()
        {
            System.Console.WriteLine(_entry);
        }

    }
}