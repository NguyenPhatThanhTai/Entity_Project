
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
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChonTepTin
            // 
            this.btnChonTepTin.Location = new System.Drawing.Point(156, 105);
            this.btnChonTepTin.Name = "btnChonTepTin";
            this.btnChonTepTin.Size = new System.Drawing.Size(121, 23);
            this.btnChonTepTin.TabIndex = 0;
            this.btnChonTepTin.Text = "Chọn tệp tin";
            this.btnChonTepTin.UseVisualStyleBackColor = true;
            this.btnChonTepTin.Click += new System.EventHandler(this.btnChonTepTin_Click);
            // 
            // PhucHoiSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 231);
            this.Controls.Add(this.btnChonTepTin);
            this.Name = "PhucHoiSQL";
            this.Text = "PhucHoiSQL";
            this.Load += new System.EventHandler(this.PhucHoiSQL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChonTepTin;
    }
}