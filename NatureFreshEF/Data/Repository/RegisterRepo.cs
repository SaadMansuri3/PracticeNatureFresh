using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repository
{
    public class RegisterRepo : IRegisterRepo
    {
        private CustomerDb db;

        public RegisterRepo(CustomerDb db)
        {
            this.db = db;
        }
        public int AddCustomer(RegCustomer cust)
        {
            db.RegCustomers.Add(cust);
            Save();
            return db.RegCustomers.Local[0].id;
        }

        public void DeleteCustomer(int id)
        {

            var cust = db.RegCustomers.Find(id);
            if (cust != null)
            {
                db.RegCustomers.Remove(cust);
                Save();
            }
            else
                throw new ArgumentException("Customer is not found");
        }




        public void Save()
        {
            db.SaveChanges();
        }



        public RegCustomer GetCustomerById(int id)
        {
            if (id > 0)
            {
                var cust = db.RegCustomers.Find(id);

                if (cust != null)
                    return cust;
                else
                    return null;
            }
            else
            {
                throw new ArgumentException("Id cannot be less than 0");
            }

        }



        public RegCustomer UpdateCustomer(RegCustomer customer)
        {
            RegCustomer updatedCust = (from c in db.RegCustomers
                                       where c.id == customer.id
                                       select c).FirstOrDefault();
            updatedCust.Name = customer.Name;
            updatedCust.Username = customer.Username;
            updatedCust.Mobile = customer.Mobile;
            updatedCust.Address = customer.Address;
            Save();

            return customer;
        }

        public IEnumerable<RegCustomer> GetCustomers()
        {
            return db.RegCustomers.ToList();
        }


    }
}
