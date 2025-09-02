using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        System.Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        System.Console.WriteLine($"Your name is {firstName} {lastName}.");

    }
}