using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Scripture_Memorizer
{
    public class Words
    {
        private Scripture scripture;
        private Random random = new();
        private string[] _words;
        private string _origionalWords;
        private List<int> _blanks = new List<int>();
        private bool memorized = false;

        public void SetOrigionalWords()
        {
            string text = scripture.GetScripture();
            text = Regex.Replace(text, @"[^\w\s]", "");
            _origionalWords = string.Join(" ", text.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        }
        public List<int> GetBlanks()
        {
            return _blanks;
        }
        public void AddToBlanks(int randomIndex)
        {
            _blanks.Add(randomIndex);
        }
        public string GetOrigionalWords()
        {
            return _origionalWords;
        }
        public void reset()
        {
            _blanks.Clear();
            _words = null;
            _origionalWords = null;
            memorized = false;
        }
        public void SetMemorizedToTrue()
        {
            memorized = true;
        }
        public void SetWords()
        {
            _words = GetOrigionalWords().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
        public bool Getmemorized()
        {
            return memorized;
        }
        public void MemorizeAScripture()
        {
            reset();
            scripture = new Scripture();
            SetOrigionalWords();
            SetWords();
            Memorize();
        }
        public string[] GetWords()
        {
            return _words;
        }
        public Words()
        {
            string input = "0";
            while (input == "0")
            {
                MemorizeAScripture();
                input = Console.ReadLine();
            }
        }

        public void Memorize()
        {
            string input = "";
            int numberOfBlanksAGo = 0;
            while (numberOfBlanksAGo <= 0 || numberOfBlanksAGo > GetWords().Length)
            {
                numberOfBlanksAGo = scripture.ParseToInt("number of words you’d like to blank out.");
                if (numberOfBlanksAGo > GetWords().Length)
                {
                    Console.WriteLine($"You entered a number that is too large. Maximum words in this scripture: {GetWords().Length}");
                    ;
                }
            }
            while (!Getmemorized() && input != "quit")
            {
                System.Console.Clear();
                Console.WriteLine(scripture.Ref());
                input = EveryItteration(numberOfBlanksAGo);
                if (GetBlanks().Count >= GetWords().Length)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(scripture.Ref());
                    input = EveryItteration(numberOfBlanksAGo);
                    SetMemorizedToTrue();
                }
                if (input == "quit")
                {
                    break;
                }
            }
            if (Getmemorized())
            {
                System.Console.WriteLine($"Congragulations you have memorized {scripture.Ref()}");
            }
            System.Console.WriteLine("Have a good day or press 0 to replay!");
        }
        public string EveryItteration(int numberOfBlanksAGo)
        {
            string input;
            while (true)
            {
                DisplayWords();
                System.Console.WriteLine("\n\nPlease enter the full scripture. (or type quit to quit)");
                input = Console.ReadLine()?.ToLower();
                if (input == "quit")
                {
                    return input;
                }
                if (input == GetOrigionalWords().ToLower())
                {
                    for (int i = 0; i < numberOfBlanksAGo; i++)
                    {
                        BlankRandomWord();
                    }
                    break;
                }
            }
            return input;
        }
        public void BlankRandomWord()
        {
            if (GetBlanks().Count >= GetWords().Length) return;
            int randomIndex;
            do
            {
                randomIndex = random.Next(0, GetWords().Length);
            }
            while (GetBlanks().Contains(randomIndex));
            GetWords()[randomIndex] = " ____ ";
            AddToBlanks(randomIndex);

        }
        public void DisplayWords()
        {
            foreach (string word in GetWords())
            {
                System.Console.Write($"{word} ");
            }
        }

    }
}