namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inf_Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inf_Customers()
        {
            Inf_Repair = new HashSet<Inf_Repair>();
        }

        [Key]
        [StringLength(10)]
        public string Customer_Id { get; set; }

        [StringLength(60)]
        public string Customer_Name { get; set; }

        [StringLength(1)]
        public string Customer_Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Customer_Birth { get; set; }

        [StringLength(135)]
        public string Customer_Email { get; set; }

        [StringLength(15)]
        public string Customer_Phone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Customer_TimeAdd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inf_Repair> Inf_Repair { get; set; }
    }
}
