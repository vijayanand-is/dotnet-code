using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface ICustomerList
    {
        List<Customer> GetCustomers();
        void AddCustomer(CustomerDTO customer);
    }
}
