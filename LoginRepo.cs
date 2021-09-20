using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repository
{
    public class LoginRepo : ILoginRepo
    {
        private CustomerDb db;

        public LoginRepo(CustomerDb db)
        {
            this.db = db;
        }
        public void AddCust(LoginCustomer cust)
        {
            db.LoginCustomers.Add(cust);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
