using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullObject.Core;
using NullObject.Core.DiscountStrategies;

namespace NullObject
{
    internal class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
        {
            if (category == CustomerCategory.Silver)
                return new SilverCustomerDiscountStrategy();
            else if (category == CustomerCategory.Gold)
                return new GoldCustomerDiscountStrategy();
            return new NullDiscountStrategy();
        }
    }
}