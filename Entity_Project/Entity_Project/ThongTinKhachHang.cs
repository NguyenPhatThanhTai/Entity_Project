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
            Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (Data.Rows.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có khách hàng nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                if (txtHoTen.Text != "" && txtEmail.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtBirth.Text != "" && txtEmail.Text != ""
                                && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm khách hàng " + txtHoTen.Text + " không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (!DKH.check_KH(txtMaKhachHang.Text))
                    {
                        if(DKH.Add_KH(txtHoTen.Text, txtGioiTinh.Text, txtBirth.Value, txtEmail.Text, txtSDT.Text))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DKH = new Data_KH();
                            Load_KH(DKH.Inf_KH());
                            openButton(true);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DKH = new Data_KH();
                            Load_KH(DKH.Inf_KH());
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
            if (txtHoTen.Text != "" && txtEmail.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "" && txtBirth.Text != "" && txtEmail.Text != ""
                    && txtSDT.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắn chắn muốn cập nhật khách hàng " + txtHoTen.Text + " không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (DKH.Update_KH(txtHoTen.Text, txtGioiTinh.Text, txtBirth.Value, txtEmail.Text, txtSDT.Text, txtMaKhachHang.Text))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DKH = new Data_KH();
                        Load_KH(DKH.Inf_KH());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult dialog = MessageBox.Show("Bạn có chắn chắn muốn xóa khách hàng " + txtHoTen.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes)
                {
                    if (DKH.Delete_KH(txtMaKhachHang.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DKH = new Data_KH();
                        Load_KH(DKH.Inf_KH());
                        openButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(txtSDT.Text.All(char.IsDigit) == false || txtSDT.TextLength < 9 || txtSDT.TextLength > 13)
            {
                errorProvider1.SetError(txtSDT, "Chỉ cho phép số và số điện thoại tối thiểu phải lớn hơn 9 và bé hơn 13 kí tự số");
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
                errorProvider1.SetError(txtEmail, "Định dạng chưa đúng");
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

        private void ThongTinKhachHang_Activated(object sender, EventArgs e)
        {
            DKH = new Data_KH();
            Load_KH(DKH.Inf_KH());
        }
    }
}