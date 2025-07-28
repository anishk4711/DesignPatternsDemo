namespace DesignPatternsDemo.BuilderDP
{
    public class Customer
    {
        public string? Name { get; init; }
        public string? Email { get; init; }
        public string? Phone { get; init; }

        public Address? BillingAddress { get; set; }

        public override string ToString()
        {
            return $"Customer: {Name}, Email: {Email}, Phone: {Phone}, Billing Address: {BillingAddress?.ToString()}";
        }

    }
}
