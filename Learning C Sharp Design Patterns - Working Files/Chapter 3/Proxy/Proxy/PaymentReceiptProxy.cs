using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class PaymentReceiptProxy : IPaymentReceipt
    {
        private bool _PaymentProcessing = false;
        private bool _PaymentProcessed = false;
        private PaymentReceipt _PaymentReceipt = new PaymentReceipt();
        private Receipt _Receipt = null;

        public Order Order { get; set; }

        public Receipt Receipt
        {
            get
            {
                if (_PaymentProcessed)
                {
                    return _Receipt;
                }
                else
                {
                    if (!_PaymentProcessing)
                    {
                        _PaymentProcessing = true;
                        // here we kick off the credit card approval process
                        // this should probably be on a separate thread
                        _PaymentReceipt.Order = Order;
                        _Receipt = _PaymentReceipt.Receipt;
                        _PaymentProcessing = false;
                        _PaymentProcessed = true;
                    }

                    // return the placeholder while processing
                    return GetPlaceholderReceipt();
                }
            } 
        }

        private Receipt GetPlaceholderReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.OrderID = Order.OrderID;
            receipt.AmountPaid = Order.Amount;
            receipt.Confirmation = "Processing...";
            receipt.DatePaid = DateTime.Now;
            return receipt;
        }
    }
}
