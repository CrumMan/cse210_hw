using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Serialization;

namespace Mindfulness
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        protected void SetName(string name) { _name = name; }
        protected void Setdescription(string description) { _description = description; }
        protected void SetDuration(int duration) { _duration = duration; }

        protected string GetDescription()
        {
            return _description;
        }
        protected int GetDuration()
        {
            return _duration;
        }

        protected string GetName()
        {
            return _name;
        }
        protected void DisplayStartingMessage()
        {
            System.Console.WriteLine($"Welcome to the {GetName()} Activity! Prepare to Begin!");
            System.Console.WriteLine(GetDescription());
        }
        protected void DisplayEndingMessage()
        {
            System.Console.WriteLine("You have done a good Job");
            ShowSpinner(4);
            System.Console.WriteLine($"You Have completed a {GetName()} Activity");

        }
        public void ShowSpinner(int seconds)
        {
            for (int i = seconds; i >= 0; i--)
            {
                System.Console.Write('/');
                Thread.Sleep(166);
                Console.Write("\b \b\b\b \b\b");
                System.Console.Write("-");
                Thread.Sleep(166);
                Console.Write("\b \b\b\b \b\b");
                System.Console.Write("\\");
                Thread.Sleep(166);
                Console.Write("\b \b\b\b \b\b");
                System.Console.Write('/');
                Thread.Sleep(166);
                Console.Write("\b \b\b\b \b\b");
                System.Console.Write("-");
                Thread.Sleep(166);
                Console.Write("\b \b\b\b \b\b");
                System.Console.Write("\\");
                Thread.Sleep(170);
                Console.Write("\b \b\b \b\b \b");
            }
            Console.Clear();
        }
        protected void ShowCountdown(int time)
        {
            for (int i = time; i >= 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                if (i >= 10)
                {
                    Console.Write("\b\b");
                }
                if (i < 10)
                {
                    Console.Write("\b");

                }
            }
            Console.WriteLine();
        }
        protected int GetNumber(string input)
        {
            int choice;
            while (true)
            {
                if (int.TryParse(input, out choice))
                {
                    return choice;
                }
                else
                {
                    System.Console.WriteLine("Please enter a number");
                    input = Console.ReadLine();

                }
            }

        }
    }
}