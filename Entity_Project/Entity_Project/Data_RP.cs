using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project
{
    class Data_RP
    {
        int i = 0;
        string Name;
        Data data = new Data();

        public List<Inf_Repair> Inf_Repair()
        {
            List<Inf_Repair> repair = data.Inf_Repair.ToList();
            return repair;
        }

        public bool Update_NhanDon(string name, string Repair_Id)
        {
            Inf_Repair repair = data.Inf_Repair.FirstOrDefault(p => p.Repair_Id == Repair_Id);
            if(repair != null)
            {
                repair.Staff_Id = name;
                data.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update_RP(string Laptop_Name, string Laptop_Status, string Repair_Reason, string Repair_Note, DateTime Repair_Appointment, string Repair_Money, string Repair_Id)
        {
            Inf_Repair repair = data.Inf_Repair.FirstOrDefault(p => p.Repair_Id == Repair_Id);
            if(repair != null)
            {
                repair.Laptop_Name = Laptop_Name;
                repair.Laptop_Status = Laptop_Status;
                repair.Detail_Inf_Repair.Repair_Reason = Repair_Reason;
                repair.Detail_Inf_Repair.Repair_Note = Repair_Note;
                repair.Detail_Inf_Repair.Repair_Appointment = Repair_Appointment;
                repair.Detail_Inf_Repair.Repair_Money = Repair_Money;
                data.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
