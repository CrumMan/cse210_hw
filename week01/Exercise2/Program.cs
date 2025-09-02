using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        bool passed = false;
        string Letter = "";
        string message = "";
        System.Console.Write("Enter the number grade you got: ");
        string stringEntered = Console.ReadLine();
        if (int.TryParse(stringEntered, out int enteredNumber))
        {
            if (enteredNumber >= 90)
            {
                Letter = "A";
            }
            else if (enteredNumber >= 80)
            {
                Letter = "B";
            }
            else if (enteredNumber >= 70)
            {
                Letter = "C";
            }
            else if (enteredNumber >= 60)
            {
                Letter = "D";
            }
            else
            {
                Letter = "F";
            }
            if (enteredNumber >= 70)
            {
                passed = true;
            }
            int lastNumber = enteredNumber % 10;
            if (lastNumber >= 7)
            {
                Letter += "+";
            }
            else if (enteredNumber <= 3)
            {
                Letter += "-";
            }
            if (passed)
            {
                message = $"You passed with a {enteredNumber} receiving a {Letter}";
            }
            else
            {
                message = $"You did not pass with a {enteredNumber}";
            }

        }
        else
        {
            message = "You did not enter a number.";
        }
        System.Console.WriteLine(message);
    }
}