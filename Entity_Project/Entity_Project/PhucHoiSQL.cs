using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class PhucHoiSQL : DevExpress.XtraEditors.XtraForm
    {
        public PhucHoiSQL()
        {
            InitializeComponent();
        }

        private void PhucHoiSQL_Load(object sender, EventArgs e)
        {

        }

        private void RestoreSQL()
        {
            try
            {
                string sql = "Alter Database ProjectOne SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database ProjectOne FROM DISK ='" + openFileDialog1.FileName + "' WITH REPLACE;";

                SqlConnection con = new SqlConnection("Data Source=TAEITAEI\\SQLEXPRESS;initial catalog=master;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                SqlCommand command = new SqlCommand(sql, con);

                con.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Hoàn tất phục hồi cơ sở dữ liệu");

                string sql2 = "Alter Database ProjectOne SET MULTI_USER WITH ROLLBACK IMMEDIATE;";
                con = new SqlConnection("Data Source=TAEITAEI\\SQLEXPRESS;initial catalog=master;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                command = new SqlCommand(sql2, con);

                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonTepTin_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Backup File |*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var thread = new Thread(() => RestoreSQL());
                thread.Start();
                this.Close();
            }
        }
    }
}