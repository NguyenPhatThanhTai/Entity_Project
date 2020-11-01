namespace Entity_Project
{
    partial class DanhSachKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachKhoHang));
            this.Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhapVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenLinhKien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_ReFresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLinhKien = new System.Windows.Forms.TextBox();
            this.txtMaKhoHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKho,
            this.TenKho,
            this.DiaChi,
            this.SucChua,
            this.SoLuongHienTai});
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(25, 276);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(302, 392);
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
            // MaKho
            // 
            this.MaKho.HeaderText = "Mã Kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.ReadOnly = true;
            this.MaKho.Width = 125;
            // 
            // TenKho
            // 
            this.TenKho.HeaderText = "Tên Kho";
            this.TenKho.MinimumWidth = 6;
            this.TenKho.Name = "TenKho";
            this.TenKho.ReadOnly = true;
            this.TenKho.Width = 170;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // SucChua
            // 
            this.SucChua.HeaderText = "Sức Chứa";
            this.SucChua.MinimumWidth = 6;
            this.SucChua.Name = "SucChua";
            this.SucChua.ReadOnly = true;
            this.SucChua.Width = 150;
            // 
            // SoLuongHienTai
            // 
            this.SoLuongHienTai.HeaderText = "Số Lượng Hiện Tại";
            this.SoLuongHienTai.MinimumWidth = 6;
            this.SoLuongHienTai.Name = "SoLuongHienTai";
            this.SoLuongHienTai.ReadOnly = true;
            this.SoLuongHienTai.Width = 125;
            // 
            // Data1
            // 
            this.Data1.AllowUserToAddRows = false;
            this.Data1.AllowUserToDeleteRows = false;
            this.Data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaLinhKien,
            this.dataGridViewTextBoxColumn2,
            this.TenLinhKien,
            this.SoLuongNhapVe,
            this.NhaSanXuat,
            this.GiaTien,
            this.ThoiGianThem});
            this.Data1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data1.Location = new System.Drawing.Point(345, 276);
            this.Data1.Name = "Data1";
            this.Data1.ReadOnly = true;
            this.Data1.RowHeadersWidth = 51;
            this.Data1.RowTemplate.Height = 24;
            this.Data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data1.Size = new System.Drawing.Size(878, 392);
            this.Data1.TabIndex = 5;
            this.Data1.Click += new System.EventHandler(this.Data1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // MaLinhKien
            // 
            this.MaLinhKien.HeaderText = "Mã linh kiện";
            this.MaLinhKien.MinimumWidth = 6;
            this.MaLinhKien.Name = "MaLinhKien";
            this.MaLinhKien.ReadOnly = true;
            this.MaLinhKien.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã kho";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // TenLinhKien
            // 
            this.TenLinhKien.HeaderText = "Tên Linh Kiện";
            this.TenLinhKien.MinimumWidth = 6;
            this.TenLinhKien.Name = "TenLinhKien";
            this.TenLinhKien.ReadOnly = true;
            this.TenLinhKien.Width = 125;
            // 
            // SoLuongNhapVe
            // 
            this.SoLuongNhapVe.HeaderText = "Số Lượng Nhập Về";
            this.SoLuongNhapVe.MinimumWidth = 6;
            this.SoLuongNhapVe.Name = "SoLuongNhapVe";
            this.SoLuongNhapVe.ReadOnly = true;
            this.SoLuongNhapVe.Width = 125;
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.NhaSanXuat.MinimumWidth = 6;
            this.NhaSanXuat.Name = "NhaSanXuat";
            this.NhaSanXuat.ReadOnly = true;
            this.NhaSanXuat.Width = 125;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 125;
            // 
            // ThoiGianThem
            // 
            this.ThoiGianThem.HeaderText = "Thời Gian Thêm";
            this.ThoiGianThem.MinimumWidth = 6;
            this.ThoiGianThem.Name = "ThoiGianThem";
            this.ThoiGianThem.ReadOnly = true;
            this.ThoiGianThem.Width = 125;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox4.Location = new System.Drawing.Point(838, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Entity_Project.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(838, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Entity_Project.Properties.Resources.wood;
            this.pictureBox1.Location = new System.Drawing.Point(417, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Entity_Project.Properties.Resources.wrench;
            this.pictureBox2.Location = new System.Drawing.Point(417, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(1007, 121);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 23);
            this.txtPrice.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(446, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên linh kiện";
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Enabled = false;
            this.txtNhaSanXuat.Location = new System.Drawing.Point(1007, 54);
            this.txtNhaSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(216, 23);
            this.txtNhaSanXuat.TabIndex = 68;
            // 
            // txtTenLinhKien
            // 
            this.txtTenLinhKien.Enabled = false;
            this.txtTenLinhKien.Location = new System.Drawing.Point(586, 55);
            this.txtTenLinhKien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLinhKien.Name = "txtTenLinhKien";
            this.txtTenLinhKien.Size = new System.Drawing.Size(216, 23);
            this.txtTenLinhKien.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(446, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Số lượng nhập";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(586, 119);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(216, 23);
            this.txtSoLuong.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(867, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Giá tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(867, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nhà sản xuất";
            // 
            // Btn_ReFresh
            // 
            this.Btn_ReFresh.Enabled = false;
            this.Btn_ReFresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ReFresh.ImageOptions.Image")));
            this.Btn_ReFresh.Location = new System.Drawing.Point(911, 182);
            this.Btn_ReFresh.Name = "Btn_ReFresh";
            this.Btn_ReFresh.Size = new System.Drawing.Size(202, 58);
            this.Btn_ReFresh.TabIndex = 76;
            this.Btn_ReFresh.Text = "Làm mới dữ liệu";
            this.Btn_ReFresh.Click += new System.EventHandler(this.Btn_ReFresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(627, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 58);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Xóa linh kiện";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(346, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 57);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Cập nhật linh kiện";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(71, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 60);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Thêm mới linh kiện";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Entity_Project.Properties.Resources.wrench;
            this.pictureBox5.Location = new System.Drawing.Point(16, 119);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mã kho hàng";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Entity_Project.Properties.Resources.wood;
            this.pictureBox6.Location = new System.Drawing.Point(16, 57);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(45, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Mã Linh Kiện";
            // 
            // txtMaLinhKien
            // 
            this.txtMaLinhKien.Enabled = false;
            this.txtMaLinhKien.Location = new System.Drawing.Point(185, 54);
            this.txtMaLinhKien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLinhKien.Name = "txtMaLinhKien";
            this.txtMaLinhKien.Size = new System.Drawing.Size(216, 23);
            this.txtMaLinhKien.TabIndex = 81;
            // 
            // txtMaKhoHang
            // 
            this.txtMaKhoHang.Enabled = false;
            this.txtMaKhoHang.FormattingEnabled = true;
            this.txtMaKhoHang.Location = new System.Drawing.Point(185, 116);
            this.txtMaKhoHang.Name = "txtMaKhoHang";
            this.txtMaKhoHang.Size = new System.Drawing.Size(216, 24);
            this.txtMaKhoHang.TabIndex = 83;
            this.txtMaKhoHang.Text = "TDHCM";
            // 
            // DanhSachKhoHang
            // 
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 702);
            this.Controls.Add(this.txtMaKhoHang);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaLinhKien);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_ReFresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhaSanXuat);
            this.Controls.Add(this.txtTenLinhKien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.Data);
            this.Name = "DanhSachKhoHang";
            this.Text = "DanhSachKhoHang";
            this.Load += new System.EventHandler(this.DanhSachKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHienTai;
        private System.Windows.Forms.DataGridView Data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhapVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianThem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.TextBox txtTenLinhKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Btn_ReFresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLinhKien;
        private System.Windows.Forms.ComboBox txtMaKhoHang;
    }
}