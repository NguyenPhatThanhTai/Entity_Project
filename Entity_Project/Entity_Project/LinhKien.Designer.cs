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
            this.STT.Width = 125;
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
            // LinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 705);
            this.Controls.Add(this.Data);
            this.Name = "LinhKien";
            this.Text = "LinhKien";
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

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
    }
}