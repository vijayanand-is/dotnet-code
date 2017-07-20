using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class PaymentReceipt : IPaymentReceipt
    {
        public Order Order { get; set; }

        public Receipt Receipt
        {
            get { return GetReceipt(); } 
        }

        private Receipt GetReceipt()
        {
            // contact the payment processor with order info
            // this may be an asynchronous operation, so use async if so

            // once processing is done, set the property values
            Receipt receipt = new Receipt();
            receipt.OrderID = Order.OrderID;
            receipt.AmountPaid = Order.Amount;
            receipt.Confirmation = "AG436757FG";
            receipt.DatePaid = DateTime.Now;

            return receipt;
        }
    }
}
