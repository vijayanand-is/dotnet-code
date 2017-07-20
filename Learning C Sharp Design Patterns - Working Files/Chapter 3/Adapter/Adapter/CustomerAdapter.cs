using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CustomerAdapter : ICustomerList
    {
        private List<Customer> Customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            return Customers;
        }

        public void AddCustomer(CustomerDTO customer)
        {
            Customers.Add(new Customer
            {
                CustomerID = customer.ID,
                Name = customer.FirstName + " " + customer.LastName,
                Address = customer.Address,
                City = customer.City,
                State = customer.State,
                Zip = customer.PostalCode
            });
        }

    }
}
