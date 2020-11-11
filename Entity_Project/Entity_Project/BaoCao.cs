using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entity_Project.Report;
using Entity_Project.Entity;
using System.Data.SqlClient;
using DevExpress.XtraPrinting.BarCode;

namespace Entity_Project
{
    public partial class BaoCao : DevExpress.XtraEditors.XtraForm
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        Data data = new Data();

        private void BaoCao_Load(object sender, EventArgs e)
        {
            
        }

        public void CreateReport(string id)
        {
            string KH = (String)id;
            string KHID = KH.Substring(2);
            var results = (from sup1 in data.Inf_Customers
                           join sup2 in data.Inf_Repair on sup1.Customer_Id equals sup2.Customer_Id
                           join sup3 in data.Detail_Inf_Repair on sup2.Repair_Id equals sup3.Repair_Id
                           where sup1.Customer_Id == "KH" + KHID
                           select new { sup1.Customer_Name, sup1.Customer_Phone, sup2.Detail_Inf_Repair.Repair_Id, sup2.Staff_Id });
            CrystalReport1 rp = new CrystalReport1();
            rp.SetDataSource(results);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}