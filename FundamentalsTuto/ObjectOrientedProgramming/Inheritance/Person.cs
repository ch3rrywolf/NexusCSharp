
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Person
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid Name");

            FirstName = firstName;
            LastName = lastName;
        }

        public DateOnly BirthDate { get; private set; }
                public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1996, 4, 17))
                throw new ArgumentException("Invalid birth date");
            BirthDate = birthDate;
        }

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