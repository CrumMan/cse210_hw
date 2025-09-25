using System.Dynamic;

namespace onlineOrdering
{
    class Order
    {
        private int _orderNumber;
        private Customer _customer;
        private Product product;
        private List<Product> _products = new List<Product>();
        private double _shippingCost;
        public void MakeShippingLabel(string name, string street, string country, string state, string city)
        {
            System.Console.WriteLine("Shipping Label");
            _customer = new();
            _customer.SetName(name);
            _customer.ShippingLabel(street, country, state, city);
            SetShippingCost();
        }
        public void SetShippingCost()
        {
            if (_customer.GettLocal()) _shippingCost = 5.00;
            else _shippingCost = 35.00;
        }

        public void MakeOrderLabel(int i)
        {
            System.Console.WriteLine($"Order Label \nOrder Number: {GetOrderNumber(i)}\nProducts:");
            double finalTotal = 0;
            foreach (Product product in _products)
            {
                product.DisplayProductDetails();
                finalTotal += product.GetFinalTotal();
            }
            System.Console.WriteLine($"Shipping Cost:{GetShippingCost()}");
            System.Console.WriteLine($"Order Total:{finalTotal + GetShippingCost()}");
        }

        public void Setproducts()
        {
            Random random = new();
            int randomNumber = random.Next(1, 5);
            double randomPrice = 0;
            for (int i = 1; i <= randomNumber; i++)
            {
                float randomFloat = random.Next(1, 200);
                randomPrice = Math.Round(randomFloat, 2);
                product = new Product();
                product.SetValues(i, randomPrice);
                _products.Add(product);
            }
        }
        private int GetOrderNumber(int i)
        {
            return _orderNumber;
        }
        private double GetShippingCost()
        {
            return _shippingCost;
        }
    }
}