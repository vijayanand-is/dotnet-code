using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    class PriceWatcher : PriceObserver
    {
        private string name;
        private decimal price;

        public event System.EventHandler<decimal> PriceChanged = null;

        // Constructor
        public PriceWatcher(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public override void Update(Price priceToWatch)
        {
            price = priceToWatch.ProductPrice;
            if (PriceChanged != null)
            {
                PriceChanged(this, price);
            }
        }

    }

}
