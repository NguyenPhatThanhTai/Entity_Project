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

namespace Entity_Project
{
    public partial class PhanQuyenVaTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public PhanQuyenVaTaiKhoan()
        {
            InitializeComponent();
        }

        Data_NV DNV;
        string quyen;

        private void PhanQuyenVaTaiKhoan_Load(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            Load_Account(DNV.Account_Staff());
        }

        private void Load_Account(List<Account_Staff> Account_Staff)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Account_Staff)
            {
                if (item.Staff_Role.ToString() == "1")
                {
                    quyen = "Quản Lý";
                }
                else
                {
                    quyen = "Nhân Viên";
                }

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Staff_Id;
                Data.Rows[index].Cells[2].Value = item.Inf_Staff.Staff_Name;
                Data.Rows[index].Cells[3].Value = item.Staff_Account;
                Data.Rows[index].Cells[4].Value = item.Staff_Password;
                Data.Rows[index].Cells[5].Value = quyen;
                i++;
            }
            Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtRole.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn cập nhật mục này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (DNV.Update_Account(txtPassword.Text, txtRole.Text,  txtMaNv.Text))
                    {
                        if (Properties.Settings.Default.UserName == txtMaNv.Text)
                        {
                            Properties.Settings.Default.Password = txtPassword.Text;
                            Properties.Settings.Default.Save();
                        }
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Account(DNV.Account_Staff());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Load_Account(DNV.Account_Staff());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear()
        {
            openButton(true);
            txtMaNv.Text = "";
            txtTenNhanVien.Text = "";
            txtPassword.Text = "";
            txtAccount.Text = "";
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            Data_NV DNV = new Data_NV();
            Load_Account(DNV.Account_Staff());
            Clear();
        }

        private void openButton(bool a)
        {
            btnUpdate.Enabled = !a;
            Data.Enabled = a;
            txtPassword.Enabled = !a;
            txtAccount.Enabled = !a;
            txtRole.Enabled = !a;
        }

        private void Data_Click(object sender, EventArgs e)
        {
            if (Data.Rows.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                openButton(false);
                txtMaNv.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
                txtTenNhanVien.Text = Data.SelectedRows[0].Cells[2].Value.ToString();
                txtAccount.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
                txtPassword.Text = Data.SelectedRows[0].Cells[4].Value.ToString();
                txtRole.Text = Data.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void PhanQuyenVaTaiKhoan_Enter(object sender, EventArgs e)
        {
            Data_NV DNV = new Data_NV();
            Load_Account(DNV.Account_Staff());
        }
    }
}