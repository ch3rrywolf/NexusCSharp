using Polymorphism;
using System;

var salariedEmployee = new SalariedEmployee();
salariedEmployee.BasicSalary = 2000;
salariedEmployee.Housing = 1000;
salariedEmployee.Transportation = 500;
Console.WriteLine($"Salary of Salaried (without taxes) employee is {salariedEmployee.GetSalary():0.00}");
Console.WriteLine($"Salary of Salaried (with 10% taxes) employee is {salariedEmployee.GetSalary(10):0.00}");
Console.WriteLine($"Salary of Salaried (with 10% taxes and bonus) employee is {salariedEmployee.GetSalary(10, 1000):0.00}");

var hourlyEmployee = new HourlyEmployee();
hourlyEmployee.HourRate = 100;
hourlyEmployee.TotalWorkingHours = 60;
Console.WriteLine($"Salary of Hourly employee is {hourlyEmployee.GetSalary():0.00}");

var internEmployee = new InternEmployee();
Console.WriteLine($"Salary of Intern employee is {internEmployee.GetSalary():0.00}");

Console.ReadKey();