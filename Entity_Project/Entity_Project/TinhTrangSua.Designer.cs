namespace Entity_Project
{
    partial class TinhTrangSua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhTrangSua));
            this.Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HenSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HenNhanMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSuaChua,
            this.TenKhachHang,
            this.HenSua,
            this.HenNhanMay,
            this.NhanVienTiepNhan});
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(29, 82);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(1194, 599);
            this.Data.TabIndex = 3;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaSuaChua
            // 
            this.MaSuaChua.HeaderText = "Mã Sữa Chữa";
            this.MaSuaChua.MinimumWidth = 6;
            this.MaSuaChua.Name = "MaSuaChua";
            this.MaSuaChua.ReadOnly = true;
            this.MaSuaChua.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 170;
            // 
            // HenSua
            // 
            this.HenSua.HeaderText = "Hẹn sửa";
            this.HenSua.MinimumWidth = 6;
            this.HenSua.Name = "HenSua";
            this.HenSua.ReadOnly = true;
            this.HenSua.Width = 125;
            // 
            // HenNhanMay
            // 
            this.HenNhanMay.HeaderText = "Hẹn nhận máy";
            this.HenNhanMay.MinimumWidth = 6;
            this.HenNhanMay.Name = "HenNhanMay";
            this.HenNhanMay.ReadOnly = true;
            this.HenNhanMay.Width = 150;
            // 
            // NhanVienTiepNhan
            // 
            this.NhanVienTiepNhan.HeaderText = "Nhân viên tiếp nhận";
            this.NhanVienTiepNhan.MinimumWidth = 6;
            this.NhanVienTiepNhan.Name = "NhanVienTiepNhan";
            this.NhanVienTiepNhan.ReadOnly = true;
            this.NhanVienTiepNhan.Width = 125;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Enabled = false;
            this.btnHoanThanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanThanh.ImageOptions.SvgImage")));
            this.btnHoanThanh.Location = new System.Drawing.Point(203, 30);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(182, 46);
            this.btnHoanThanh.TabIndex = 4;
            this.btnHoanThanh.Text = "Hoàn thành đơn này";
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(29, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 46);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới dữ liệu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TinhTrangSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 704);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.Data);
            this.Name = "TinhTrangSua";
            this.Text = "TinhTrangSua";
            this.Load += new System.EventHandler(this.TinhTrangSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HenSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn HenNhanMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienTiepNhan;
        private DevExpress.XtraEditors.SimpleButton btnHoanThanh;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}