using AdapterPattern.Core;
using System.Net.Http.Json;

var payrollCalculatorUrl = "http://localhost:5144/PayrollCalculator";
var reader = new EmployeesDataReader();
var employees = reader.GetEmployees();

var client = new HttpClient();

foreach (var employee in employees)
{
    var response = await client.PostAsJsonAsync(payrollCalculatorUrl, employee);
    response.EnsureSuccessStatusCode();

    var salary = await response.Content.ReadFromJsonAsync<decimal>();

    Console.WriteLine($"Salary for employee `{employee.FullName}` as of today = {salary}");
}

Console.ReadKey();
