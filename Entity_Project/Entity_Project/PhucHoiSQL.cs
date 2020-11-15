using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            pb2.Hide();
            pbLoi.Hide();
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

                string sql2 = "Alter Database ProjectOne SET MULTI_USER WITH ROLLBACK IMMEDIATE;";
                con = new SqlConnection("Data Source=TAEITAEI\\SQLEXPRESS;initial catalog=master;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                command = new SqlCommand(sql2, con);

                con.Close();
                con.Dispose();

                MessageBox.Show("Hoàn tất phục hồi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Hệ thống sẽ tự động khởi động lại chương trình, hãy nhấn có sau đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
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

        private void PhucHoiSQL_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string ext = Path.GetExtension(fileList.First());
            if (ext.ToLower() == ".bak")
            {
                pb2.Hide();
                pb1.Show();
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn phục hồi cơ sở dữ liệu bằng tệp: '" + fileList.First() + "'", "Xác nhận phục hồi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "Alter Database ProjectOne SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                        sql += "Restore Database ProjectOne FROM DISK ='" + fileList.First() + "' WITH REPLACE;";

                        SqlConnection con = new SqlConnection("Data Source=TAEITAEI\\SQLEXPRESS;initial catalog=master;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                        SqlCommand command = new SqlCommand(sql, con);

                        con.Open();
                        command.ExecuteNonQuery();

                        string sql2 = "Alter Database ProjectOne SET MULTI_USER WITH ROLLBACK IMMEDIATE;";
                        con = new SqlConnection("Data Source=TAEITAEI\\SQLEXPRESS;initial catalog=master;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                        command = new SqlCommand(sql2, con);

                        con.Close();
                        con.Dispose();

                        MessageBox.Show("Hoàn tất phục hồi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Hệ thống sẽ tự động khởi động lại chương trình, hãy nhấn có sau đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                pbLoi.Show();
                pb1.Hide();
                pb2.Hide();
                MessageBox.Show("Định dạng tệp '" + ext + "' không được hỗ trợ, định dạng tệp đúng phải là đuôi '.bak'", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbLoi.Hide();
                pb1.Show();
            }
        }

        private void PhucHoiSQL_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PhucHoiSQL_DragOver(object sender, DragEventArgs e)
        {
            pb2.Show();
            pb1.Hide();
        }

        private void PhucHoiSQL_DragLeave(object sender, EventArgs e)
        {
            pb2.Hide();
            pb1.Show();
            pbLoi.Hide();
        }
    }
}