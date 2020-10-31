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
    }
}
