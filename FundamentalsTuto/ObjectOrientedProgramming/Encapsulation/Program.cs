
using Encapsulation;

var employee = new Employee();
employee.SetName("ch3rry", "wolf");
employee.SetBirthDate(new DateOnly(1997, 1, 1));
employee.SetBasicSalary(2000);
employee.SetTaxPercentage(20);

Console.WriteLine($"Full Name:\t {employee.FirstName} {employee.LastName}");
Console.WriteLine($"Birth Date:\t {employee.BirthDate}");
Console.WriteLine($"Basic Salary:\t {employee.BasicSalary:0.00}");
Console.WriteLine($"Tax Percentage:\t {employee.TaxPercentage} %");
Console.ReadKey();