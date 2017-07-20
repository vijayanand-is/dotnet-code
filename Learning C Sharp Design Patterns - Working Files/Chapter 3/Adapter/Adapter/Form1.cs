using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomerList = new CustomerAdapter();
        }

        private int CustomerID = 1;
        private ICustomerList CustomerList;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO
            {
                ID = CustomerID,
                FirstName = "Customer",
                LastName = CustomerID.ToString(),
                Address = "",
                City = "",
                PostalCode = ""
            };
            CustomerList.AddCustomer(customer);
            CustomerID++;
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            listCustomers.Items.Clear();
            List<Customer> customers = CustomerList.GetCustomers();
            foreach (Customer customer in customers)
            {
                listCustomers.Items.Add(customer.Name);
            }
        }
    }
}
