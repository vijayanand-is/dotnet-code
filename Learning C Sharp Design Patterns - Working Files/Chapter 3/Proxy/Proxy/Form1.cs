using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IPaymentReceipt paymentReceipt;

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                OrderDate = DateTime.Now,
                OrderID = Guid.NewGuid(),
                CustomerID = 5,
                Amount = 85.25M,
                CreditCard = "1111222233334444",
                Expiration = "5/15"
            };

            paymentReceipt = new PaymentReceiptProxy
            {
                Order = order
            };

            Receipt receipt = paymentReceipt.Receipt;
            DisplayReceipt(receipt);
        }

        private void DisplayReceipt(Receipt Receipt)
        {
            txtReceiptID.Text = Receipt.Confirmation;
            txtAmountPaid.Text = Receipt.AmountPaid.ToString("C");
            txtDatePaid.Text = Receipt.DatePaid.ToLongDateString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Receipt receipt = paymentReceipt.Receipt;
            DisplayReceipt(receipt);
        }

    }
}
