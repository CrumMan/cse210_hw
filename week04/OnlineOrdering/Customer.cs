using System.Dynamic;

namespace onlineOrdering
{
    class Customer
    {
        private string _name;
        private Address address = new();
        public void SetAddress(string street, string country, string state, string city)
        {
            address.SetCountry(country);
            address.SetStreet(street);
            address.SetCity(city);
            address.SetState(state);
            address.SetAddress();
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public void GetAddress()
        {
            address.GetAddress();
        }
        public bool GettLocal()
        {
            return address.GetLocal();
        }
        public void ShippingLabel(string street, string country, string state, string city)
        {
            SetAddress(street, country, state, city);
            System.Console.WriteLine($"Name: {_name} \n Address: {address.GetAddress()}");
        }


    }
}