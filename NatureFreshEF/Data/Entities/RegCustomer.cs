namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegCustomer")]
    public partial class RegCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegCustomer()
        {
            LoginCustomers = new HashSet<LoginCustomer>();
        }

        public int id { get; set; }

        
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        
        [StringLength(20)]
        public string Password { get; set; }

        public int age { get; set; }

        
        [StringLength(200)]
        public string Address { get; set; }

       
        [StringLength(20)]
        public string Zipcode { get; set; }

        
        [StringLength(20)]
        public string Mobile { get; set; }

        
        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginCustomer> LoginCustomers { get; set; }
    }
}
