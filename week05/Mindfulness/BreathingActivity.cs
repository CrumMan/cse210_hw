namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() { }
        public BreathingActivity(string name)
        {
            SetName(name);
            Setdescription("This activity will help you through breathing in and out Slowly. Clear your mind and focus on your breathing.");
            DisplayStartingMessage();
            Thread.Sleep(5000);
            ShowSpinner(2);
            System.Console.WriteLine("How long would you like your session in seconds?");
            int input = GetNumber(Console.ReadLine());
            SetDuration(input);
            Run();
            DisplayEndingMessage();
            Console.ReadKey();

        }
        private void Run()
        {
            System.Console.WriteLine($"How many Rounds would you like to have in this {GetDuration()} second long exercize?");
            int NumberOfRounds = GetNumber(Console.ReadLine());
            ShowSpinner(3);
            System.Console.Clear();
            double decimalNumber;
            int IntervalTime = (int)Math.Round((double)GetDuration() / NumberOfRounds, 0);
            decimalNumber = IntervalTime * (2.0 / 3.0);
            int twoThirds = (int)Math.Floor(decimalNumber);
            decimalNumber = IntervalTime * (1.0 / 3.0);
            int oneThird = (int)Math.Ceiling(decimalNumber);
            System.Console.Clear();

            for (int i = NumberOfRounds; i > 0; i--)
            {
                System.Console.WriteLine($"Breathe In...");
                ShowCountdown(oneThird);
                System.Console.WriteLine($"Breathe Out...");
                ShowCountdown(twoThirds);

            }
            Console.Clear();



        }
    }
}