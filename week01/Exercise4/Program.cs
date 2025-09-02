using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numbersList = new List<int>();
        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        System.Console.Write("Enter number: ");
        string numberString = Console.ReadLine();
        if (numberString != "0")
        {
            while (number != 0)
            {
                if (int.TryParse(numberString, out number))
                {
                    if (number != 0)
                        numbersList.Add(number);
                    System.Console.Write("Enter number: ");
                    numberString = Console.ReadLine();
                    if (numberString == "0") { break; }
                }
                else
                {
                    System.Console.WriteLine("Enter a number");
                    System.Console.Write("Enter number: ");
                    numberString = Console.ReadLine();
                }
            }
            int sum = 0;
            int avg = 0;
            double largestNumber = -999999999999999999;
            double lpn = 999999999999999999;

            foreach (int n in numbersList)
            {
                sum += n;
                avg += n;
                if (largestNumber < n)
                {
                    largestNumber = n;
                }
                if (lpn > n && n > 0)
                {
                    lpn = n;
                }
            }
            string lpnstring = "";
            if (lpn == 999999999999999999) { lpnstring = "None smaller than 0 "; }
            else { lpnstring = $"{lpn}"; }

            List<int> sortedNumbers = numbersList;
            sortedNumbers.Sort();

            avg /= numbersList.Count;
            System.Console.WriteLine($"The sum is: {sum}");
            System.Console.WriteLine($"The average is: {avg}");
            System.Console.WriteLine($"The largest number is: {largestNumber}");
            System.Console.WriteLine($"The smallest positive number is {lpnstring}");
            System.Console.WriteLine("The Sorted list is: ");
            foreach (int n in sortedNumbers)
            {
                System.Console.WriteLine(n);
            }


        }
    }
}