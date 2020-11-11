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
    public partial class ThongTinLuongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinLuongNhanVien()
        {
            InitializeComponent();
        }

        Data_NV DNV;

        private void ThongTinLuongNhanVien_Load(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            Load_Salary(DNV.Salary_Staff());
        }

        private void Load_Salary(List<Salary_Staff> salary)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in salary)
            {
                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Staff_Id;
                Data.Rows[index].Cells[2].Value = item.Inf_Staff.Staff_Name;
                Data.Rows[index].Cells[3].Value = item.Staff_Default_Salary;
                Data.Rows[index].Cells[4].Value = item.Staff_Salary_Per_Hour;
                Data.Rows[index].Cells[5].Value = item.Staff_OT;
                Data.Rows[index].Cells[6].Value = item.Staff_Reward;
                i++;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLuongCoBan.Text != "" && txtLuongTheoGio.Text != "" && txtLamNgoaiGio.Text != "" && txtTienThuong.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận cập nhật ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (DNV.Update_Salary(txtLuongCoBan.Text, txtLuongTheoGio.Text, txtLamNgoaiGio.Text, txtTienThuong.Text, txtMaNV.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        Load_Salary(DNV.Salary_Staff());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        Load_Salary(DNV.Salary_Staff());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống");
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            openButton(false);
            txtMaNV.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
            txtTenNV.Text = Data.SelectedRows[0].Cells[2].Value.ToString();
            txtLuongCoBan.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
            txtLuongTheoGio.Text = Data.SelectedRows[0].Cells[4].Value.ToString();
            txtLamNgoaiGio.Text = Data.SelectedRows[0].Cells[5].Value.ToString();
            txtTienThuong.Text = Data.SelectedRows[0].Cells[6].Value.ToString();

            int TienCoBan = int.Parse(Data.SelectedRows[0].Cells[3].Value.ToString());
            int TienThuong = int.Parse(Data.SelectedRows[0].Cells[6].Value.ToString());
            int LamNgoaiGio = int.Parse(Data.SelectedRows[0].Cells[5].Value.ToString());
            int TongLuong = TienCoBan + TienThuong + LamNgoaiGio;

            txtTongLuong.Text = string.Format("{0:#,###}VND", TongLuong.ToString());
        }

        private void Clear()
        {
            openButton(true);
            txtLuongCoBan.Text = "";
            txtLuongTheoGio.Text = "";
            txtLamNgoaiGio.Text = "";
            txtTienThuong.Text = "";
            txtTongLuong.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            Data_NV DNV = new Data_NV();
            Load_Salary(DNV.Salary_Staff());
            Clear();
        }

        private void openButton(bool a)
        {
            btnUpdate.Enabled = !a;
            Data.Enabled = a;
            txtLuongCoBan.Enabled = !a;
            txtLuongTheoGio.Enabled = !a;
            txtLamNgoaiGio.Enabled = !a;
            txtTienThuong.Enabled = !a;
        }

        private void ThongTinLuongNhanVien_Enter(object sender, EventArgs e)
        {
            Data_NV DNV = new Data_NV();
            Load_Salary(DNV.Salary_Staff());
        }

        private void txtLuongCoBan_TextChanged(object sender, EventArgs e)
        {
            if (txtLuongCoBan.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtLuongCoBan, "Không được phép có chữ");
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void txtLuongTheoGio_TextChanged(object sender, EventArgs e)
        {
            if (txtLuongTheoGio.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtLuongTheoGio, "Không được phép có chữ");
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void txtTienThuong_TextChanged(object sender, EventArgs e)
        {
            if (txtTienThuong.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtTienThuong, "Không được phép có chữ");
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void txtLamNgoaiGio_TextChanged(object sender, EventArgs e)
        {
            if (txtLamNgoaiGio.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtLamNgoaiGio, "Không được phép có chữ");
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
            }
        }
    }
}