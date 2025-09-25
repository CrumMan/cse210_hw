using System.Dynamic;

namespace onlineOrdering
{
    class Product
    {
        int _productId;
        double _price;
        int _quantity;
        double _finalTotal;
        public void SetValues(int productId, double price)
        {
            Random random = new Random();
            _productId = productId;
            _price = price;
            _quantity = random.Next(1, 4);
            _finalTotal = price * _quantity;
        }
        private int GetProductId()
        {
            return _productId;
        }
        private int GetQuantity()
        {
            return _quantity;
        }


        public double GetFinalTotal()
        {
            return _finalTotal;
        }
        private double GetPrice()
        {
            return _price;
        }
        public void DisplayProductDetails()
        {
            System.Console.WriteLine($"Product ID: {GetProductId()} Price:{GetPrice()}  Quantity: {GetQuantity()}");
        }


    }
}