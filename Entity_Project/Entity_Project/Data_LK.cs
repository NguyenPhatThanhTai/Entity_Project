using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project
{
    class Data_LK
    {
        Data data = new Data();
        string time = DateTime.Now.ToString("yyyy/MM/dd");
        string day = DateTime.Now.ToString("dd");
        string Min = DateTime.Now.ToString("mm");
        string sec = DateTime.Now.ToString("ss");
        public List<Inf_WareHouse> Inf_WareHouse()
        {
            List<Inf_WareHouse> list = data.Inf_WareHouse.ToList();
            return list;
        }

        public List<Inf_LK> Inf_LK()
        {
            List<Inf_LK> list = data.Inf_LK.ToList();
            return list;
        }

        public List<Inf_LK> FillByWareHouse(string WareHouse_Id)
        {
            List<Inf_LK> list = data.Inf_LK.Where(p => p.WareHouse_Id == WareHouse_Id).ToList();
            return list;
        }

        public bool Add_LK(string LK_Name, string LK_Number, string LK_Producer, string LK_Price, string WareHouse_Id)
        {
            try
            {
                Inf_LK lk = new Inf_LK()
                {
                    LK_Id = "LK" + day + "" + Min + "" + sec,
                    LK_Name = LK_Name,
                    LK_Number = LK_Number,
                    LK_Producer = LK_Producer,
                    LK_Price = LK_Price,
                    LK_Time_Add = time,
                    WareHouse_Id = WareHouse_Id
                };
                data.Inf_LK.Add(lk);
                data.SaveChanges();
                time = DateTime.Now.ToString("dd/MM/yyyy");
                day = DateTime.Now.ToString("dd");
                Min = DateTime.Now.ToString("mm");
                sec = DateTime.Now.ToString("ss");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update_LK(string LK_Name, string LK_Number, string LK_Producer, string LK_Price, string WareHouse_Id, string LK_Id)
        {
            try
            {
                Inf_LK lk = data.Inf_LK.FirstOrDefault(p => p.LK_Id == LK_Id);
                if (lk != null)
                {
                    lk.LK_Name = LK_Name;
                    lk.LK_Number = LK_Number;
                    lk.LK_Producer = LK_Producer;
                    lk.LK_Price = LK_Price;
                    lk.WareHouse_Id = WareHouse_Id;

                    data.SaveChanges();
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete_LK(string LK_Id)
        {
            try
            {
                Inf_LK lk = data.Inf_LK.FirstOrDefault(p => p.LK_Id == LK_Id);
                if(lk != null)
                {
                    data.Inf_LK.Remove(lk);

                    data.SaveChanges();
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
