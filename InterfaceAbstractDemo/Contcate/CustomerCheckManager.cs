using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Contcate
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckCustomer(Customer customer)
        {
            return true;
        }
    }
}
