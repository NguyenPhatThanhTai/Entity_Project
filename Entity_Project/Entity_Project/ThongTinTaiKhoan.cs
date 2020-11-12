using DevExpress.XtraEditors;
using Entity_Project.Entity;
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
            Load_Inf();
        }

        private void Load_Inf()
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
                    PhongBan = "Quản Lý";
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
                    ChucVu = "Quản Lý";
                }
                else
                {
                    ChucVu = "Nhân Viên";
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

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            enable(true);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận không lưu ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                enable(false);
                Load_Inf();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thay đổi thông tin ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (DNV.Update_NV(txtHoTen.Text, txtGioiTinh.Text, txtDate.Value, txtDiaChi.Text, txtSDT.Text, txtPhongBan.Text, txtAccount.Text) && DNV.Update_Account(txtPassword.Text, txtChucVu.Text, txtAccount.Text))
                {
                    if (Properties.Settings.Default.UserName == txtAccount.Text)
                    {
                        Properties.Settings.Default.Password = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    MessageBox.Show("Cập nhật thông tin thành công");
                    enable(false);
                    Load_Inf();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại");
                }
            }
        }

        private void enable(bool a) 
        {
            txtPassword.Enabled = a;
            txtHoTen.Enabled = a;
            txtGioiTinh.Enabled = a;
            txtDiaChi.Enabled = a;
            txtDate.Enabled = a;
            txtSDT.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
    }
}