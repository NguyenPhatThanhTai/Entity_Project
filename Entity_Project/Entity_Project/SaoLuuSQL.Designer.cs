
namespace Entity_Project
{
    partial class SaoLuuSQL
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
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.txtTenSaoLuu = new System.Windows.Forms.TextBox();
            this.btnChonDuongDan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.txtNameOfSave = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.Location = new System.Drawing.Point(41, 126);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(451, 28);
            this.txtDuongDan.TabIndex = 1;
            // 
            // txtTenSaoLuu
            // 
            this.txtTenSaoLuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSaoLuu.Location = new System.Drawing.Point(41, 85);
            this.txtTenSaoLuu.Name = "txtTenSaoLuu";
            this.txtTenSaoLuu.Size = new System.Drawing.Size(178, 28);
            this.txtTenSaoLuu.TabIndex = 0;
            // 
            // btnChonDuongDan
            // 
            this.btnChonDuongDan.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChonDuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDuongDan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDuongDan.ForeColor = System.Drawing.Color.White;
            this.btnChonDuongDan.Location = new System.Drawing.Point(498, 126);
            this.btnChonDuongDan.Name = "btnChonDuongDan";
            this.btnChonDuongDan.Size = new System.Drawing.Size(162, 30);
            this.btnChonDuongDan.TabIndex = 2;
            this.btnChonDuongDan.Text = "Chọn đường dẫn lưu";
            this.btnChonDuongDan.UseVisualStyleBackColor = false;
            this.btnChonDuongDan.Click += new System.EventHandler(this.btnChonDuongDan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sao lưu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaoLuu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.ForeColor = System.Drawing.Color.White;
            this.btnSaoLuu.Location = new System.Drawing.Point(41, 162);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(619, 30);
            this.btnSaoLuu.TabIndex = 4;
            this.btnSaoLuu.Text = "Tiến hành sao lưu";
            this.btnSaoLuu.UseVisualStyleBackColor = false;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // txtNameOfSave
            // 
            this.txtNameOfSave.AutoSize = true;
            this.txtNameOfSave.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfSave.Location = new System.Drawing.Point(225, 88);
            this.txtNameOfSave.Name = "txtNameOfSave";
            this.txtNameOfSave.Size = new System.Drawing.Size(41, 21);
            this.txtNameOfSave.TabIndex = 5;
            this.txtNameOfSave.Text = ".bak";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entity_Project.Properties.Resources._71a75dace5dd09eb98fb0bee98a85876;
            this.pictureBox1.Location = new System.Drawing.Point(83, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SaoLuuSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNameOfSave);
            this.Controls.Add(this.btnSaoLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChonDuongDan);
            this.Controls.Add(this.txtTenSaoLuu);
            this.Controls.Add(this.txtDuongDan);
            this.Name = "SaoLuuSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaoLuuSQL";
            this.Load += new System.EventHandler(this.SaoLuuSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.TextBox txtTenSaoLuu;
        private System.Windows.Forms.Button btnChonDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Label txtNameOfSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}