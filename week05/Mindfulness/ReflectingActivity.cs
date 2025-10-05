namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        List<string> _prompts = new List<string>
        {
        "Think of a time you faced a challenge and overcame it.",
        "Whats a recent accomplishment you’re proud of?",
        "Recall a moment when you helped someone or made a positive impact.",
        "Describe a time you stepped outside your comfort zone.",
        "Whats a small win you’ve had this week?",
        "When have you shown resilience in the past month?",
        "Think of a time you stayed committed to a goal despite difficulties.",
        "Whats a personal strength you’ve relied on recently?",
        "Recall a moment you learned something important about yourself.",
        "Describe a time you turned a setback into an opportunity.",
        "Whats something hard you did this week?",
        "Think of a time you did something difficult.",
        "What challenge did you overcome recently?",
        "When have you felt proud of your growth?",
        "Recall a time you made a difference for someone."
        };
        List<string> _questions = new List<string>
        {
            "How did it make you feel?",
            "Why did you do it?",
            "What was the hardest part?",
            "Who supported you, and how did they help?",
            "What did you learn from this experience?",
            "How would you approach a similar situation differently next time?",
            "What strengths or skills did you use?",
            "How has this experience shaped you?",
            "What would you tell someone else going through the same thing?",
            "How can you build on this experience moving forward?",
            "What small action could you take today to keep improving?",
            "What lessons can you take from this for the future?",
            "How can you apply this experience to other areas of your life?",
            "What surprised you about this experience?",
            "What motivated you to keep going in this situation?"

        };
        private Random _random = new Random();
        private List<string> GetPrompts()
        {
            return _prompts;
        }
        private List<string> GetQuestions()
        {
            return _questions;
        }
        private Random GetRandom()
        {
            return _random;
        }
        public ReflectingActivity() { }
        public ReflectingActivity(string name)
        {
            SetName(name);
            Setdescription("You will be answering as many follow up questions as you can after answering the prompt.");
            DisplayStartingMessage();
            Thread.Sleep(5000);
            System.Console.WriteLine("How Long would you like to Reflect? (Seconds)");
            int input = GetNumber(Console.ReadLine());
            ShowSpinner(3);
            Run(input);
            DisplayEndingMessage();
        }

        private void Run(int input)
        {
            System.Console.WriteLine($"-------{GetRandomPrompt()}-------");
            Console.WriteLine("Answer");
            System.Console.ReadLine();
            System.Console.WriteLine("Answer as many of the followup questions as possible:");
            ShowCountdown(5);
            int runQuestions = RunQuestions(input);
            Console.Clear();
            System.Console.WriteLine($"Congragulations! You have answered {runQuestions} question!");
        }
        private string GetRandomQuestion()
        {
            List<string> questions = GetQuestions();
            Random rq = GetRandom();
            string randomQuestion = questions[rq.Next(0, questions.Count)];
            return randomQuestion;
        }
        private string GetRandomPrompt()
        {
            List<string> prompts = GetPrompts();
            Random rp = GetRandom();
            string randomPrompt = prompts[rp.Next(0, prompts.Count)];
            return randomPrompt;
        }
        private int RunQuestions(int input)
        {
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
                Console.WriteLine();
                Console.WriteLine($"\n{GetRandomQuestion()}");
                Console.ReadLine();
                count++;
            }
            while (!timeExpired);

            return count;
        }

    }
}