namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inf_WareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inf_WareHouse()
        {
            Inf_LK = new HashSet<Inf_LK>();
        }

        [Key]
        [StringLength(8)]
        public string WareHouse_Id { get; set; }

        [StringLength(50)]
        public string WareHouse_Name { get; set; }

        [StringLength(50)]
        public string WareHouse_Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WareHouse_Capacity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Ware_House_Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inf_LK> Inf_LK { get; set; }
    }
}
