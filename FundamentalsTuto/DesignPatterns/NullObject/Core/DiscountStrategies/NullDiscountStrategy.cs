using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullObject.Core;
using NullObject.Core.DiscountStrategies;

namespace NullObject.Core.DiscountStrategies
{
    internal class NullDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}