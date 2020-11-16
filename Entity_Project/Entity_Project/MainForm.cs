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
using DevExpress.DataProcessing;
using DevExpress.PivotGrid.Criteria;
using DevExpress.Utils.Extensions;
using System.Drawing.Imaging;
using Entity_Project.Entity;

using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Threading;
using System.Net;

namespace Entity_Project
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string role, name, Id;
        string ChucVu;

        private PictureBox pb;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string role, string name, string Id) : this()
        {
            this.role = role;
            this.name = name;
            this.Id = Id;
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

            if (MdiChildren.Count() > 0)
            {
                pb1.Hide();
                WelcomeBack.Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadding.Hide();
            timer1.Start();
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("Hệ thống đang bị mất kết nối mạng, vui lòng kiểm tra lại kết nối mạng và thử lại", "Mất kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            else
            {
                if (role != "1")
                {
                    ChucVu = "Nhân Viên";
                    PhanQuyen.Visible = false;
                    ThietLapKetNoiSQL.Visible = false;
                    PhucHoiSQL.Visible = false;
                    SaoLuuSQL.Visible = false;
                    NhanVien.Visible = false;
                }
                else
                {
                    ChucVu = "Quản Lý";
                }
                if (MdiChildren.Count() == 0)
                {
                    txtXinChao.Caption = "Xin chào: ".ToUpper() + name;
                    txtChucVu.Caption = "Chức vụ: ".ToUpper() + ChucVu;
                    WelcomeBack.Text = "Chào mừng quay trở lại: " + name;
                }
            }
        }

        private void LuuTru_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                pb1.Hide();
                WelcomeBack.Hide();
            }
            else
            {
                pb1.Show();
                WelcomeBack.Show();
                WelcomeBack.Text = "Tiếp tục với công việc nào: " + name;
            }
        }

        private void ThongTinKhachHang_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang frm = new ThongTinKhachHang();
            viewForm(frm);
        }

        private void NhanMayBaoGia_Click(object sender, EventArgs e)
        {
            NhanMayBaoGia frm = new NhanMayBaoGia(role, name);
            viewForm(frm);
        }

        private void TinhTrangSua_Click(object sender, EventArgs e)
        {
            TinhTrangSua frm = new TinhTrangSua();
            viewForm(frm);
            label1.Caption = "Hiện tại còn " + frm.getSoLuong().ToString() + " đơn chưa hoàn thành            ";
        }

        private void LichSuSuaChua_Click(object sender, EventArgs e)
        {
            LichSuSuaChua frm = new LichSuSuaChua();
            viewForm(frm);
        }

        private void MayTinhDeBan_Click(object sender, EventArgs e)
        {

        }

        private void LapTop_Click(object sender, EventArgs e)
        {

        }

        private void LinhKien_Click(object sender, EventArgs e)
        {
            LinhKien frm = new LinhKien();
            viewForm(frm);
        }

        private void TheoCombo_Click(object sender, EventArgs e)
        {

        }

        private void KhuyenMai_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachKhoHang_Click(object sender, EventArgs e)
        {
            DanhSachKhoHang frm = new DanhSachKhoHang();
            viewForm(frm);
        }

        private void ThongTinTrongKho_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachNhanVien_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien frm = new ThongTinNhanVien(role, name, Id);
            viewForm(frm);
        }

        private void BangLuong_Click(object sender, EventArgs e)
        {
            ThongTinLuongNhanVien frm = new ThongTinLuongNhanVien();
            viewForm(frm);
        }

        private void BangChamCong_Click(object sender, EventArgs e)
        {

        }

        private void TongKetTaiChinh_Click(object sender, EventArgs e)
        {

        }

        private void HangTonKho_Click(object sender, EventArgs e)
        {
            BaoCaoHangTonKho frm = new BaoCaoHangTonKho();
            viewForm(frm);
        }

        private void PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyenVaTaiKhoan frm = new PhanQuyenVaTaiKhoan();
            viewForm(frm);
        }

        private void ThietLapKetNoiSQL_Click(object sender, EventArgs e)
        {

        }

        private void SaoLuuSQL_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.70d;
            this.BackColor = Color.Gray;
            this.accordionControl1.Appearance.AccordionControl.BackColor = Color.Gray;
            accordionControl1.Hide();
            pb1.Hide();
            WelcomeBack.Hide();
            SaoLuuSQL frm = new SaoLuuSQL();
            frm.ShowDialog();
        }

        private void PhucHoiSQL_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.70d;
            this.BackColor = Color.Gray;
            this.accordionControl1.Appearance.AccordionControl.BackColor = Color.Gray;
            accordionControl1.Hide();
            pb1.Hide();
            WelcomeBack.Hide();
            PhucHoiSQL frm = new PhucHoiSQL();
            frm.ShowDialog();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất khỏi chương trình không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "D:\\Entity_Project\\Entity_Project\\Huong dan (1).chm");
        }

        private void SuaChuaTanNha_Click(object sender, EventArgs e)
        {
            SuaChuaTanNha frm = new SuaChuaTanNha();
            viewForm(frm);
        }

        private void YeuCauTroGiup_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.70d;
            this.BackColor = Color.Gray;
            this.accordionControl1.Appearance.AccordionControl.BackColor = Color.Gray;
            accordionControl1.Hide();
            pb1.Hide();
            WelcomeBack.Hide();
            YeuCauTroGiup frm = new YeuCauTroGiup(Id, name);
            frm.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất khỏi chương trình không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Thongtintaikhoan_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.70d;
            this.BackColor = Color.Gray;
            this.accordionControl1.Appearance.AccordionControl.BackColor = Color.Gray;
            accordionControl1.Hide();
            pb1.Hide();
            WelcomeBack.Hide();
            ThongTinTaiKhoan frm = new ThongTinTaiKhoan(Id);
            frm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Data_NV DNV = new Data_NV();
            var name = DNV.getName(Id);
            this.name = name;
            if (MdiChildren.Count() == 0)
            {
                txtXinChao.Caption = "Xin chào: ".ToUpper() + name;
                txtChucVu.Caption = "Chức vụ: ".ToUpper() + ChucVu;
                WelcomeBack.Text = "Chào mừng quay trở lại: " + name;
            }
            this.Opacity = 1.00d;
            this.BackColor = Color.White;
            this.accordionControl1.Appearance.AccordionControl.BackColor = Color.Empty;
            if (MdiChildren.Count() == 0)
            {
                pb1.Show();
                WelcomeBack.Show();
            }
            accordionControl1.Show();
        }

        private void btnHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "D:\\Entity_Project\\Entity_Project\\Huong dan (1).chm");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Caption = "Giờ: ".ToUpper() + DateTime.Now.ToString("hh:mm:ss");
            txtDate.Caption = "Ngày: ".ToUpper() + DateTime.Now.ToString("dd/MM/yyyy");
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Thứ hai";
                    break;
                case "Tuesday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Thứ ba";
                    break;
                case "Wednesday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Thứ tư";
                    break;
                case "Thursday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Thứ năm";
                    break;
                case "Friday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Thứ sáu";
                    break;
                case "Saturday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Thứ bảy";
                    break;
                case "Sunday":
                    txtDayOfWeek.Caption = "Thứ:".ToUpper() + " Chủ nhật";
                    break;
            }
            label1.Caption = label1.Caption.Substring(1, label1.Caption.Length - 1) + label1.Caption.Substring(0, 1);
        }

        private static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}