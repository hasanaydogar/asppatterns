using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TradeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal originalSalesPrice)
        {
            decimal price = originalSalesPrice;

            price = price*0.95M;

            return price;
        }
    }
}
