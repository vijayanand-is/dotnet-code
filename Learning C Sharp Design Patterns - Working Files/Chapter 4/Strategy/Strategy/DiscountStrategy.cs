using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class DiscountStrategy
    {
        protected double discountPercentage { get; set; }

        public abstract decimal ApplyDiscount(decimal sale);
    }

}
