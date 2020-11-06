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
    public partial class NhanMayBaoGia : DevExpress.XtraEditors.XtraForm
    {
        public NhanMayBaoGia()
        {
            InitializeComponent();
        }

        Data_RP DRP;
        string role, Name;

        public NhanMayBaoGia(string role, string Name):this()
        {
            this.role = role;
            this.Name = Name;
        }

        private void NhanMayBaoGia_Load(object sender, EventArgs e)
        {
            DRP = new Data_RP();
            Load_RP(DRP.Inf_Repair());
        }

        private void Load_RP(List<Inf_Repair> Inf_Repair)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Inf_Repair)
            {
                var date1 = DateTime.Parse(item.Detail_Inf_Repair.Repair_Appointment.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value  = i;
                Data.Rows[index].Cells[1].Value  = item.Repair_Id;
                Data.Rows[index].Cells[2].Value  = item.Inf_Customers.Customer_Name;
                Data.Rows[index].Cells[3].Value  = item.Laptop_Name;
                Data.Rows[index].Cells[4].Value  = item.Laptop_Status;
                Data.Rows[index].Cells[5].Value  = item.Detail_Inf_Repair.Repair_Reason;
                Data.Rows[index].Cells[6].Value  = item.Detail_Inf_Repair.Repair_Note;
                Data.Rows[index].Cells[7].Value  = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[8].Value  = item.Detail_Inf_Repair.Repair_Money;
                Data.Rows[index].Cells[9].Value = item.Staff_Id;
                i++;
            }
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            openButton(true);
            Data_RP DRP = new Data_RP();
            Load_RP(DRP.Inf_Repair());
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (Data.SelectedRows[0].Cells[9].Value.ToString() == Name)
            {
                openButton(false);
                MessageBox.Show("Đã tiếp tục đơn !");
            }
            else
            {
                if (Data.SelectedRows[0].Cells[9].Value.ToString() != "Chưa biết")
                {
                    MessageBox.Show("Đơn này đã có nhân viên " + Data.SelectedRows[0].Cells[9].Value.ToString() + " tiếp nhận rồi, vui lòng chọn đơn khác");
                    DRP = new Data_RP();
                    Load_RP(DRP.Inf_Repair());
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận nhận đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        openButton(false);
                        if(DRP.Update_NhanDon(Name, txtMaSuaChua.Text))
                        {
                            DRP = new Data_RP();
                            Load_RP(DRP.Inf_Repair());
                            txtNVTN.Text = Name;
                        }
                    }
                    else
                    {
                        openButton(true);
                    }
                }
            }
        }

        private void openButton(bool a)
        {
            btnTiepNhan.Enabled = a;
            btnUpdate.Enabled = !a;
            Data.Enabled = a;
            txtTenMay.Enabled = !a;
            txtTinhTrang.Enabled = !a;
            txtHenSua.Enabled = !a;
            txtDateHen.Enabled = !a;
            txtSoTien.Enabled = !a;
            txtCanSua.Enabled = !a;
        }

        private void Data_Click(object sender, EventArgs e)
        {
            openButton(true);
            if(Data.SelectedRows[0].Cells[9].Value.ToString() == Name)
            {
                btnTiepNhan.Text = "Tiếp tục đơn";
            }
            else
            {
                btnTiepNhan.Text = "Tiếp nhận đơn";
            }
            txtMaSuaChua.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
            txtTenKhachHang.Text = Data.SelectedRows[0].Cells[2].Value.ToString();
            txtTenMay.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
            txtTinhTrang.Text = Data.SelectedRows[0].Cells[3].Value.ToString();
            txtCanSua.Text = Data.SelectedRows[0].Cells[5].Value.ToString();
            txtHenSua.Text = Data.SelectedRows[0].Cells[6].Value.ToString();
            txtDateHen.Value = DateTime.Parse((string)Data.SelectedRows[0].Cells[7].Value);
            txtSoTien.Text = Data.SelectedRows[0].Cells[8].Value.ToString();
            txtNVTN.Text = Data.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void NhanMayBaoGia_Enter(object sender, EventArgs e)
        {
            Data_RP DRP = new Data_RP();
            Load_RP(DRP.Inf_Repair());
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTien.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtSoTien, "Không được phép có chữ");
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenMay.Text != "" && txtTinhTrang.Text != "" && txtHenSua.Text != "" && txtDateHen.Text != "" && txtSoTien.Text != "" && txtSoTien.Text != "" && txtCanSua.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận cập nhật ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (DRP.Update_RP(txtTenMay.Text, txtTinhTrang.Text, txtCanSua.Text, txtHenSua.Text, txtDateHen.Value, txtSoTien.Text, txtMaSuaChua.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        DRP = new Data_RP();
                        Load_RP(DRP.Inf_Repair());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}