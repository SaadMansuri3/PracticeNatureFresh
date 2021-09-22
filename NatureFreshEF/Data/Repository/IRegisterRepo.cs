using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repository
{
    interface IRegisterRepo
    {
        IEnumerable<RegCustomer> GetCustomers();

        RegCustomer GetCustomerById(int id);
        int AddCustomer(RegCustomer cust);
        RegCustomer UpdateCustomer(RegCustomer customer);
        void DeleteCustomer(int id);
        void Save();
    }
}
