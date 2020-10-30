using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    class Data_KH
    {
        string time = DateTime.Now.ToString("yyyy/MM/dd");
        string day = DateTime.Now.ToString("dd");
        string Min = DateTime.Now.ToString("mm");
        string sec = DateTime.Now.ToString("ss");

        string Sex;

        Data data = new Data();
        public List<Inf_Customers> Inf_KH()
        {
            List<Inf_Customers> listCustomer = data.Inf_Customers.ToList();
            return listCustomer;
        }

        public bool check_KH(string KH_ID)
        {
            bool check = false;
            Inf_Customers CheckCustomer = data.Inf_Customers.FirstOrDefault(p => p.Customer_Id == KH_ID);
            if (CheckCustomer != null)
            {
                check = true;
            }
            return check;
        }

        public bool Add_KH(string Customer_Name, string Customer_Sex, DateTime Customer_Birth, string Customer_Email, string Customer_Phone)
        {
            if (Customer_Sex == "Nam")
            {
                Sex = "1";
            }
            else
            {
                Sex = "2";
            }
            try
            {
                Inf_Customers Customer = new Inf_Customers
                {
                    Customer_Id = "KH" + day + "" + Min + "" + sec + "",
                    Customer_Name = Customer_Name,
                    Customer_Sex = Sex,
                    Customer_Birth = Customer_Birth,
                    Customer_Email = Customer_Email,
                    Customer_Phone = Customer_Phone,
                    Customer_TimeAdd = time
                };

                data.Inf_Customers.Add(Customer);
                data.SaveChanges();

                Inf_Repair Repair = new Inf_Repair
                {
                    Repair_Id = "RP" + day + "" + Min + "" + sec + "",
                    Customer_Id = "KH" + day + "" + Min + "" + sec + "",
                    Laptop_Name = "Chưa biết",
                    Laptop_Status = "Chưa biết",
                    Staff_Id = "Chưa biết",
                };

                data.Inf_Repair.Add(Repair);
                data.SaveChanges();

                Detail_Inf_Repair Detail = new Detail_Inf_Repair
                {
                    Repair_Id = "RP" + day + "" + Min + "" + sec + "",
                    Repair_Reason = "Chưa biết",
                    Repair_Note = "Sửa lấy ngay",
                    Repair_Appointment = DateTime.Parse("09/05/2000"),
                    Repair_Money = "0"
                };

                data.Detail_Inf_Repair.Add(Detail);
                data.SaveChanges();
                time = DateTime.Now.ToString("yyyy/MM/dd");
                day = DateTime.Now.ToString("dd");
                Min = DateTime.Now.ToString("mm");
                sec = DateTime.Now.ToString("ss");
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Update_KH(string Customer_Name, string Customer_Sex, DateTime Customer_Birth, string Customer_Email, string Customer_Phone, string Customer_Id)
        {
            if (Customer_Sex == "Nam")
            {
                Sex = "1";
            }
            else
            {
                Sex = "2";
            }

            Inf_Customers Customer = data.Inf_Customers.FirstOrDefault(p => p.Customer_Id == Customer_Id);
            if(Customer != null)
            {
                try
                {
                    Customer.Customer_Name = Customer_Name;
                    Customer.Customer_Sex = Sex;
                    Customer.Customer_Birth = Customer_Birth;
                    Customer.Customer_Email = Customer_Email;
                    Customer.Customer_Phone = Customer_Phone;
                    data.SaveChanges();
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Delete_KH(string Customer_Id)
        {
            string repair = (String)Customer_Id;
            string repairID = repair.Substring(2);
            try
            {
                Detail_Inf_Repair Detail = data.Detail_Inf_Repair.FirstOrDefault(p => p.Repair_Id == "RP"+repairID);
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
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
