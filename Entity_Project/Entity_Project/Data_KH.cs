using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project
{
    class Data_KH
    {
        public List<Inf_Customers> Inf_KH()
        {
            Data data = new Data();
            List<Inf_Customers> listCustomer = data.Inf_Customers.ToList();
            return listCustomer;
        }


    }
}
