using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class NullDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal originalSalesPrice)
        {
            return originalSalesPrice;
        }
    }
}
