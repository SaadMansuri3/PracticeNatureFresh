using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProductsRepo : IProductsRepo
    {
        private ProductsDb db;

        public ProductsRepo(ProductsDb db)
        {
            this.db = db;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return db.Products.ToList();
        }
    }
}
