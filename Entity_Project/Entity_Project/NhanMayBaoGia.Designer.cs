namespace Entity_Project
{
    partial class NhanMayBaoGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanMayBaoGia));
            this.Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLapTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuTinhSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HenSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HenNhanMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTamTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSuaChua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtNVTN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHenSua = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateHen = new System.Windows.Forms.DateTimePicker();
            this.txtCanSua = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_ReFresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnTiepNhan = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            this.MaSuaChua,
            this.TenKhachHang,
            this.TenLapTop,
            this.DuTinhSua,
            this.GhiChu,
            this.HenSua,
            this.HenNhanMay,
            this.TienTamTinh,
            this.NhanVienTiepNhan});
            this.Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(0, 351);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(1243, 354);
            this.Data.TabIndex = 2;
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
            // TenLapTop
            // 
            this.TenLapTop.HeaderText = "Tên laptop";
            this.TenLapTop.MinimumWidth = 6;
            this.TenLapTop.Name = "TenLapTop";
            this.TenLapTop.ReadOnly = true;
            this.TenLapTop.Width = 120;
            // 
            // DuTinhSua
            // 
            this.DuTinhSua.HeaderText = "Dự tính sửa";
            this.DuTinhSua.MinimumWidth = 6;
            this.DuTinhSua.Name = "DuTinhSua";
            this.DuTinhSua.ReadOnly = true;
            this.DuTinhSua.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 125;
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
            this.HenNhanMay.Width = 125;
            // 
            // TienTamTinh
            // 
            this.TienTamTinh.HeaderText = "Tiền tạm tính";
            this.TienTamTinh.MinimumWidth = 6;
            this.TienTamTinh.Name = "TienTamTinh";
            this.TienTamTinh.ReadOnly = true;
            this.TienTamTinh.Width = 125;
            // 
            // NhanVienTiepNhan
            // 
            this.NhanVienTiepNhan.HeaderText = "Nhân viên tiếp nhận";
            this.NhanVienTiepNhan.MinimumWidth = 6;
            this.NhanVienTiepNhan.Name = "NhanVienTiepNhan";
            this.NhanVienTiepNhan.ReadOnly = true;
            this.NhanVienTiepNhan.Width = 125;
            // 
            // txtMaSuaChua
            // 
            this.txtMaSuaChua.Enabled = false;
            this.txtMaSuaChua.Location = new System.Drawing.Point(188, 21);
            this.txtMaSuaChua.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSuaChua.Name = "txtMaSuaChua";
            this.txtMaSuaChua.Size = new System.Drawing.Size(216, 23);
            this.txtMaSuaChua.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mã sữa chữa";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Enabled = false;
            this.txtTinhTrang.Location = new System.Drawing.Point(588, 21);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTinhTrang.Multiline = true;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(216, 110);
            this.txtTinhTrang.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(862, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tên Laptop";
            // 
            // txtTenMay
            // 
            this.txtTenMay.Enabled = false;
            this.txtTenMay.Location = new System.Drawing.Point(993, 65);
            this.txtTenMay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(216, 23);
            this.txtTenMay.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(188, 119);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(216, 23);
            this.txtTenKhachHang.TabIndex = 80;
            // 
            // txtNVTN
            // 
            this.txtNVTN.Enabled = false;
            this.txtNVTN.Location = new System.Drawing.Point(188, 216);
            this.txtNVTN.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVTN.Name = "txtNVTN";
            this.txtNVTN.Size = new System.Drawing.Size(216, 23);
            this.txtNVTN.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(57, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 87;
            this.label9.Text = "NV tiếp nhận";
            // 
            // txtHenSua
            // 
            this.txtHenSua.Enabled = false;
            this.txtHenSua.FormattingEnabled = true;
            this.txtHenSua.Items.AddRange(new object[] {
            "Sửa lấy ngay",
            "Hẹn ngày lấy"});
            this.txtHenSua.Location = new System.Drawing.Point(993, 107);
            this.txtHenSua.Name = "txtHenSua";
            this.txtHenSua.Size = new System.Drawing.Size(216, 24);
            this.txtHenSua.TabIndex = 92;
            this.txtHenSua.Text = "Sửa lấy ngay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(862, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 90;
            this.label10.Text = "Hẹn nhận máy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(467, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 84;
            this.label8.Text = "Dự tính sửa";
            // 
            // txtDateHen
            // 
            this.txtDateHen.Enabled = false;
            this.txtDateHen.Location = new System.Drawing.Point(993, 152);
            this.txtDateHen.Name = "txtDateHen";
            this.txtDateHen.Size = new System.Drawing.Size(216, 23);
            this.txtDateHen.TabIndex = 89;
            // 
            // txtCanSua
            // 
            this.txtCanSua.Enabled = false;
            this.txtCanSua.Location = new System.Drawing.Point(588, 141);
            this.txtCanSua.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanSua.Multiline = true;
            this.txtCanSua.Name = "txtCanSua";
            this.txtCanSua.Size = new System.Drawing.Size(216, 109);
            this.txtCanSua.TabIndex = 67;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Enabled = false;
            this.txtSoTien.Location = new System.Drawing.Point(993, 194);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(216, 23);
            this.txtSoTien.TabIndex = 72;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(862, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Số tiền tạm tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(467, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(862, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Hẹn/Lấy ngay";
            // 
            // Btn_ReFresh
            // 
            this.Btn_ReFresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ReFresh.ImageOptions.Image")));
            this.Btn_ReFresh.Location = new System.Drawing.Point(802, 258);
            this.Btn_ReFresh.Name = "Btn_ReFresh";
            this.Btn_ReFresh.Size = new System.Drawing.Size(202, 58);
            this.Btn_ReFresh.TabIndex = 96;
            this.Btn_ReFresh.Text = "Làm mới dữ liệu";
            this.Btn_ReFresh.Click += new System.EventHandler(this.Btn_ReFresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(519, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 57);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Cập nhật thông tin";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Enabled = false;
            this.btnTiepNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhan.ImageOptions.Image")));
            this.btnTiepNhan.Location = new System.Drawing.Point(244, 256);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(202, 60);
            this.btnTiepNhan.TabIndex = 93;
            this.btnTiepNhan.Text = "Tiếp nhận đơn";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Entity_Project.Properties.Resources.wrench1;
            this.pictureBox3.Location = new System.Drawing.Point(28, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Entity_Project.Properties.Resources.laptop;
            this.pictureBox8.Location = new System.Drawing.Point(833, 65);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 18);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Entity_Project.Properties.Resources.user;
            this.pictureBox4.Location = new System.Drawing.Point(28, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Entity_Project.Properties.Resources.time;
            this.pictureBox7.Location = new System.Drawing.Point(833, 153);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 91;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Entity_Project.Properties.Resources.user1;
            this.pictureBox6.Location = new System.Drawing.Point(28, 219);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 88;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Entity_Project.Properties.Resources.writing;
            this.pictureBox5.Location = new System.Drawing.Point(438, 64);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 85;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox12.Location = new System.Drawing.Point(833, 196);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(22, 19);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 76;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Entity_Project.Properties.Resources.time;
            this.pictureBox11.Location = new System.Drawing.Point(833, 112);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(22, 19);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 75;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Entity_Project.Properties.Resources.writing;
            this.pictureBox9.Location = new System.Drawing.Point(438, 183);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 17);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 71;
            this.pictureBox9.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NhanMayBaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 705);
            this.Controls.Add(this.Btn_ReFresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.txtMaSuaChua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMay);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtNVTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHenSua);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDateHen);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.txtCanSua);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Data);
            this.Name = "NhanMayBaoGia";
            this.Text = "NhanMayBaoGia";
            this.Load += new System.EventHandler(this.NhanMayBaoGia_Load);
            this.Enter += new System.EventHandler(this.NhanMayBaoGia_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.TextBox txtMaSuaChua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtNVTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtHenSua;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDateHen;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.TextBox txtCanSua;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton Btn_ReFresh;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLapTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuTinhSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HenSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn HenNhanMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTamTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienTiepNhan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}