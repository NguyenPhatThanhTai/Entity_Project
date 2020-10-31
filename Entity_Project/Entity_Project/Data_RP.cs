using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    class Data_RP
    {
        int i = 0;
        string Name;
        Data data = new Data();

        public List<Inf_Repair> Inf_Repair()
        {
            List<Inf_Repair> repair = data.Inf_Repair.ToList();
            return repair;
        }

        public bool Update_NhanDon(string name, string Repair_Id)
        {
            Inf_Repair repair = data.Inf_Repair.FirstOrDefault(p => p.Repair_Id == Repair_Id);
            if(repair != null)
            {
                repair.Staff_Id = name;
                data.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update_RP(string Laptop_Name, string Laptop_Status, string Repair_Reason, string Repair_Note, DateTime Repair_Appointment, string Repair_Money, string Repair_Id)
        {
            Inf_Repair repair = data.Inf_Repair.FirstOrDefault(p => p.Repair_Id == Repair_Id);
            if(repair != null)
            {
                repair.Laptop_Name = Laptop_Name;
                repair.Laptop_Status = Laptop_Status;
                repair.Detail_Inf_Repair.Repair_Reason = Repair_Reason;
                repair.Detail_Inf_Repair.Repair_Note = Repair_Note;
                repair.Detail_Inf_Repair.Repair_Appointment = Repair_Appointment;
                repair.Detail_Inf_Repair.Repair_Money = Repair_Money;
                data.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Done_RP(string Repair_Id, string Laptop_Name, string Repair_Reason, string Repair_Money, string Repair_Appoinment)
        {
            Inf_Repair repair = data.Inf_Repair.FirstOrDefault(p => p.Repair_Id == Repair_Id);
            if(repair != null)
            {
                
            }
        }

        private static void sendMail(string NameTo, string EmailTo, string SDTTo, string Laptop_Name, string Repair_Reason, string Repair_Money)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("herroseven@gmail.com", "@#Taitutoi952000@#");
                MailMessage message = new MailMessage("herroseven@gmail.com", EmailTo);
                message.Subject = "Thông báo hoàn tất việc sửa laptop !";
                message.Body = "<h3><b>Trân trọng gửi đến quý khách hàng : </b>" + NameTo + "</h3>" +
                    "           <h5><b>Số điện thoại</b>: " + SDTTo + "</h5>" +
                    "           <h5><b>Tên laptop</b>: " + Laptop_Name + "</h5>" +
                    "           <h5><b>Chi tiết sửa</b>: " + Repair_Reason + "</h5>" +
                    "           <h5><b>Số tiền</b>: " + String.Format("{0:#,###} VND", int.Parse(Repair_Money)) + "</h5>" +
                    "           <h5><strong>Lưu ý: </strong> <i>Khi đến quý khách vui lòng đem đúng số tiền là <b>" + String.Format("{0:#,###} VND", int.Parse(Repair_Money)) + "</b> và phiếu hẹn để thanh toán</i><h5> <br>" +
                    "           <h3><b>Trân trọng thông báo cho quý khách !<b><h3>";
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;
                mailclient.Send(message);
                MessageBox.Show("Mail hẹn nhận máy đã được gửi đi cho khách hàng: " + NameTo + "", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail");
            }
        }
    }
}
