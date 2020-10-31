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
    public partial class DanhSachKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachKhoHang()
        {
            InitializeComponent();
        }

        Data_LK DLK;

        private void DanhSachKhoHang_Load(object sender, EventArgs e)
        {
            DLK = new Data_LK();
            Load_KHA(DLK.Inf_WareHouse());
            Load_LK(DLK.Inf_LK());
        }


        private void Load_KHA(List<Inf_WareHouse> Inf_WareHouse)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Inf_WareHouse)
            {
                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.WareHouse_Id;
                Data.Rows[index].Cells[2].Value = item.WareHouse_Name;
                Data.Rows[index].Cells[3].Value = item.WareHouse_Address;
                Data.Rows[index].Cells[4].Value = item.WareHouse_Capacity;
                Data.Rows[index].Cells[5].Value = item.Ware_House_Total;
                i++;
            }
        }

        private void Load_LK(List<Inf_LK> Inf_LK)
        {
            int i = 1;
            Data1.Rows.Clear();
            foreach (var item in Inf_LK)
            {
                int index = Data1.Rows.Add();
                Data1.Rows[index].Cells[0].Value = i;
                Data1.Rows[index].Cells[1].Value = item.LK_Id;
                Data1.Rows[index].Cells[2].Value = item.WareHouse_Id;
                Data1.Rows[index].Cells[3].Value = item.LK_Name;
                Data1.Rows[index].Cells[4].Value = item.LK_Number;
                Data1.Rows[index].Cells[5].Value = item.LK_Producer;
                Data1.Rows[index].Cells[6].Value = item.LK_Price;
                Data1.Rows[index].Cells[7].Value = item.LK_Time_Add;
                i++;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            Load_KHA(DLK.Inf_WareHouse());
            Load_LK(DLK.Inf_LK());
        }
    }
}