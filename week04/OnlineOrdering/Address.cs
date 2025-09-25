using System.Dynamic;

namespace onlineOrdering
{
    class Address
    {
        private string _address;
        private string _street;
        private string _city;
        private string _state;
        private string _country;
        private bool _local;

        public void SetStreet(string street)
        {
            _street = street;
        }
        public void SetCity(string city)
        {
            _city = city;
        }
        public void SetCountry(string country)
        {
            _country = country;
        }
        public void SetLocal()
        {
            string country = GetCountry();
            if (country.ToLower() == "usa" || country.ToLower() == "us" || country.ToLower() == "united states" || country.ToLower() == "united states of america") _local = true;
            else _local = false;
        }
        public void SetState(string state)
        {
            state = _state;
        }
        public void SetAddress()
        {
            _address = $"{GetStreet()}\n {GetCity()} {GetState()}, {GetCountry()}";
        }
        public bool GetLocal()
        {
            return _local;
        }
        private string GetCity()
        {
            return _city;
        }
        private string GetCountry()
        {
            return _country;
        }
        private string GetState()
        {
            return _state;
        }
        private string GetStreet()
        {
            return _street;
        }
        public string GetAddress()
        {
            return _address;
        }
    }
}