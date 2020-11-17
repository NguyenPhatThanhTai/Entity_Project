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
            this.btnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.PictureBox();
            this.d2 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.PictureBox();
            this.btnHoanThanhSua = new DevExpress.XtraEditors.SimpleButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HenSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HenNhanMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaRp = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).BeginInit();
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
            this.SoTien,
            this.Repair_Status,
            this.NhanVienTiepNhan});
            this.Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(0, 168);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(1245, 536);
            this.Data.TabIndex = 3;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Enabled = false;
            this.btnHoanThanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanThanh.ImageOptions.SvgImage")));
            this.btnHoanThanh.Location = new System.Drawing.Point(456, 97);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(182, 46);
            this.btnHoanThanh.TabIndex = 4;
            this.btnHoanThanh.Text = "Hoàn thành đơn này";
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(94, 97);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 46);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới dữ liệu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(995, 73);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(224, 20);
            this.l2.TabIndex = 78;
            this.l2.Text = "Đang hoàn thành đơn, xin đợi";
            // 
            // l1
            // 
            this.l1.Image = global::Entity_Project.Properties.Resources.loaddonegif;
            this.l1.Location = new System.Drawing.Point(896, 54);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(97, 50);
            this.l1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.l1.TabIndex = 77;
            this.l1.TabStop = false;
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(999, 73);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(159, 20);
            this.d2.TabIndex = 78;
            this.d2.Text = "Đã hoàn thành đơn !";
            // 
            // d1
            // 
            this.d1.Image = global::Entity_Project.Properties.Resources.check;
            this.d1.Location = new System.Drawing.Point(896, 54);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(97, 50);
            this.d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d1.TabIndex = 77;
            this.d1.TabStop = false;
            // 
            // btnHoanThanhSua
            // 
            this.btnHoanThanhSua.Enabled = false;
            this.btnHoanThanhSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanThanhSua.ImageOptions.Image")));
            this.btnHoanThanhSua.Location = new System.Drawing.Point(268, 97);
            this.btnHoanThanhSua.Name = "btnHoanThanhSua";
            this.btnHoanThanhSua.Size = new System.Drawing.Size(182, 46);
            this.btnHoanThanhSua.TabIndex = 79;
            this.btnHoanThanhSua.Text = "Hoàn thành sửa";
            this.btnHoanThanhSua.Click += new System.EventHandler(this.btnHoanThanhSua_Click);
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
            // SoTien
            // 
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            this.SoTien.Width = 125;
            // 
            // Repair_Status
            // 
            this.Repair_Status.HeaderText = "Tình trạng đơn";
            this.Repair_Status.MinimumWidth = 6;
            this.Repair_Status.Name = "Repair_Status";
            this.Repair_Status.ReadOnly = true;
            this.Repair_Status.Width = 125;
            // 
            // NhanVienTiepNhan
            // 
            this.NhanVienTiepNhan.HeaderText = "Nhân viên tiếp nhận";
            this.NhanVienTiepNhan.MinimumWidth = 6;
            this.NhanVienTiepNhan.Name = "NhanVienTiepNhan";
            this.NhanVienTiepNhan.ReadOnly = true;
            this.NhanVienTiepNhan.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tìm theo mã sữa chữa";
            // 
            // txtMaRp
            // 
            this.txtMaRp.Location = new System.Drawing.Point(307, 46);
            this.txtMaRp.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaRp.Name = "txtMaRp";
            this.txtMaRp.Size = new System.Drawing.Size(184, 23);
            this.txtMaRp.TabIndex = 82;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(498, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 33);
            this.btnFind.TabIndex = 81;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Tìm kiếm";
            // 
            // TinhTrangSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaRp);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHoanThanhSua);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.Data);
            this.Name = "TinhTrangSua";
            this.Text = "TinhTrangSua";
            this.Load += new System.EventHandler(this.TinhTrangSua_Load);
            this.Enter += new System.EventHandler(this.TinhTrangSua_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private DevExpress.XtraEditors.SimpleButton btnHoanThanh;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.PictureBox l1;
        private System.Windows.Forms.Label d2;
        private System.Windows.Forms.PictureBox d1;
        private DevExpress.XtraEditors.SimpleButton btnHoanThanhSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HenSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn HenNhanMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repair_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienTiepNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaRp;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
    }
}