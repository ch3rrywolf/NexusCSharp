using StrategyPattern.Core;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer List: [1] Ch3rry Wolf exe [2] C W E");
    Console.WriteLine($"Enter Customer ID: ");
    var customerId = int.Parse(Console.ReadLine());
    Console.Write("Enter Item Quantity: ");
    var quantity = double.Parse(Console.ReadLine());
    Console.Write("Enter Unit Price: ");
    var unitPrice = double.Parse(Console.ReadLine());

    var customer = customers.First(x => x.Id == customerId);
    var invoice = new Invoice
    {
        Customer = customer,
        Lines = new[]
        {
            new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
        },
        DiscountPercentage = customer.IsEligibleForDiscount ? 0.02 : 0
    };
    Console.WriteLine($"Invoice created for customer `{customer.Name}` with net price: {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-------------------------");
}