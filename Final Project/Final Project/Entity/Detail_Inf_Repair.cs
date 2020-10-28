namespace Final_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail_Inf_Repair
    {
        [Key]
        [StringLength(10)]
        public string Repair_Id { get; set; }

        public string Repair_Reason { get; set; }

        public string Repair_Note { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Repair_Appointment { get; set; }

        [StringLength(12)]
        public string Repair_Money { get; set; }

        public virtual Inf_Repair Inf_Repair { get; set; }
    }
}
