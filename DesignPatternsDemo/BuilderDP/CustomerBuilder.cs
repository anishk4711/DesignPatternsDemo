namespace DesignPatternsDemo.BuilderDP
{
    public class CustomerBuilder
    {
        private string _name = string.Empty;
        private string _email = string.Empty;
        private string _phone = string.Empty;
        private readonly AddressBuilder _addressBuilder = AddressBuilder.CreateAddressBuilder();

        private CustomerBuilder()
        {
        }

        public static CustomerBuilder CreateCustomerBuilder()
        {
            return new CustomerBuilder();
        }

        public CustomerBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        public CustomerBuilder SetEmail(string email)
        {
            _email = email;
            return this;
        }
        public CustomerBuilder SetPhone(string phone)
        {
            _phone = phone;
            return this;
        }
        public CustomerBuilder SetBillingAddress(Action<AddressBuilder> addressAction)
        {
            addressAction(_addressBuilder);
            return this;
        }
        public Customer Build()
        {
            return new Customer
            {
                Name = _name,
                Email = _email,
                Phone = _phone,
                BillingAddress = _addressBuilder.Build()
            };
        }
    }
}
