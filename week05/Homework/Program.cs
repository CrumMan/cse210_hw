using System;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAssignment StudentAssignment1 = new MathAssignment("Roberto Rodreguez", "Fractions", "7.3", "8-19");
            Console.WriteLine("\n\n");
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
            Console.WriteLine("\n\n");

        }
    }
}