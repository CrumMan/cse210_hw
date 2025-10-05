using System;
namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            BreathingActivity breathingActivity = new();
            ReflectingActivity reflectingActivity = new();
            ListingActivity listingActivity = new();
            int count = 0;
            int choice = 9999;
            string input = "";
            System.Console.WriteLine("Welcome to our mindfullness app!");
            while (choice != 0)
            {

                System.Console.Clear();
                System.Console.WriteLine("Choose one of the following:\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n Enter 0 to exit");
                input = Console.ReadLine();
                bool isNum = int.TryParse(input, out choice);
                if (!isNum) { System.Console.WriteLine("Please enter a number"); }
                else
                {
                    if (choice == 1)
                    {
                        breathingActivity = new("Breathing");
                    }
                    else if (choice == 2)
                    {
                        reflectingActivity = new("Reflecting");
                    }
                    else if (choice == 3)
                    {
                        listingActivity = new("Listing");
                    }
                    count++;
                }
                if (count > 1)
                {
                    System.Console.WriteLine($"You have completed {count} Activities! (Press any key to continue)");
                    System.Console.ReadKey();
                }
                else if (count == 1)
                {
                    System.Console.WriteLine($"You have completed {count} Activity! (Press any key to continue)");
                    System.Console.ReadKey();
                }
            }
        }
    }
}