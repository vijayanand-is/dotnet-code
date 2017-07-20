using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Receipt
    {
        public Guid OrderID { get; set; }

        public decimal AmountPaid { get; set; }

        public DateTime DatePaid { get; set; }

        public string Confirmation { get; set; }
    }
}
