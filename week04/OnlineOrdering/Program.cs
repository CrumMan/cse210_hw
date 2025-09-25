using System;
namespace onlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new();
            order.Setproducts();
            order.MakeShippingLabel("John Doe", "123 Seasame Street", "USA", "Arizona", "Tucson");
            order.MakeOrderLabel(23456);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            order = new();
            order.Setproducts();
            order.MakeShippingLabel("Sally Sue", "321 Street of sesamaes", "China", "Beijing", "Beijing");
            order.MakeOrderLabel(23456);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            order = new();
            order.Setproducts();
            order.MakeShippingLabel("Mary Lou", "231 Seasame St.", "United States", "Portsmouth", "Ohio");
            order.MakeOrderLabel(69420);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}