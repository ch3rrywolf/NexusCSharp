using System.Diagnostics;

namespace PayrollSystem.Core
{
    public class PayrollCalculator
    {
        public decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculating salary for employee `{employee.FullName}`");
            if (employee.PayItem?.Any() == false)
                return 0;
            var monthTotal = employee.PayItems.Sum(payItem.Value);
            return Math.Round(monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2);
        }
    }
}