using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Customer
    {
        private DiscountStrategy discountStrategy;

        public void SetDiscountStrategy(DiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public decimal ApplyDiscount(decimal sale)
        {
            return discountStrategy.ApplyDiscount(sale);
        }
    }
}
