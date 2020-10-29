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
    public partial class ThongTinKhachHang : DevExpress.XtraEditors.XtraForm
    {

        Data_KH DKH;
        string Sex;

        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            DKH = new Data_KH();
            Load_KH(DKH.Inf_KH());
        }

        private void Load_KH(List<Inf_Customers> listCustomer)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in listCustomer)
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
                var date2 = DateTime.Parse(item.Customer_Birth.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Customer_Id;
                Data.Rows[index].Cells[2].Value = item.Customer_Name;
                Data.Rows[index].Cells[3].Value = Sex;
                Data.Rows[index].Cells[4].Value = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[5].Value = item.Customer_Email;
                Data.Rows[index].Cells[6].Value = item.Customer_Phone;
                Data.Rows[index].Cells[7].Value = date2.ToString("dd/MM/yyyy");
                i++;
            }
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            DKH = new Data_KH();
            Load_KH(DKH.Inf_KH());
        }

        private void Data_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
            txtHoTen.Text = Data.SelectedRows[0].Cells[2].Value.ToString();
            txtGioiTinh.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
            txtBirth.Value = DateTime.Parse((string)Data.SelectedRows[0].Cells[4].Value);
            txtEmail.Text = Data.SelectedRows[0].Cells[5].Value.ToString();
            txtSDT.Text = Data.SelectedRows[0].Cells[6].Value.ToString();
            txtThoiGian.Text = Data.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}