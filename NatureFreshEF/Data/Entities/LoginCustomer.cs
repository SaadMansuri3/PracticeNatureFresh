namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginCustomer")]
    public partial class LoginCustomer
    {
        public int id { get; set; }

        public int? CustId { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public virtual RegCustomer RegCustomer { get; set; }
    }
}
