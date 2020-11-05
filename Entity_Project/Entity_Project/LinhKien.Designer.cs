namespace Entity_Project
{
    partial class LinhKien
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhapVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTlk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNsx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.MaLinhKien,
            this.MaKho,
            this.TenLinhKien,
            this.SoLuongNhapVe,
            this.NhaSanXuat,
            this.GiaTien,
            this.ThoiGianThem});
            this.Data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(32, 97);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(1174, 596);
            this.Data.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaLinhKien
            // 
            this.MaLinhKien.HeaderText = "Mã linh kiện";
            this.MaLinhKien.MinimumWidth = 6;
            this.MaLinhKien.Name = "MaLinhKien";
            this.MaLinhKien.ReadOnly = true;
            this.MaLinhKien.Width = 125;
            // 
            // MaKho
            // 
            this.MaKho.HeaderText = "Mã kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.ReadOnly = true;
            this.MaKho.Width = 125;
            // 
            // TenLinhKien
            // 
            this.TenLinhKien.HeaderText = "Tên Linh Kiện";
            this.TenLinhKien.MinimumWidth = 6;
            this.TenLinhKien.Name = "TenLinhKien";
            this.TenLinhKien.ReadOnly = true;
            this.TenLinhKien.Width = 200;
            // 
            // SoLuongNhapVe
            // 
            this.SoLuongNhapVe.HeaderText = "Số Lượng Nhập Về";
            this.SoLuongNhapVe.MinimumWidth = 6;
            this.SoLuongNhapVe.Name = "SoLuongNhapVe";
            this.SoLuongNhapVe.ReadOnly = true;
            this.SoLuongNhapVe.Width = 160;
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.NhaSanXuat.MinimumWidth = 6;
            this.NhaSanXuat.Name = "NhaSanXuat";
            this.NhaSanXuat.ReadOnly = true;
            this.NhaSanXuat.Width = 200;
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
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(1131, 58);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 33);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTlk
            // 
            this.txtTlk.Location = new System.Drawing.Point(608, 64);
            this.txtTlk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTlk.Name = "txtTlk";
            this.txtTlk.Size = new System.Drawing.Size(184, 23);
            this.txtTlk.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(780, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên linh kiện";
            // 
            // txtNsx
            // 
            this.txtNsx.Location = new System.Drawing.Point(940, 64);
            this.txtNsx.Margin = new System.Windows.Forms.Padding(4);
            this.txtNsx.Name = "txtNsx";
            this.txtNsx.Size = new System.Drawing.Size(184, 23);
            this.txtNsx.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nhà sản xuất";
            // 
            // LinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 705);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNsx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtTlk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.Name = "LinhKien";
            this.Text = "LinhKien";
            this.Load += new System.EventHandler(this.LinhKien_Load);
            this.Enter += new System.EventHandler(this.LinhKien_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhapVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianThem;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTlk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNsx;
        private System.Windows.Forms.Label label3;
    }
}