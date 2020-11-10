namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inf_LK
    {
        [Key]
        [StringLength(10)]
        public string LK_Id { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouse_Id { get; set; }

        [StringLength(50)]
        public string LK_Name { get; set; }

        [StringLength(10)]
        public string LK_Number { get; set; }

        [StringLength(50)]
        public string LK_Producer { get; set; }

        [StringLength(10)]
        public string LK_Price { get; set; }

        public DateTime? LK_Time_Add { get; set; }

        public virtual Inf_WareHouse Inf_WareHouse { get; set; }
    }
}
