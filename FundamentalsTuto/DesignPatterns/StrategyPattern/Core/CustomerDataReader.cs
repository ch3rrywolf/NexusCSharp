namespace StrategyPattern.Core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer
                {
                    Id = 1,
                    Name = "Ch3rry wolf exe",
                    IsEligibleForDiscount = true
                },
                new Customer
                {
                    Id = 2,
                    Name = "C W E"
                }
            };
        }
    }
}