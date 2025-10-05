namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        //prompts and questions were generarted by GPT and input by me
        List<string> _prompts = new List<string>
        {
            "When have I felt the Holy Spirit in the last month?",
            "What blessings have I received this week?",
            "When did I feel closest to God recently?",
            "What prayers of mine have been answered?",
            "When have I felt true peace?",
            "What small miracles have I noticed in my life?",
            "When have I felt grateful today?",
            "What moments reminded me of God’s love?",
            "When have I shown kindness to others?",
            "What scripture has stood out to me recently?",
            "When have I felt guided in a decision?",
            "What trials have helped me grow stronger?",
            "When have I felt joy in serving others?",
            "What are three things I can thank God for today?",
            "When did I last feel inspired to do good?"
        };
        private List<string> GetPrompts()
        {
            return _prompts;
        }
        private string GetPrompt()
        {
            List<string> prompts = GetPrompts();
            Random random = new();
            int randomNum = random.Next(0, prompts.Count);
            return prompts[randomNum];

        }

        public ListingActivity() { }
        public ListingActivity(string name)
        {
            SetName(name);
            Setdescription("You will be listing ways you have experienced the following prompt.");
            DisplayStartingMessage();
            Thread.Sleep(5000);
            System.Console.WriteLine("How long would you like to do this Listing Activity? (Seconds)");
            int input = GetNumber(Console.ReadLine());
            Run(input);
            DisplayEndingMessage();
        }
        private void Run(int input)
        {
            string prompt = GetPrompt();
            System.Console.WriteLine(prompt);
            System.Console.Write("Get Ready...");
            ShowCountdown(5);
            bool timeExpired = false;
            int count = 0;
            int seconds = input * 1000;
            //learned about thread manipulation through Claude
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(seconds);
                timeExpired = true;
            });
            thread.Start();
            do
            {
                Console.ReadLine();
                count++;
            }
            while (!timeExpired);
            System.Console.WriteLine($"You have experienced {prompt}: {count} time(s)!");

        }
    }
}