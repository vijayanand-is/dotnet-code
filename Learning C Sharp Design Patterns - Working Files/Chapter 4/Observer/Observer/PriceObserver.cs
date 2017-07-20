using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// The 'Observer' abstract class
    /// </summary>
    abstract class PriceObserver
    {
        public abstract void Update(Price priceToWatch);
    }

}
