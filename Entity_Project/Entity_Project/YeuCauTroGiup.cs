using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class YeuCauTroGiup : DevExpress.XtraEditors.XtraForm
    {
        public YeuCauTroGiup()
        {
            InitializeComponent();
        }

        string id, name;
        public YeuCauTroGiup(string id, string name):this()
        {
            this.id = id;
            this.name = name;
        }

        private void YeuCauTroGiup_Load(object sender, EventArgs e)
        {
            txtDoi.Hide();
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn gửi thư yêu cầu trợ giúp không?", "Xác nhận gửi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    txtDoi.Show();
                    Task.Delay(3000);
                    var thread = new Thread(() => sendMail(name, id, txtNoiDung.Text));
                    thread.Start();
                    txtDoi.Hide();
                }
            }
        }

        private static void sendMail(string Name, string Id, string Content)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("herroseven@gmail.com", "@#Taitutoi952000@#");
                MailMessage message = new MailMessage("herroseven@gmail.com", "nguyenphatthanhtai@gmail.com");
                message.Subject = "Thông báo về việc yêu cầu sửa chữa phần mềm !";
                message.Body = "<h5><b>Nhân viên yêu cầu</b>: " + Name + "</h5>" +
                    "           <h5><b>Mã nhân viên</b>: " + Id + "</h5>" +
                    "           <h5><b>Nội dung</b>: " + Content + "</h5>";
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;
                mailclient.Send(message);
                MessageBox.Show("Mail yêu cầu sửa đã được gửi đi, chúng tôi sẽ cố gắng phản hồi sớm nhất", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}