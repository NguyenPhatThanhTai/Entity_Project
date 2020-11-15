namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salary_Staff
    {
        [Key]
        [StringLength(10)]
        public string Staff_Id { get; set; }

        [StringLength(12)]
        public string Staff_Default_Salary { get; set; }

        [StringLength(12)]
        public string Staff_Salary_Per_Hour { get; set; }

        [StringLength(12)]
        public string Staff_OT { get; set; }

        [StringLength(12)]
        public string Staff_Reward { get; set; }

        public virtual Inf_Staff Inf_Staff { get; set; }
    }
}
