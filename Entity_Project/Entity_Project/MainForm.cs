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

namespace Entity_Project
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool checkForm(Form frm)
        {
            bool flagCheck = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (frm.Name == item.Name)
                    {
                        LuuTru.Pages[item].MdiChild.Activate();
                        flagCheck = true;
                    }
                }
            }
            return flagCheck;
        }

        private void viewForm(Form frm)
        {
            if (!checkForm(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void ThongTinKhachHang_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang frm = new ThongTinKhachHang();
            viewForm(frm);
        }

        private void NhanMayBaoGia_Click(object sender, EventArgs e)
        {
            NhanMayBaoGia frm = new NhanMayBaoGia();
            viewForm(frm);
        }

        private void DiSuaChua_Click(object sender, EventArgs e)
        {
            DiSuaChua frm = new DiSuaChua();
            viewForm(frm);
        }

        private void LichSuSuaChua_Click(object sender, EventArgs e)
        {

        }

        private void MayTinhDeBan_Click(object sender, EventArgs e)
        {

        }

        private void LapTop_Click(object sender, EventArgs e)
        {

        }

        private void LinhKien_Click(object sender, EventArgs e)
        {

        }

        private void TheoCombo_Click(object sender, EventArgs e)
        {

        }

        private void KhuyenMai_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachKhoHang_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinTrongKho_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void BangChamCong_Click(object sender, EventArgs e)
        {

        }

        private void TongKetTaiChinh_Click(object sender, EventArgs e)
        {

        }

        private void HangTonKho_Click(object sender, EventArgs e)
        {

        }

        private void PhanQuyen_Click(object sender, EventArgs e)
        {

        }

        private void ThietLapKetNoiSQL_Click(object sender, EventArgs e)
        {

        }

        private void SaoLuuSQL_Click(object sender, EventArgs e)
        {

        }

        private void PhucHoiSQL_Click(object sender, EventArgs e)
        {

        }

        private void DangXuat_Click(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {

        }

        private void HuongDan_Click(object sender, EventArgs e)
        {

        }

        private void YeuCauTroGiup_Click(object sender, EventArgs e)
        {

        }
    }
}