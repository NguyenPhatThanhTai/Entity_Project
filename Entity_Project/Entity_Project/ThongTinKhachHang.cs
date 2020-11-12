﻿using System;
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
using System.Net.Mail;

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
                else if(item.Customer_Sex.ToString() == "3")
                {
                    Sex = "Khác";
                }

                var date1 = DateTime.Parse(item.Customer_Birth.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Customer_Id;
                Data.Rows[index].Cells[2].Value = item.Customer_Name;
                Data.Rows[index].Cells[3].Value = Sex;
                Data.Rows[index].Cells[4].Value = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[5].Value = item.Customer_Email;
                Data.Rows[index].Cells[6].Value = item.Customer_Phone;
                Data.Rows[index].Cells[7].Value = item.Customer_TimeAdd;
                i++;
            }
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            Data_KH DKH = new Data_KH();
            Load_KH(DKH.Inf_KH());
            Clear();
        }

        private void Clear()
        {
            openButton(true);
            txtMaKhachHang.Text = "Chưa thiết lập";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "Nam";
            txtBirth.Value = DateTime.Now;
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtThoiGian.Text = "";
        }

        private void openButton(bool a)
        {
            btnThem.Enabled = a;
            btnUpdate.Enabled = !a;
            btnDelete.Enabled = !a;
            Data.Enabled = a;
        }

        private void Data_Click(object sender, EventArgs e)
        {
            openButton(false);
            txtMaKhachHang.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
            txtHoTen.Text = Data.SelectedRows[0].Cells[2].Value.ToString();
            txtGioiTinh.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
            txtBirth.Value = DateTime.Parse((string)Data.SelectedRows[0].Cells[4].Value);
            txtEmail.Text = Data.SelectedRows[0].Cells[5].Value.ToString();
            txtSDT.Text = Data.SelectedRows[0].Cells[6].Value.ToString();
            txtThoiGian.Text = Data.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtEmail.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtBirth.Text != "" && txtEmail.Text != ""
                                && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận thêm khách hàng " + txtHoTen.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (!DKH.check_KH(txtMaKhachHang.Text))
                    {
                        if(DKH.Add_KH(txtHoTen.Text, txtGioiTinh.Text, txtBirth.Value, txtEmail.Text, txtSDT.Text))
                        {
                            MessageBox.Show("Thêm thành công");
                            DKH = new Data_KH();
                            Load_KH(DKH.Inf_KH());
                            openButton(true);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại");
                            DKH = new Data_KH();
                            Load_KH(DKH.Inf_KH());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtEmail.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtBirth.Text != "" && txtEmail.Text != ""
                    && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận cập nhật ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (DKH.Update_KH(txtHoTen.Text, txtGioiTinh.Text, txtBirth.Value, txtEmail.Text, txtSDT.Text, txtMaKhachHang.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        DKH = new Data_KH();
                        Load_KH(DKH.Inf_KH());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        DKH = new Data_KH();
                        Load_KH(DKH.Inf_KH());
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtEmail.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtBirth.Text != "" && txtEmail.Text != ""
        && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (DKH.Delete_KH(txtMaKhachHang.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        DKH = new Data_KH();
                        Load_KH(DKH.Inf_KH());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void ThongTinKhachHang_Enter(object sender, EventArgs e)
        {
            DKH = new Data_KH();
            Load_KH(DKH.Inf_KH());
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if(txtSDT.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtSDT, "Không được phép có chữ");
                btnThem.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
                btnThem.Enabled = true;
            }
        }

        private bool checkEmail(string Email)
        {
            bool isChecked;
            try
            {
                string email = Email;
                var mail = new MailAddress(email);
                bool isValidEmail = mail.Host.Contains(".");
                if (!isValidEmail)
                {
                    isChecked = false;
                }
                else
                {
                    isChecked = true;
                }
            }
            catch (Exception)
            {
                isChecked = false;
            }
            return isChecked;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (checkEmail(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Sai định dạng");
                btnThem.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
                btnThem.Enabled = true;
            }
        }
    }
}