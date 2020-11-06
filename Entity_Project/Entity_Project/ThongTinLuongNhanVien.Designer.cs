namespace Entity_Project
{
    partial class ThongTinLuongNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinLuongNhanVien));
            this.Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongTheoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LamNgoaiGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtLamNgoaiGio = new System.Windows.Forms.TextBox();
            this.txtLuongTheoGio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienThuong = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Btn_ReFresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNhanVien,
            this.TenNhanVien,
            this.LuongCoBan,
            this.LuongTheoGio,
            this.LamNgoaiGio,
            this.TienThuong});
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(25, 281);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(1137, 407);
            this.Data.TabIndex = 4;
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
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Width = 170;
            // 
            // LuongCoBan
            // 
            this.LuongCoBan.HeaderText = "Lương cơ bản";
            this.LuongCoBan.MinimumWidth = 6;
            this.LuongCoBan.Name = "LuongCoBan";
            this.LuongCoBan.ReadOnly = true;
            this.LuongCoBan.Width = 150;
            // 
            // LuongTheoGio
            // 
            this.LuongTheoGio.HeaderText = "Lương theo giờ";
            this.LuongTheoGio.MinimumWidth = 6;
            this.LuongTheoGio.Name = "LuongTheoGio";
            this.LuongTheoGio.ReadOnly = true;
            this.LuongTheoGio.Width = 130;
            // 
            // LamNgoaiGio
            // 
            this.LamNgoaiGio.HeaderText = "Làm ngoài giờ";
            this.LamNgoaiGio.MinimumWidth = 6;
            this.LamNgoaiGio.Name = "LamNgoaiGio";
            this.LamNgoaiGio.ReadOnly = true;
            this.LamNgoaiGio.Width = 125;
            // 
            // TienThuong
            // 
            this.TienThuong.HeaderText = "Tiền thưởng";
            this.TienThuong.MinimumWidth = 6;
            this.TienThuong.Name = "TienThuong";
            this.TienThuong.ReadOnly = true;
            this.TienThuong.Width = 125;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(179, 47);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(208, 23);
            this.txtMaNV.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(61, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(456, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Lương cơ bản";
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Enabled = false;
            this.txtLuongCoBan.Location = new System.Drawing.Point(574, 47);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(208, 23);
            this.txtLuongCoBan.TabIndex = 77;
            this.txtLuongCoBan.TextChanged += new System.EventHandler(this.txtLuongCoBan_TextChanged);
            // 
            // txtLamNgoaiGio
            // 
            this.txtLamNgoaiGio.Enabled = false;
            this.txtLamNgoaiGio.Location = new System.Drawing.Point(954, 105);
            this.txtLamNgoaiGio.Name = "txtLamNgoaiGio";
            this.txtLamNgoaiGio.Size = new System.Drawing.Size(208, 23);
            this.txtLamNgoaiGio.TabIndex = 64;
            this.txtLamNgoaiGio.TextChanged += new System.EventHandler(this.txtLamNgoaiGio_TextChanged);
            // 
            // txtLuongTheoGio
            // 
            this.txtLuongTheoGio.Enabled = false;
            this.txtLuongTheoGio.Location = new System.Drawing.Point(574, 107);
            this.txtLuongTheoGio.Name = "txtLuongTheoGio";
            this.txtLuongTheoGio.Size = new System.Drawing.Size(208, 23);
            this.txtLuongTheoGio.TabIndex = 62;
            this.txtLuongTheoGio.TextChanged += new System.EventHandler(this.txtLuongTheoGio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(456, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Lương theo giờ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(836, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Làm ngoài giờ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "Tổng lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(836, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Tiền thưởng";
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.Enabled = false;
            this.txtTienThuong.Location = new System.Drawing.Point(954, 50);
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.Size = new System.Drawing.Size(208, 23);
            this.txtTienThuong.TabIndex = 63;
            this.txtTienThuong.TextChanged += new System.EventHandler(this.txtTienThuong_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Entity_Project.Properties.Resources.user;
            this.pictureBox5.Location = new System.Drawing.Point(33, 48);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 71;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox2.Location = new System.Drawing.Point(428, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(808, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox13.Location = new System.Drawing.Point(428, 108);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(22, 19);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 74;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox4.Location = new System.Drawing.Point(808, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // Btn_ReFresh
            // 
            this.Btn_ReFresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ReFresh.ImageOptions.Image")));
            this.Btn_ReFresh.Location = new System.Drawing.Point(960, 191);
            this.Btn_ReFresh.Name = "Btn_ReFresh";
            this.Btn_ReFresh.Size = new System.Drawing.Size(202, 58);
            this.Btn_ReFresh.TabIndex = 83;
            this.Btn_ReFresh.Text = "Làm mới dữ liệu";
            this.Btn_ReFresh.Click += new System.EventHandler(this.Btn_ReFresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(25, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 57);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Cập nhật lương";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(179, 105);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(208, 23);
            this.txtTenNV.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(61, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tên nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Entity_Project.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(33, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Enabled = false;
            this.txtTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLuong.ForeColor = System.Drawing.Color.Red;
            this.txtTongLuong.Location = new System.Drawing.Point(520, 210);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(237, 38);
            this.txtTongLuong.TabIndex = 65;
            this.txtTongLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThongTinLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 709);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_ReFresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtLamNgoaiGio);
            this.Controls.Add(this.txtLuongTheoGio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTienThuong);
            this.Controls.Add(this.Data);
            this.Name = "ThongTinLuongNhanVien";
            this.Text = "ThongTinLuongNhanVien";
            this.Load += new System.EventHandler(this.ThongTinLuongNhanVien_Load);
            this.Enter += new System.EventHandler(this.ThongTinLuongNhanVien_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtLamNgoaiGio;
        private System.Windows.Forms.TextBox txtLuongTheoGio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienThuong;
        private DevExpress.XtraEditors.SimpleButton Btn_ReFresh;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongTheoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LamNgoaiGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuong;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}