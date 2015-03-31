using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategyFor(CustomerType customerType)
        {
            switch (customerType)
            {
                    case CustomerType.Trade:
                        return new TradeDiscountStrategy();
                default:
                        return new NullDiscountStrategy();
            }
        }
    }
}
