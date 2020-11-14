
namespace Entity_Project
{
    partial class YeuCauTroGiup
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
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.txtDoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(105, 91);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(893, 523);
            this.txtNoiDung.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập nội dung lỗi cần yêu cầu trợ giúp";
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuiYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnGuiYeuCau.Location = new System.Drawing.Point(846, 620);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(152, 39);
            this.btnGuiYeuCau.TabIndex = 2;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu trợ giúp";
            this.btnGuiYeuCau.UseVisualStyleBackColor = false;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // txtDoi
            // 
            this.txtDoi.AutoSize = true;
            this.txtDoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoi.ForeColor = System.Drawing.Color.Red;
            this.txtDoi.Location = new System.Drawing.Point(798, 67);
            this.txtDoi.Name = "txtDoi";
            this.txtDoi.Size = new System.Drawing.Size(200, 21);
            this.txtDoi.TabIndex = 3;
            this.txtDoi.Text = "Vui lòng đợi trong giây lát";
            // 
            // YeuCauTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 722);
            this.Controls.Add(this.txtDoi);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "YeuCauTroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeuCauTroGiup";
            this.Load += new System.EventHandler(this.YeuCauTroGiup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Label txtDoi;
    }
}