using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : Person
    {
        public decimal BasicSalary { get; private set; }
        public void SetBasicSalary(int basicSalary)
        {
            if (basicSalary > 3000)
                throw new ArgumentException("Invalid Basic Salary");
            BasicSalary = basicSalary;
        }

        public int TaxPercentage { get; private set; }
        public void SetTaxPercentage(int taxpercentage)
        {
            if (taxpercentage > 30)
                throw new ArgumentException("Invalid tax");
            TaxPercentage = taxpercentage;
        }
    }
}