using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class ProductsDb : DbContext
    {
        public ProductsDb()
            : base("name=ProductsDbConSett")
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
