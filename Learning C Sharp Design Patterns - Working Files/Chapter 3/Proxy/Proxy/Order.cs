using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Order
    {
        public Guid OrderID { get; set; }

        public int CustomerID { get; set; }

        public decimal Amount { get; set; }

        public DateTime OrderDate { get; set; }

        public string CreditCard { get; set; }

        public string Expiration { get; set; }
    }
}
