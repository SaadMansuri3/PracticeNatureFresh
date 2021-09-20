using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repository
{
    public class RegisterRepo:IRegisterRepo
    {
        private CustomerDb db;

        public RegisterRepo(CustomerDb db)
        {
            this.db = db;
        }
        public void AddCust(RegCustomer cust)
        {
            db.RegCustomers.Add(cust);
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
