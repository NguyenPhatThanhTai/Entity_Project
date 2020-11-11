namespace Entity_Project.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Data : DbContext
    {
        public Data()
            : base("name=Data4")
        {
        }

        public virtual DbSet<Inf_Customers> Inf_Customers { get; set; }
        public virtual DbSet<Inf_LichSu> Inf_LichSu { get; set; }
        public virtual DbSet<Inf_LK> Inf_LK { get; set; }
        public virtual DbSet<Inf_Repair> Inf_Repair { get; set; }
        public virtual DbSet<Inf_Staff> Inf_Staff { get; set; }
        public virtual DbSet<Inf_WareHouse> Inf_WareHouse { get; set; }
        public virtual DbSet<Account_Staff> Account_Staff { get; set; }
        public virtual DbSet<Detail_Inf_Repair> Detail_Inf_Repair { get; set; }
        public virtual DbSet<Salary_Staff> Salary_Staff { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inf_Customers>()
                .Property(e => e.Customer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Customers>()
                .Property(e => e.Customer_Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Customers>()
                .Property(e => e.Customer_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Customers>()
                .HasMany(e => e.Inf_Repair)
                .WithRequired(e => e.Inf_Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inf_LichSu>()
                .Property(e => e.Customer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LichSu>()
                .Property(e => e.Customer_Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LichSu>()
                .Property(e => e.Customer_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LichSu>()
                .Property(e => e.Repair_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LichSu>()
                .Property(e => e.Repair_Money)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LK>()
                .Property(e => e.LK_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LK>()
                .Property(e => e.WareHouse_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LK>()
                .Property(e => e.LK_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_LK>()
                .Property(e => e.LK_Price)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Repair>()
                .Property(e => e.Repair_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Repair>()
                .Property(e => e.Customer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Repair>()
                .HasOptional(e => e.Detail_Inf_Repair)
                .WithRequired(e => e.Inf_Repair);

            modelBuilder.Entity<Inf_Staff>()
                .Property(e => e.Staff_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Staff>()
                .Property(e => e.Staff_Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Staff>()
                .Property(e => e.Staff_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Staff>()
                .Property(e => e.Staff_Deparment)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_Staff>()
                .HasOptional(e => e.Account_Staff)
                .WithRequired(e => e.Inf_Staff);

            modelBuilder.Entity<Inf_Staff>()
                .HasOptional(e => e.Salary_Staff)
                .WithRequired(e => e.Inf_Staff);

            modelBuilder.Entity<Inf_WareHouse>()
                .Property(e => e.WareHouse_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Inf_WareHouse>()
                .Property(e => e.WareHouse_Capacity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Inf_WareHouse>()
                .Property(e => e.Ware_House_Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Inf_WareHouse>()
                .HasMany(e => e.Inf_LK)
                .WithRequired(e => e.Inf_WareHouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account_Staff>()
                .Property(e => e.Staff_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Account_Staff>()
                .Property(e => e.Staff_Role)
                .IsUnicode(false);

            modelBuilder.Entity<Detail_Inf_Repair>()
                .Property(e => e.Repair_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Detail_Inf_Repair>()
                .Property(e => e.Repair_Money)
                .IsUnicode(false);

            modelBuilder.Entity<Salary_Staff>()
                .Property(e => e.Staff_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Salary_Staff>()
                .Property(e => e.Staff_Default_Salary)
                .IsUnicode(false);

            modelBuilder.Entity<Salary_Staff>()
                .Property(e => e.Staff_Salary_Per_Hour)
                .IsUnicode(false);

            modelBuilder.Entity<Salary_Staff>()
                .Property(e => e.Staff_OT)
                .IsUnicode(false);

            modelBuilder.Entity<Salary_Staff>()
                .Property(e => e.Staff_Reward)
                .IsUnicode(false);
        }
    }
}
