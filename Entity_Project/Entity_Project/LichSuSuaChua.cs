using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entity_Project.Entity;

namespace Entity_Project
{
    public partial class LichSuSuaChua : DevExpress.XtraEditors.XtraForm
    {
        public LichSuSuaChua()
        {
            InitializeComponent();
        }

        Data_RP DRP;
        string Sex;

        private void LichSuSuaChua_Load(object sender, EventArgs e)
        {
            DRP = new Data_RP();
            load_LS(DRP.LichSu());
        }

        private void load_LS(List<Inf_LichSu> inf_LichSu)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in inf_LichSu)
            {
                if (item.Customer_Sex.ToString() == "1")
                {
                    Sex = "Nam";
                }
                else if (item.Customer_Sex.ToString() == "2")
                {
                    Sex = "Nữ";
                }
                else
                {
                    Sex = "Khác";
                }

                var date1 = DateTime.Parse(item.Customer_Birth.ToString());
                var date2 = DateTime.Parse(item.Customer_TimeAdd.ToString());
                var date3 = DateTime.Parse(item.Repair_Appointment.ToString());
                var date4 = DateTime.Parse(item.Repair_Time_End.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Customer_Id;
                Data.Rows[index].Cells[2].Value = item.Customer_Name;
                Data.Rows[index].Cells[3].Value = Sex;
                Data.Rows[index].Cells[4].Value = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[5].Value = item.Customer_Email;
                Data.Rows[index].Cells[6].Value = item.Customer_Phone;
                Data.Rows[index].Cells[7].Value = date2.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[8].Value = item.Repair_Id;
                Data.Rows[index].Cells[9].Value = item.Laptop_Name;
                Data.Rows[index].Cells[10].Value = item.Laptop_Status;
                Data.Rows[index].Cells[11].Value = item.Staff_Id;
                Data.Rows[index].Cells[12].Value = item.Repair_Reason;
                Data.Rows[index].Cells[13].Value = item.Repair_Note;
                Data.Rows[index].Cells[14].Value = date3.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[15].Value = item.Repair_Money;
                Data.Rows[index].Cells[16].Value = date4.ToString("dd/MM/yyyy");
                i++;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Data_RP DRP = new Data_RP();
            load_LS(DRP.LichSu());
        }

        private void LichSuSuaChua_Enter(object sender, EventArgs e)
        {
            Data_RP DRP = new Data_RP();
            load_LS(DRP.LichSu());
        }
    }
}