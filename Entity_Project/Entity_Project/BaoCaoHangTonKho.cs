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
using Entity_Project.Entity;
using Entity_Project.Report;
using DevExpress.Utils.Extensions;

namespace Entity_Project
{
    public partial class BaoCaoHangTonKho : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoHangTonKho()
        {
            InitializeComponent();
        }

        private void BaoCaoHangTonKho_Load(object sender, EventArgs e)
        {
            CreateReport(dt1.Text);
        }

        private void CreateReport(string dt)
        {
            Data data = new Data();
            var result = (from supp in data.Inf_LK
                          where supp.LK_Time_Add >= dt1.Value && supp.LK_Time_Add <= dt2.Value
                          select new { supp.LK_Id, supp.LK_Name, supp.LK_Number, supp.LK_Price, supp.LK_Producer, supp.WareHouse_Id });
            CrystalReport2 rp = new CrystalReport2();
            rp.SetDataSource(result);
            crystalReportViewer2.ReportSource = rp;
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            CreateReport(dt1.Text);
        }
    }
}