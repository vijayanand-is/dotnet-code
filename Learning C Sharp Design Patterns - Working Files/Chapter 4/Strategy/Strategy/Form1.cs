using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApplyDiscounts_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (chkLoyalty.Checked && chkStudent.Checked)
            {
                customer.SetDiscountStrategy(new LoyalStudentDiscount());
            }
            else if (chkLoyalty.Checked)
            {
                customer.SetDiscountStrategy(new LoyaltyDiscount());
            }
            else if (chkStudent.Checked)
            {
                customer.SetDiscountStrategy(new StudentDiscount());
            }
            else
            {
                customer.SetDiscountStrategy(new NoDiscount());
            }

            decimal price = customer.ApplyDiscount(numTotalSale.Value);
            lblFinalPrice.Text = price.ToString("C");
        }
    }
}
