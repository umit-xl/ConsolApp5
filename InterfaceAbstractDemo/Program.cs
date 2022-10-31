using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Contcate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCostumerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1985, 1, 6),
                FirstName = "Ümit",
                LastName = "Arlı",
                NationalityId = "39811892146"
                
            }
            );
        }
         
    }
}
