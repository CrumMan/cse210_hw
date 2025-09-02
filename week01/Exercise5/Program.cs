using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayResult();
    }
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        System.Console.Write("Please enter your faveroite number: ");
        string numS = Console.ReadLine();
        while (true)
        {
            if (int.TryParse(numS, out int num))
            {
                return num;
            }
            else
            {
                System.Console.Write("Please enter your faveroite number: ");
                numS = Console.ReadLine();
            }
        }
    }
    static double SquareNumber(int num)
    {
        double numsqrt = num * num;
        return numsqrt;
    }
    static void DisplayResult()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        double userNumberSQRT = SquareNumber(userNumber);
        System.Console.WriteLine($"{name}, the square of your number is {userNumberSQRT}");
    }
}