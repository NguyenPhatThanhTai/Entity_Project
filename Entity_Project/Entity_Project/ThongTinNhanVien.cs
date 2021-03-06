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
    public partial class ThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Data_NV DNV;
        string Sex, PhongBan, Role, Name, Id;
        bool loi;

        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        public ThongTinNhanVien(string Role, string Name, string Id):this()
        {
            this.Role = Role;
            this.Name = Name;
            this.Id = Id;
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            Load_NV(DNV.Inf_Staff());
        }

        private void Load_NV(List<Inf_Staff> Inf_Staff)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Inf_Staff)
            {
                if (item.Staff_Sex.ToString() == "1")
                {
                    Sex = "Nam";
                }
                else if (item.Staff_Sex.ToString() == "2")
                {
                    Sex = "Nữ";
                }
                else if(item.Staff_Sex.ToString() == "3")
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
                else if(item.Staff_Deparment.ToString() == "3")
                {
                    PhongBan = "Kế Toán";
                }

                var date1 = DateTime.Parse(item.Staff_Birth.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Staff_Id;
                Data.Rows[index].Cells[2].Value = item.Staff_Name;
                Data.Rows[index].Cells[3].Value = Sex;
                Data.Rows[index].Cells[4].Value = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[5].Value = item.Staff_Address;
                Data.Rows[index].Cells[6].Value = item.Staff_Phone;
                Data.Rows[index].Cells[7].Value = PhongBan;
                Data.Rows[index].Cells[8].Value = item.Staff_TimeAdd;
                i++;
            }
            Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtDate.Text != "" && txtDepartment.Text != ""
                                && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm nhân viên " + txtHoTen.Text + " ở phòng ban " + txtDepartment.Text +" không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (!DNV.check_Nv(txtMaNv.Text))
                    {
                        if (DNV.Add_NV(txtHoTen.Text, txtGioiTinh.Text, txtDate.Value, txtDiaChi.Text, txtSDT.Text, txtDepartment.Text))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DNV = new Data_NV();
                            Load_NV(DNV.Inf_Staff());
                            openButton(true);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DNV = new Data_NV();
                            Load_NV(DNV.Inf_Staff());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtDate.Text != "" && txtDepartment.Text != ""
                                && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn cập nhật mục này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (DNV.Update_NV(txtHoTen.Text, txtGioiTinh.Text, txtDate.Value, txtDiaChi.Text, txtSDT.Text, txtDepartment.Text, txtMaNv.Text))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DNV = new Data_NV();
                        Load_NV(DNV.Inf_Staff());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DNV = new Data_NV();
                        Load_NV(DNV.Inf_Staff());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtDate.Text != "" && txtDepartment.Text != ""
                                && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + txtHoTen.Text + " ở phòng ban " + txtDepartment.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (DNV.Delete_NV(txtMaNv.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DNV = new Data_NV();
                        Load_NV(DNV.Inf_Staff());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DNV = new Data_NV();
                        Load_NV(DNV.Inf_Staff());
                    }
                }
            }
        }

        private void ThongTinNhanVien_Enter(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            Load_NV(DNV.Inf_Staff());
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
                if (txtSDT.Text.All(char.IsDigit) == false || txtSDT.TextLength < 9 || txtSDT.TextLength > 13)
                {
                    errorProvider1.SetError(txtSDT, "Chỉ cho phép số và số điện thoại tối thiểu phải lớn hơn 9 và bé hơn 13 kí tự số");
                if (loi)
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = false;
                }
            }
                else
                {
                    errorProvider1.Clear();
                if (loi)
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnThem.Enabled = true;
                }
            }
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            if (txtDate.Value > DateTime.Now.Date)
            {
                errorProvider1.SetError(txtDate, "Ngày sinh phải bé hơn ngày hiện hành");
                if (loi)
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = false;
                }
            }
            else
            {
                errorProvider1.Clear();
                if (loi)
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnThem.Enabled = true;
                }
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            loi = true;
            openButton(false);
            if (Data.Rows.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Id == Data.SelectedRows[0].Cells[1].Value.ToString())
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                txtMaNv.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
                txtHoTen.Text = Data.SelectedRows[0].Cells[2].Value.ToString();
                txtGioiTinh.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
                txtDate.Value = DateTime.Parse((string)Data.SelectedRows[0].Cells[4].Value);
                txtDiaChi.Text = Data.SelectedRows[0].Cells[5].Value.ToString();
                txtSDT.Text = Data.SelectedRows[0].Cells[6].Value.ToString();
                txtDepartment.Text = Data.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void Clear()
        {
            openButton(true);
            txtMaNv.Text = "Chưa thiết lập";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "Nam";
            txtDate.Value = DateTime.Now;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtDepartment.Text = "Quản Lý";
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            Data_NV DNV = new Data_NV();
            Load_NV(DNV.Inf_Staff());
            Clear();
            loi = false;
        }

        private void openButton(bool a)
        {
            btnThem.Enabled = a;
            btnUpdate.Enabled = !a;
            btnDelete.Enabled = !a;
            Data.Enabled = a;
        }
    }
}