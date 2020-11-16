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
    public partial class BaoCaoTongSoKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoTongSoKhachHang()
        {
            InitializeComponent();
        }

        private void BaoCaoTongSoKhachHang_Load(object sender, EventArgs e)
        {
            CreateReport();
        }

        private void CreateReport()
        {
            Data data = new Data();
            var result = (from supp in data.Inf_Customers
                          where supp.Customer_TimeAdd >= dt1.Value && supp.Customer_TimeAdd <= dt2.Value
                          select new { supp.Customer_Id, supp.Customer_Name, supp.Customer_Phone, supp.Customer_Email });
            CrystalReport3 rp = new CrystalReport3();
            rp.SetDataSource(result);
            crystalReportViewer1.ReportSource = rp;
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            CreateReport();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            CreateReport();
        }
    }
}