

using Abstraction;
using System;

var salariedEmployee = new SalariedEmployee();
salariedEmployee.SetName("hola", "amigo");
salariedEmployee.Email = "salaried@example.com";
salariedEmployee.BasicSalary = 2000;
salariedEmployee.Housing = 1000;
salariedEmployee.Transportation = 500;
Console.WriteLine($"Salary of Salaried (without taxes) employee is {salariedEmployee.GetSalary():0.00}");
Console.WriteLine($"Salary of Salaried (with 10% taxes) employee is {salariedEmployee.GetSalary(10):0.00}");
Console.WriteLine($"Salary of Salaried (with 10% taxes and bonus) employee is {salariedEmployee.GetSalary(10, 1000):0.00}");

var hourlyEmployee = new HourlyEmployee();
hourlyEmployee.SetName("hola1", "amigo1");
hourlyEmployee.Email = "salaried1@example.com";
hourlyEmployee.HourRate = 100;
hourlyEmployee.TotalWorkingHours = 60;
Console.WriteLine($"Salary of Hourly employee is {hourlyEmployee.GetSalary():0.00}");

var internEmployee = new InternEmployee();
internEmployee.SetName("hola2", "amigo2");
internEmployee.Email = "salaried2@example.com";
Console.WriteLine($"Salary of Intern employee is {internEmployee.GetSalary():0.00}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("------------------------");
var notifier = new Notifier("mail@example.com", 25, "noreply@example.com", "Abc123");
var payslipGenerator = new PayslipGenerator(notifier);
payslipGenerator.Generate(salariedEmployee);
payslipGenerator.Generate(hourlyEmployee);
payslipGenerator.Generate(internEmployee);

Console.ReadKey();