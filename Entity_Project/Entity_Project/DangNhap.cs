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

namespace Entity_Project
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        Data_NV DNV;

        private void DangNhap_Load(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            pbCheck.Hide();
            lbCheck.Hide();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Account = txtAccount.Text;
            string Password = txtPassword.Text;
            if (Account != "" && Password != "")
            {
                pbCheck.Show();
                lbCheck.Show();
                await Task.Delay(2000);
                if (DNV.Login(txtAccount.Text, txtPassword.Text))
                {
                    MainForm form = new MainForm(DNV.getRole(txtAccount.Text), DNV.getName(txtAccount.Text), txtAccount.Text);
                    form.Show();
                    this.Hide();
                    if (Ckb_SaveMyPass.Checked)
                    {
                        Properties.Settings.Default.UserName = txtAccount.Text;
                        Properties.Settings.Default.Password = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    pbCheck.Hide();
                    lbCheck.Hide();
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn thoát à?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}