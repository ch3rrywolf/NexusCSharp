using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class EmployeesDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Ch3rry",
                    SecondName = "Wolf",
                    LastName = "exe",
                    PayItems = new List<PayItem>
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Medical Insurance", Value = 150, IsDeduction = true}
                    }
                },
                new Employee
                {
                    FirstName = "C",
                    SecondName = "W",
                    LastName = "E",
                    PayItems = new List<PayItem>
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Medical Insurance", Value = -150}
                    }
                }
            };
        }
    }
}