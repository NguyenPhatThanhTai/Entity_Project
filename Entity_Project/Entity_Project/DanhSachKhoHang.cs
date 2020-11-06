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
            foreach (var item in DLK.Inf_WareHouse())
            {
                txtMaKhoHang.Items.Add(item.WareHouse_Id);
            }
            Load_KHA(DLK.Inf_WareHouse());
            Load_LK(DLK.FillByWareHouse(txtMaKhoHang.Text));
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
            if (txtTenLinhKien.Text != "" && txtSoLuong.Text != "" && txtNhaSanXuat.Text != "" && txtPrice.Text != "" && txtMaKhoHang.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm linh kiện " + txtTenLinhKien.Text + " của nhà sản xuất: " + txtNhaSanXuat.Text + " vào kho hàng "+ txtMaKhoHang.Text +" không !", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if(DLK.Add_LK(txtTenLinhKien.Text, txtSoLuong.Text, txtNhaSanXuat.Text, txtPrice.Text, txtMaKhoHang.Text))
                    {
                        MessageBox.Show("Thêm linh kiện vào kho" + txtMaKhoHang.Text + " thành công");
                        Load_KHA(DLK.Inf_WareHouse());
                        Load_LK(DLK.Inf_LK());
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                        Load_KHA(DLK.Inf_WareHouse());
                        Load_LK(DLK.Inf_LK());
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
            if (txtTenLinhKien.Text != "" && txtSoLuong.Text != "" && txtNhaSanXuat.Text != "" && txtPrice.Text != "" && txtMaKhoHang.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận cập nhật", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (DLK.Update_LK(txtTenLinhKien.Text, txtSoLuong.Text, txtNhaSanXuat.Text, txtPrice.Text, txtMaKhoHang.Text, txtMaLinhKien.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        Load_KHA(DLK.Inf_WareHouse());
                        Load_LK(DLK.Inf_LK());
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                        Load_KHA(DLK.Inf_WareHouse());
                        Load_LK(DLK.Inf_LK());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLinhKien.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Xác nhận xóa", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (DLK.Delete_LK(txtMaLinhKien.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        Load_KHA(DLK.Inf_WareHouse());
                        Load_LK(DLK.Inf_LK());
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                        Load_KHA(DLK.Inf_WareHouse());
                        Load_LK(DLK.Inf_LK());
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn");
            }
        }

        private void Btn_ReFresh_Click(object sender, EventArgs e)
        {
            Load_KHA(DLK.Inf_WareHouse());
            Load_LK(DLK.FillByWareHouse(txtMaKhoHang.Text));
            openButton(true);
            clear();
        }

        private void openButton(bool a)
        {
            btnThem.Enabled = a;
            Btn_ReFresh.Enabled = a;
            btnUpdate.Enabled = !a;
            btnDelete.Enabled = !a;
            txtNhaSanXuat.Enabled = a;
            txtPrice.Enabled = a;
            txtSoLuong.Enabled = a;
            txtTenLinhKien.Enabled = a;
        }

        private void clear()
        {
            txtTenLinhKien.Text = "";
            txtMaLinhKien.Text = "";
            txtNhaSanXuat.Text = "";
            txtPrice.Text = "";
            txtSoLuong.Text = "";
        }

        private void Data_Click(object sender, EventArgs e)
        {
            openButton(true);
            txtMaKhoHang.Text = Data.SelectedRows[0].Cells[1].Value.ToString();
            Load_LK(DLK.FillByWareHouse(txtMaKhoHang.Text));
        }

        private void Data1_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnThem.Enabled = false;
            txtMaLinhKien.Text = Data1.SelectedRows[0].Cells[1].Value.ToString();
            txtTenLinhKien.Text = Data1.SelectedRows[0].Cells[3].Value.ToString();
            txtSoLuong.Text = Data1.SelectedRows[0].Cells[4].Value.ToString();
            txtNhaSanXuat.Text = Data1.SelectedRows[0].Cells[5].Value.ToString();
            txtPrice.Text = Data1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtSoLuong, "Không được phép có chữ");
                btnUpdate.Enabled = false;
                btnThem.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnThem.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text.All(char.IsDigit) == false)
            {
                errorProvider1.SetError(txtPrice, "Không được phép có chữ");
                btnUpdate.Enabled = false;
                btnThem.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnThem.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
    }
}