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
                    FullName = "Ch3rry Wolf exe",
                    PayItems = new List<PayItem>
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Medical Insurance", Value = -150}
                    }
                },
                new Employee
                {
                    FullName = "C W E",
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