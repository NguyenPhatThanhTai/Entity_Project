namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inf_LichSu
    {
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

        [StringLength(50)]
        public string Customer_TimeAdd { get; set; }

        [StringLength(10)]
        public string Repair_Id { get; set; }

        [StringLength(60)]
        public string Laptop_Name { get; set; }

        public string Laptop_Status { get; set; }

        [StringLength(50)]
        public string Staff_Id { get; set; }

        public string Repair_Reason { get; set; }

        public string Repair_Note { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Repair_Appointment { get; set; }

        [StringLength(12)]
        public string Repair_Money { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Repair_Time_End { get; set; }
    }
}
