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

namespace Entity_Project
{
    public partial class TinhTrangSua : DevExpress.XtraEditors.XtraForm
    {
        public TinhTrangSua()
        {
            InitializeComponent();
        }

        Data_RP DRP;
        string id, note, status;

        private void TinhTrangSua_Load(object sender, EventArgs e)
        {
            d1.Hide();
            d2.Hide();
            l1.Hide();
            l2.Hide();
            DRP = new Data_RP();
            Load_TinhTrang(DRP.Inf_Repair());
        }

        private void Load_TinhTrang(List<Inf_Repair> Inf_Repair)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Inf_Repair)
            {
                if (item.Detail_Inf_Repair.Repair_Status.ToString() == "1")
                {
                    status = "Đã hoàn thành sửa";
                }
                else
                {
                    status = "Chưa hoàn thành sửa";
                }
                var date1 = DateTime.Parse(item.Detail_Inf_Repair.Repair_Appointment.ToString());

                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.Repair_Id;
                Data.Rows[index].Cells[2].Value = item.Inf_Customers.Customer_Name;
                Data.Rows[index].Cells[3].Value = item.Detail_Inf_Repair.Repair_Note;
                Data.Rows[index].Cells[4].Value = date1.ToString("dd/MM/yyyy");
                Data.Rows[index].Cells[5].Value = status;
                Data.Rows[index].Cells[6].Value = item.Staff_Id;
                i++;
            }
            Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn hoàn thành đơn này?", "Xác nhận hoàn thành", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                List<Inf_Repair> Inf_Repair = DRP.FindBy_ID(id);
                foreach (var item in Inf_Repair)
                {
                    if (DRP.Done_RP(item.Repair_Id))
                    {
                        DRP.Delete_KH(item.Customer_Id);
                        DRP = new Data_RP();
                        Load_TinhTrang(DRP.Inf_Repair());
                        btnHoanThanh.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            if (Data.Rows.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có đơn hàng nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                id = Data.SelectedRows[0].Cells[1].Value.ToString();
                note = Data.SelectedRows[0].Cells[3].Value.ToString();
                if (Data.SelectedRows[0].Cells[6].Value.ToString() != "Chưa biết" && Data.SelectedRows[0].Cells[5].Value.ToString() != "Chưa hoàn thành sửa")
                {
                    btnHoanThanh.Enabled = true;
                    btnHoanThanhSua.Enabled = true;
                }
                else
                {
                    btnHoanThanhSua.Enabled = false;
                    btnHoanThanh.Enabled = false;
                }
                if (Data.SelectedRows[0].Cells[6].Value.ToString() != "Chưa biết")
                {
                    btnHoanThanhSua.Enabled = true;
                }
            }
        }

        private void TinhTrangSua_Enter(object sender, EventArgs e)
        {
            Data_RP DRP = new Data_RP();
            Load_TinhTrang(DRP.Inf_Repair());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Data_RP DRP = new Data_RP();
            Load_TinhTrang(DRP.Inf_Repair());
        }

        private async void btnHoanThanhSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn hoàn thành sửa cho đơn này?", "Xác nhận hoàn thành", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                l1.Show();
                l2.Show();
                if (DRP.Update_Status("1",id ,note))
                {
                    await Task.Delay(5000);
                    l1.Hide();
                    l2.Hide();
                    d1.Show();
                    d2.Show();
                    DRP = new Data_RP();
                    Load_TinhTrang(DRP.Inf_Repair());
                    await Task.Delay(2000);
                    d1.Hide();
                    d2.Hide();
                    btnHoanThanhSua.Enabled = false;
                    btnHoanThanh.Enabled = false;
                }
            }
        }

        public long getSoLuong()
        {
            DRP = new Data_RP();
            List<Inf_Repair> Inf_Repair = DRP.Inf_Repair();
            return Inf_Repair.Count();
        }
    }
}