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
        public int AddCust(RegCustomer cust)
        {
            db.RegCustomers.Add(cust);
            Save();
            int id = db.RegCustomers.Local[0].id;
            return id; 
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
