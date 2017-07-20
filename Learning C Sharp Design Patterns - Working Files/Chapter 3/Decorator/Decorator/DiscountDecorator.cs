using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DiscountDecorator : ComputerDecorator
    {
        private int DiscountRate = 5;

        public DiscountDecorator(Computer computer)
            : base(computer)
        {
            this.OptionCode = "Discount";
            this.Price = 0;
        }

        public override string GetOptionCode()
        {
            return base.GetOptionCode() + string.Format("Disc{0}", DiscountRate);
        }

        public override decimal GetPrice()
        {
            return (100 - DiscountRate) * BaseComputer.GetPrice() / 100;
        }

    }
}
