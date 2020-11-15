using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Entity_Project
{
    class Data_RP
    {
        int i = 0;
        string Name;
        Data data = new Data();
        string time = DateTime.Now.ToString("yyyy/MM/dd");
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
                try
                {
                    data.SaveChanges();
                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
                return true;
                }
            return false;
        }

        public List<Inf_Repair> FindBy_ID(string id)
        {
            string repairid = (String)id;
            List<Inf_Repair> repair = data.Inf_Repair.Where(p => p.Repair_Id == repairid).ToList();
            return repair;
        }

        public bool Done_RP(string Repair_Id, string note)
        {
            data = new Data();
            Inf_Repair repair = data.Inf_Repair.FirstOrDefault(p => p.Repair_Id == Repair_Id);
            if(repair != null)
            {
                if (note.ToString() == "Hẹn ngày lấy")
                {
                    string NameTo = repair.Inf_Customers.Customer_Name;
                    string EmailTo = repair.Inf_Customers.Customer_Email;
                    string SDTTo = repair.Inf_Customers.Customer_Phone;
                    string Laptop_Name = repair.Laptop_Name;
                    string Repair_Reason = repair.Detail_Inf_Repair.Repair_Reason;
                    string Repair_Money = repair.Detail_Inf_Repair.Repair_Money;
                    try
                    {
                        var thread = new Thread(() => sendMail(NameTo, EmailTo, SDTTo, Laptop_Name, Repair_Reason, Repair_Money));
                        thread.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi gửi mail");
                    }
                }
                Inf_LichSu ls = new Inf_LichSu()
                {
                    Customer_Name = repair.Inf_Customers.Customer_Name,
                    Customer_Id = repair.Inf_Customers.Customer_Id,
                    Customer_Sex = repair.Inf_Customers.Customer_Sex,
                    Customer_Birth = repair.Inf_Customers.Customer_Birth,
                    Customer_Email = repair.Inf_Customers.Customer_Email,
                    Customer_Phone = repair.Inf_Customers.Customer_Phone,
                    Customer_TimeAdd = repair.Inf_Customers.Customer_TimeAdd,
                    Repair_Id = repair.Repair_Id,
                    Laptop_Name = repair.Laptop_Name,
                    Laptop_Status = repair.Laptop_Status,
                    Staff_Id = repair.Staff_Id,
                    Repair_Appointment = repair.Detail_Inf_Repair.Repair_Appointment,
                    Repair_Money = repair.Detail_Inf_Repair.Repair_Money,
                    Repair_Note = repair.Detail_Inf_Repair.Repair_Note,
                    Repair_Reason = repair.Detail_Inf_Repair.Repair_Reason,
                    Repair_Time_End = DateTime.Parse(time)
                };
                data.Inf_LichSu.Add(ls);
                data.SaveChanges();
                return true;
            }
            return false;
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
                    "           <h5><b>Ghi chú</b>: " + Repair_Reason + "</h5>" +
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
                MessageBox.Show(ex.Message);
            }
        }

        public List<Inf_LichSu> LichSu()
        {
            List<Inf_LichSu> LS = data.Inf_LichSu.ToList();
            return LS;
        }

        public bool Delete_KH(string Customer_Id)
        {
            string repair = (String)Customer_Id;
            string repairID = repair.Substring(2);
            try
            {
                Detail_Inf_Repair Detail = data.Detail_Inf_Repair.FirstOrDefault(p => p.Repair_Id == "RP" + repairID);
                if (Detail != null)
                {
                    data.Detail_Inf_Repair.Remove(Detail);
                    data.SaveChanges();
                }

                Inf_Repair Repair = data.Inf_Repair.FirstOrDefault(p => p.Customer_Id == Customer_Id);
                if (Repair != null)
                {
                    data.Inf_Repair.Remove(Repair);
                    data.SaveChanges();
                }

                Inf_Customers Customer = data.Inf_Customers.FirstOrDefault(p => p.Customer_Id == Customer_Id);
                if (Customer != null)
                {
                    data.Inf_Customers.Remove(Customer);
                    data.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
