namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inf_Repair
    {
        [Key]
        [StringLength(10)]
        public string Repair_Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Customer_Id { get; set; }

        [StringLength(60)]
        public string Laptop_Name { get; set; }

        public string Laptop_Status { get; set; }

        [StringLength(50)]
        public string Staff_Id { get; set; }

        public virtual Inf_Customers Inf_Customers { get; set; }

        public virtual Detail_Inf_Repair Detail_Inf_Repair { get; set; }
    }
}
