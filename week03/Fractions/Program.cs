using System;
namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionC fraction = new();
            fraction.Fraction(1);
            System.Console.WriteLine(fraction.getFractionString());
            System.Console.WriteLine(fraction.getDecimalValue());

            fraction.Fraction(5);
            System.Console.WriteLine(fraction.getFractionString());
            System.Console.WriteLine(fraction.getDecimalValue());

            fraction.Fraction(3, 4);
            System.Console.WriteLine(fraction.getFractionString());
            System.Console.WriteLine(fraction.getDecimalValue());

            fraction.Fraction(1, 3);
            System.Console.WriteLine(fraction.getFractionString());
            System.Console.WriteLine(fraction.getDecimalValue());
        }
    }
}