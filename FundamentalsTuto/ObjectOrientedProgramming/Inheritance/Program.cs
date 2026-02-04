
using Inheritance;
using System;

var employee = new Employee();
employee.SetName("ch3rry", "wolf");
employee.SetBirthDate(new DateOnly(1997, 1, 1));
employee.SetBasicSalary(2000);
employee.SetTaxPercentage(20);

PrintPersonDetails(employee);
Console.WriteLine("---------------------");
var applicant = new Applicant();
applicant.SetName("ch3rry1", "wolf1");
applicant.SetBirthDate(new DateOnly(1998, 2, 2));
PrintPersonDetails(applicant);
Console.WriteLine("---------------------");
Person person = employee;
person = applicant;

Console.WriteLine($"Basic Salary:\t {employee.BasicSalary:0.00}");
Console.WriteLine($"Tax Percentage:\t {employee.TaxPercentage} %");
Console.ReadKey();

void PrintPersonDetails(Person person)
{
    Console.WriteLine($"Full Name:\t {person.FirstName} {person.LastName}");
    Console.WriteLine($"Birth Date:\t {person.BirthDate}");
}