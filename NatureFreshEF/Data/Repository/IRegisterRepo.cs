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
        void AddCust(RegCustomer cust);
        void Save();
    }
}
