namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Quantity { get; set; }

        public int? Price { get; set; }
    }
}
