using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Price
    {
        private List<PriceObserver> observers = new List<PriceObserver>();
        private decimal productPrice;

        public void Subscribe(PriceObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(PriceObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (PriceObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        // Gets or sets the price
        public decimal ProductPrice
        {
            get { return productPrice; }
            set
            {
                if (productPrice != value)
                {
                    productPrice = value;
                    Notify();
                }
            }
        }
    }

}
