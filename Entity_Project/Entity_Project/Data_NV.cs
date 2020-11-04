﻿using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project
{
    class Data_NV
    {
        string time = DateTime.Now.ToString("yyyy/MM/dd");
        string day = DateTime.Now.ToString("dd");
        string Min = DateTime.Now.ToString("mm");
        string sec = DateTime.Now.ToString("ss");

        string Sex, PhongBan;

        Data data = new Data();

        public List<Inf_Staff> Inf_Staff()
        {
            List<Inf_Staff> staff = data.Inf_Staff.ToList();
            return staff;
        }

        public bool check_Nv(string NV_ID)
        {
            Inf_Staff CheckStaff = data.Inf_Staff.FirstOrDefault(p => p.Staff_Id == NV_ID);
            if (CheckStaff != null)
            {
                return true;
            }
            return false;
        }

        public bool Add_NV(string Staff_Name, string Staff_Sex, DateTime Staff_Birth, string Staff_Address, string Staff_Phone, string Staff_Department)
        {
            if (Staff_Sex == "Nam")
            {
                Sex = "1";
            }
            else if (Staff_Sex == "Nữ")
            {
                Sex = "2";
            }
            else if (Staff_Sex == "Khác")
            {
                Sex = "3";
            }

            if (Staff_Department == "Quản Lý")
            {
                PhongBan = "1";
            }
            else if (Staff_Department == "Kỹ Thuật")
            {
                PhongBan = "2";
            }
            else if(Staff_Department == "Kế Toán")
            {
                PhongBan = "3";
            }

            try
            {
                Inf_Staff Staff = new Inf_Staff
                {
                    Staff_Id = "NV" + day + "" + Min + "" + sec + "",
                    Staff_Name = Staff_Name,
                    Staff_Sex = Sex,
                    Staff_Birth = Staff_Birth,
                    Staff_Phone = Staff_Phone,
                    Staff_Address = Staff_Address,
                    Staff_Deparment = PhongBan,
                    Staff_TimeAdd = time
                };

                data.Inf_Staff.Add(Staff);
                data.SaveChanges();

                Account_Staff account = new Account_Staff
                {
                    Staff_Id = "NV" + day + "" + Min + "" + sec + "",
                    Staff_Account = "NV" + day + "" + Min + "" + sec + "",
                    Staff_Password = "1",
                    Staff_Role = PhongBan,
                };

                data.Account_Staff.Add(account);
                data.SaveChanges();

                Salary_Staff salary = new Salary_Staff
                {
                    Staff_Id = "NV" + day + "" + Min + "" + sec + "",
                    Staff_Default_Salary = "0",
                    Staff_OT = "0",
                    Staff_Reward = "0",
                    Staff_Salary_Per_Hour = "0"
                };

                data.Salary_Staff.Add(salary);
                data.SaveChanges();

                time = DateTime.Now.ToString("yyyy/MM/dd");
                day = DateTime.Now.ToString("dd");
                Min = DateTime.Now.ToString("mm");
                sec = DateTime.Now.ToString("ss");
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Update_NV(string Staff_Name, string Staff_Sex, DateTime Staff_Birth, string Staff_Address, string Staff_Phone, string Staff_Deparment, string Staff_Id)
        {
            if (Staff_Sex == "Nam")
            {
                Sex = "1";
            }
            else if(Staff_Sex == "Nữ")
            {
                Sex = "2";
            }
            else if (Staff_Sex == "Khác")
            {
                Sex = "3";
            }

            if (Staff_Deparment == "Quản Lý")
            {
                PhongBan = "1";
            }
            else if (Staff_Deparment == "Kỹ Thuật")
            {
                PhongBan = "2";
            }
            else if (Staff_Deparment == "Kế Toán")
            {
                PhongBan = "3";
            }

            Inf_Staff Staff = data.Inf_Staff.FirstOrDefault(p => p.Staff_Id == Staff_Id);
            if (Staff != null)
            {
                try
                {
                    Staff.Staff_Name = Staff_Name;
                    Staff.Staff_Sex = Sex;
                    Staff.Staff_Birth = Staff_Birth;
                    Staff.Staff_Address = Staff_Address;
                    Staff.Staff_Phone = Staff_Phone;
                    Staff.Staff_Deparment = PhongBan;
                    data.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Delete_NV(string Staff_Id)
        {
            try
            {
                Account_Staff account = data.Account_Staff.FirstOrDefault(p => p.Staff_Id == Staff_Id);
                if (account != null)
                {
                    data.Account_Staff.Remove(account);
                    data.SaveChanges();
                }

                Salary_Staff salary = data.Salary_Staff.FirstOrDefault(p => p.Staff_Id == Staff_Id);
                if (salary != null)
                {
                    data.Salary_Staff.Remove(salary);
                    data.SaveChanges();
                }

                Inf_Staff Inf_Staff = data.Inf_Staff.FirstOrDefault(p => p.Staff_Id == Staff_Id);
                if (Inf_Staff != null)
                {
                    data.Inf_Staff.Remove(Inf_Staff);
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