using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class CustomerDb : DbContext
    {
        public CustomerDb()
            : base("name=ConnectionSettings")
        {
        }

        public virtual DbSet<LoginCustomer> LoginCustomers { get; set; }
        public virtual DbSet<RegCustomer> RegCustomers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginCustomer>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<LoginCustomer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<RegCustomer>()
                .HasMany(e => e.LoginCustomers)
                .WithOptional(e => e.RegCustomer)
                .HasForeignKey(e => e.CustId);
        }
    }
}
