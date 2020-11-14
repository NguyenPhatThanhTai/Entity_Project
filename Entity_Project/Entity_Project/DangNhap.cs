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
        int check;
        int numberCheck = 1;
        double second = 30;

        private void DangNhap_Load(object sender, EventArgs e)
        {
            DNV = new Data_NV();
            pbCheck.Hide();
            lbCheck.Hide();
            txtSoLanDN.Hide();
            txtQuaSoLan.Hide();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = false;
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
                    btnDangNhap.Enabled = true;
                    pbCheck.Hide();
                    lbCheck.Hide();
                    txtSoLanDN.Show();
                    check += 1;
                    txtSoLanDN.Text = "Lần thử thứ " + check +"/5";
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (check == 5)
                    {
                        second = second * numberCheck;
                        btnDangNhap.Enabled = false;
                        timer1.Interval = 1000;
                        timer1.Start();
                    }
                }
            }
            else
            {
                btnDangNhap.Enabled = true;
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtQuaSoLan.Show();
            txtQuaSoLan.Text = "Bạn đã thử quá số lần quy định, vui lòng đợi " + (second -= 1) + " giây để thử lại";
            if (second == 0)
            {
                timer1.Stop();
                btnDangNhap.Enabled = true;
                txtSoLanDN.Hide();
                txtQuaSoLan.Hide();
                numberCheck += 1;
                second = 30;
                check = 0;
            }
        }
    }
}