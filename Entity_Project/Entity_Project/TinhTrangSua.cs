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
    public partial class TinhTrangSua : DevExpress.XtraEditors.XtraForm
    {
        public TinhTrangSua()
        {
            InitializeComponent();
        }

        Data_RP DRP;

        private void TinhTrangSua_Load(object sender, EventArgs e)
        {
            DRP = new Data_RP();
            Load_TinhTrang(DRP.Inf_Repair());
        }

        private void Load_TinhTrang(List<Inf_Repair> Inf_Repair)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Inf_Repair)
            {
                var date1 = DateTime.Parse(item.Detail_Inf_Repair.Repair_Appointment.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Repair_Id;
                Data.Rows[index].Cells[2].Value = item.Inf_Customers.Customer_Name;
                Data.Rows[index].Cells[3].Value = item.Detail_Inf_Repair.Repair_Note;
                Data.Rows[index].Cells[4].Value = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[5].Value = item.Staff_Id;
                i++;
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận hoàn thành đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                
            }
        }


    }
}