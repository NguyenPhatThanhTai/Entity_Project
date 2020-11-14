using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class SaoLuuSQL : DevExpress.XtraEditors.XtraForm
    {
        public SaoLuuSQL()
        {
            InitializeComponent();
        }

        string folderPath = "";
        string name = "";

        private void SaoLuuSQL_Load(object sender, EventArgs e)
        {

        }

        private void BackupDatabase(string databaseName, string serverName, string destinationPath)
        {

            DateTime date = DateTime.Now;

            //Define a Backup object variable.
            Backup sqlBackup = new Backup();

            //Specify the type of backup, the description, the name, and the database to be backed up.
            sqlBackup.Action = BackupActionType.Database;
            sqlBackup.BackupSetDescription = "BackUp of:" + databaseName + "on" + date.ToShortDateString();
            sqlBackup.BackupSetName = name;
            sqlBackup.Database = databaseName;

            //Declare a BackupDeviceItem
            BackupDeviceItem deviceItem = new BackupDeviceItem(destinationPath + "\\" + name + ".bak", DeviceType.File);
            //Define Server connection
            ServerConnection connection = new ServerConnection(serverName);
            //To Avoid TimeOut Exception
            Server sqlServer = new Server(connection);
            sqlServer.ConnectionContext.StatementTimeout = 60 * 60;
            Database db = sqlServer.Databases[databaseName];

            sqlBackup.Initialize = true;
            sqlBackup.Checksum = true;
            sqlBackup.ContinueAfterError = true;

            //Add the device to the Backup object.
            sqlBackup.Devices.Add(deviceItem);
            //Set the Incremental property to False to specify that this is a full database backup.
            sqlBackup.Incremental = false;

            sqlBackup.ExpirationDate = DateTime.Now.AddDays(3);
            //Specify that the log must be truncated after the backup is complete.
            sqlBackup.LogTruncation = BackupTruncateLogType.Truncate;

            sqlBackup.FormatMedia = false;
            //Run SqlBackup to perform the full database backup on the instance of SQL Server.
            try
            {
                sqlBackup.SqlBackup(sqlServer);
                sqlBackup.Devices.Remove(deviceItem);
                MessageBox.Show("Sao lưu cơ sở dữ liêu thành công");
                date = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trùng tên trong thư mục hoặc có lỗi xảy ra, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Remove the backup device from the Backup object.
        }

        private void btnChonDuongDan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = directchoosedlg.SelectedPath;
                txtDuongDan.Text = folderPath.ToString() + "\\" + txtTenSaoLuu.Text + ".bak";
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (txtDuongDan.Text != "" && txtTenSaoLuu.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn sao lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    name = txtTenSaoLuu.Text;
                    var thread = new Thread(() => BackupDatabase("ProjectOne", "TAEITAEI\\SQLEXPRESS", folderPath));
                    thread.Start();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}