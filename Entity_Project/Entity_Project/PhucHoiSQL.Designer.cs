﻿
namespace Entity_Project
{
    partial class PhucHoiSQL
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChonTepTin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChonTepTin
            // 
            this.btnChonTepTin.Location = new System.Drawing.Point(198, 330);
            this.btnChonTepTin.Name = "btnChonTepTin";
            this.btnChonTepTin.Size = new System.Drawing.Size(344, 59);
            this.btnChonTepTin.TabIndex = 0;
            this.btnChonTepTin.Text = "Chọn đường dẫn đến tệp tin cần sao lưu (.bak)";
            this.btnChonTepTin.UseVisualStyleBackColor = true;
            this.btnChonTepTin.Click += new System.EventHandler(this.btnChonTepTin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entity_Project.Properties.Resources._71a75dace5dd09eb98fb0bee98a85876;
            this.pictureBox1.Location = new System.Drawing.Point(152, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(84, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lưu ý khi bắt đầu phục hồi sẽ xảy ra hiện tượng đứng chương trình nhưng đừng quá " +
    "lo lắng,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(126, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "hãy bình tĩnh đợi hoàn thành và nhớ rằng khi khung này tắt hẳn hãy sử dụng tiếp";
            // 
            // PhucHoiSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChonTepTin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PhucHoiSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhucHoiSQL";
            this.Load += new System.EventHandler(this.PhucHoiSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChonTepTin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}