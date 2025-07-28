namespace DesignPatternsDemo.BuilderDP
{
    public class AddressBuilder
    {
        private string _street = string.Empty;
        private string _city = string.Empty;
        private string _state = string.Empty;
        private string _zipCode = string.Empty;

        private AddressBuilder()
        {
        }
        public static AddressBuilder CreateAddressBuilder()
        {
            return new AddressBuilder();
        }
        public AddressBuilder SetStreet(string street)
        {
            _street = street;
            return this;
        }
        public AddressBuilder SetCity(string city)
        {
            _city = city;
            return this;
        }
        public AddressBuilder SetState(string state)
        {
            _state = state;
            return this;
        }
        public AddressBuilder SetZipCode(string zipCode)
        {
            _zipCode = zipCode;
            return this;
        }
        public Address Build()
        {
            return new Address
            {
                Street = _street,
                City = _city,
                State = _state,
                ZipCode = _zipCode
            };
        }
    }
}