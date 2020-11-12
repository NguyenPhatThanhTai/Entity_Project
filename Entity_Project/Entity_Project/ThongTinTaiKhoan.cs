using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class ThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        string Staff_Id, Sex, PhongBan, ChucVu;
        Data_NV DNV;

        public ThongTinTaiKhoan(string Staff_Id) : this()
        {
            this.Staff_Id = Staff_Id;
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            foreach (var item in DNV.Infomation(Staff_Id))
            {
                if (item.Staff_Sex.ToString() == "1")
                {
                    Sex = "Nam";
                }
                else if (item.Staff_Sex.ToString() == "2")
                {
                    Sex = "Nữ";
                }
                else if (item.Staff_Sex.ToString() == "3")
                {
                    Sex = "Khác";
                }

                if (item.Staff_Deparment.ToString() == "1")
                {
                    PhongBan = "Quản lý";
                }
                else if (item.Staff_Deparment.ToString() == "2")
                {
                    PhongBan = "Kỹ Thuật";
                }
                else if (item.Staff_Deparment.ToString() == "3")
                {
                    PhongBan = "Kế Toán";
                }

                if (item.Account_Staff.Staff_Role.ToString() == "1")
                {
                    ChucVu = "Quản lý";
                }
                else
                {
                    ChucVu = "Nhân viên";
                }

                var date1 = DateTime.Parse(item.Staff_Birth.ToString());

                txtAccount.Text = item.Account_Staff.Staff_Account;
                txtPassword.Text = item.Account_Staff.Staff_Password;
                txtHoTen.Text = item.Staff_Name;
                txtGioiTinh.Text = Sex;
                txtDiaChi.Text = item.Staff_Address;
                txtDate.Text = date1.ToString("dd/MM/yyyy");
                txtSDT.Text = item.Staff_Phone;
                txtPhongBan.Text = PhongBan;
                txtChucVu.Text = ChucVu;
            }
        }
    }
}