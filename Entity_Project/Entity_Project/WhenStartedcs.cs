using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project
{
    class WhenStartedcs
    {
        Data_NV DNV = new Data_NV();
        public void check()
        {
            if (Properties.Settings.Default.UserName != "")
            {
                string Account = Properties.Settings.Default.UserName;
                string Password = Properties.Settings.Default.Password;
                if (DNV.Login(Account, Password))
                {
                    MainForm form = new MainForm(DNV.getRole(Account), DNV.getName(Account), Account);
                    form.Show();
                }
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }
    }
}
