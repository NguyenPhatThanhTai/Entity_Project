namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inf_Staff
    {
        [Key]
        [StringLength(10)]
        public string Staff_Id { get; set; }

        [StringLength(50)]
        public string Staff_Name { get; set; }

        [StringLength(1)]
        public string Staff_Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Staff_Birth { get; set; }

        [StringLength(100)]
        public string Staff_Address { get; set; }

        [StringLength(15)]
        public string Staff_Phone { get; set; }

        [StringLength(1)]
        public string Staff_Deparment { get; set; }

        [StringLength(50)]
        public string Staff_TimeAdd { get; set; }

        public virtual Account_Staff Account_Staff { get; set; }

        public virtual Salary_Staff Salary_Staff { get; set; }
    }
}
