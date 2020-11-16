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
    public partial class BaoCaoTongSoNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoTongSoNhanVien()
        {
            InitializeComponent();
        }

        private void BaoCaoTongSoNhanVien_Load(object sender, EventArgs e)
        {
            CreateReport();
        }

        private void CreateReport()
        {
            Data data = new Data();
            var result = (from supp in data.Inf_Staff
                          where supp.Staff_TimeAdd >= dt1.Value && supp.Staff_TimeAdd <= dt2.Value
                          select new { supp.Staff_Id, supp.Staff_Name, supp.Staff_Phone, supp.Staff_Address});
            CrystalReport4 rp = new CrystalReport4();
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