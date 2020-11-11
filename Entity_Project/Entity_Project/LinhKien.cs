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
    public partial class LinhKien : DevExpress.XtraEditors.XtraForm
    {
        public LinhKien()
        {
            InitializeComponent();
        }

        Data_LK DLK;

        private void LinhKien_Load(object sender, EventArgs e)
        {
            DLK = new Data_LK();
            Load_LK(DLK.Inf_LK());
        }

        private void Load_LK(List<Inf_LK> Inf_LK)
        {
            int i = 1;
            Data.Rows.Clear();
            foreach (var item in Inf_LK)
            {
                int index = Data.Rows.Add();
                Data.Rows[index].Cells[0].Value = i;
                Data.Rows[index].Cells[1].Value = item.LK_Id;
                Data.Rows[index].Cells[2].Value = item.WareHouse_Id;
                Data.Rows[index].Cells[3].Value = item.LK_Name;
                Data.Rows[index].Cells[4].Value = item.LK_Number;
                Data.Rows[index].Cells[5].Value = item.LK_Producer;
                Data.Rows[index].Cells[6].Value = item.LK_Price;
                Data.Rows[index].Cells[7].Value = item.LK_Time_Add;
                i++;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Load_LK(DLK.Inf_LK());
            string tlk = txtTlk.Text.ToLower();
            string nsx = txtNsx.Text.ToLower();

            if (tlk == "" || nsx == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                Data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in Data.Rows)
                    {
                        if (row.Cells[3].Value.ToString().ToLower().Equals(tlk) && row.Cells[5].Value.ToString().ToLower().Equals(nsx))
                        {
                            row.Selected = true;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void LinhKien_Enter(object sender, EventArgs e)
        {
            DLK = new Data_LK();
            Load_LK(DLK.Inf_LK());
        }
    }
}