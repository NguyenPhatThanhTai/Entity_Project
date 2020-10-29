namespace Entity_Project.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_Staff
    {
        [Key]
        [StringLength(10)]
        public string Staff_Id { get; set; }

        [StringLength(50)]
        public string Staff_Account { get; set; }

        [StringLength(50)]
        public string Staff_Password { get; set; }

        [StringLength(1)]
        public string Staff_Role { get; set; }

        public virtual Inf_Staff Inf_Staff { get; set; }
    }
}
