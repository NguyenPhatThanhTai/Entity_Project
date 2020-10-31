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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachKhoHang));
            this.Data = new System.Windows.Forms.DataGridView();
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhapVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(25, 276);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(302, 392);
            this.Data.TabIndex = 4;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data1.Enabled = false;
            this.Data1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data1.Location = new System.Drawing.Point(345, 276);
            this.Data1.Name = "Data1";
            this.Data1.ReadOnly = true;
            this.Data1.RowHeadersWidth = 51;
            this.Data1.RowTemplate.Height = 24;
            this.Data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data1.Size = new System.Drawing.Size(878, 392);
            this.Data1.TabIndex = 5;
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Entity_Project.Properties.Resources.dollar;
            this.pictureBox4.Location = new System.Drawing.Point(595, 132);
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
            this.pictureBox3.Location = new System.Drawing.Point(595, 65);
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
            this.pictureBox1.Location = new System.Drawing.Point(174, 133);
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
            this.pictureBox2.Location = new System.Drawing.Point(174, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(764, 132);
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
            this.label1.Location = new System.Drawing.Point(203, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên linh kiện";
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Enabled = false;
            this.txtNhaSanXuat.Location = new System.Drawing.Point(764, 65);
            this.txtNhaSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(216, 23);
            this.txtNhaSanXuat.TabIndex = 68;
            // 
            // txtTenLinhKien
            // 
            this.txtTenLinhKien.Enabled = false;
            this.txtTenLinhKien.Location = new System.Drawing.Point(343, 66);
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
            this.label2.Location = new System.Drawing.Point(203, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(343, 130);
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
            this.label6.Location = new System.Drawing.Point(624, 135);
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
            this.label4.Location = new System.Drawing.Point(624, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nhà sản xuất";
            // 
            // Btn_ReFresh
            // 
            this.Btn_ReFresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ReFresh.ImageOptions.Image")));
            this.Btn_ReFresh.Location = new System.Drawing.Point(910, 191);
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
            this.btnDelete.Location = new System.Drawing.Point(626, 191);
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
            this.btnUpdate.Location = new System.Drawing.Point(345, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 57);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Cập nhật linh kiện";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(70, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 60);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Thêm mới linh kiện";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DanhSachKhoHang
            // 
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 702);
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
    }
}