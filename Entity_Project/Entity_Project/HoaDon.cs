using DevExpress.XtraEditors;
using Entity_Project.Entity;
using Entity_Project.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        Data data = new Data();

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        public void CreateReport(string id)
        {
            string KH = (String)id;
            string KH_ID = KH.Substring(2);
            var results = (from sup1 in data.Inf_Customers
                           join sup2 in data.Inf_Repair on sup1.Customer_Id equals sup2.Customer_Id
                           join sup3 in data.Detail_Inf_Repair on sup2.Repair_Id equals sup3.Repair_Id
                           where sup1.Customer_Id == "KH" + KH_ID
                           select new { sup1.Customer_Name, sup1.Customer_Phone, sup2.Detail_Inf_Repair.Repair_Money, sup2.Laptop_Name, sup2.Repair_Id });
            CrystalReport5 rp = new CrystalReport5();
            rp.SetDataSource(results);
            crystalReportViewer1.ReportSource = rp;
            
        }

        public string ToText(string str)
        {
            string[] word = { "", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
            string[] million = { "", " mươi", " trăm", "" };
            string[] billion = { "", "", "", " nghìn", "", "", " triệu", "", "" };
            string result = "{0}";
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (count > 0 && count % 9 == 0)
                    result = string.Format(result, "{0} tỷ");
                if (!(count < str.Length - 3 && count > 2 && str[i].Equals('0') && str[i - 1].Equals('0') && str[i - 2].Equals('0')))
                    result = string.Format(result, "{0}" + billion[count % 9]);
                if (!str[i].Equals('0'))
                    result = string.Format(result, "{0}" + million[count % 3]);
                else if (count % 3 == 1 && count > 1 && !str[i - 1].Equals('0') && !str[i + 1].Equals('0'))
                    result = string.Format(result, "{0} lẻ");
                var num = Convert.ToInt16(str[i].ToString());
                result = string.Format(result, "{0}" + word[num]);
                count++;
            }
            result = result.Replace("{0}", "");
            return result.Trim();
        }
    }
}