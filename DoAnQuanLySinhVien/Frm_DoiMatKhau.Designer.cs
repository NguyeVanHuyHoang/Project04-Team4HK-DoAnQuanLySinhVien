namespace DoAnQuanLySinhVien
{
    partial class Frm_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.btnChangedPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordTwo = new System.Windows.Forms.TextBox();
            this.txtPasswordNewOne = new System.Windows.Forms.TextBox();
            this.grb_Admin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.grbUser.SuspendLayout();
            this.grb_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1368, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbUser);
            this.groupBox1.Controls.Add(this.grb_Admin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(831, 709);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin ";
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.btnChangedPassword);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.txtPasswordTwo);
            this.grbUser.Controls.Add(this.txtPasswordNewOne);
            this.grbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbUser.Location = new System.Drawing.Point(4, 223);
            this.grbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbUser.Name = "grbUser";
            this.grbUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbUser.Size = new System.Drawing.Size(823, 261);
            this.grbUser.TabIndex = 5;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "User- Đổi Mật Khẩu";
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnChangedPassword.Location = new System.Drawing.Point(538, 175);
            this.btnChangedPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.Size = new System.Drawing.Size(237, 62);
            this.btnChangedPassword.TabIndex = 4;
            this.btnChangedPassword.Text = "Đồng ý";
            this.btnChangedPassword.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtPasswordTwo
            // 
            this.txtPasswordTwo.Location = new System.Drawing.Point(334, 124);
            this.txtPasswordTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordTwo.Name = "txtPasswordTwo";
            this.txtPasswordTwo.Size = new System.Drawing.Size(440, 34);
            this.txtPasswordTwo.TabIndex = 1;
            // 
            // txtPasswordNewOne
            // 
            this.txtPasswordNewOne.Location = new System.Drawing.Point(334, 65);
            this.txtPasswordNewOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordNewOne.Name = "txtPasswordNewOne";
            this.txtPasswordNewOne.Size = new System.Drawing.Size(440, 34);
            this.txtPasswordNewOne.TabIndex = 0;
            // 
            // grb_Admin
            // 
            this.grb_Admin.Controls.Add(this.label4);
            this.grb_Admin.Controls.Add(this.btnResetPassword);
            this.grb_Admin.Controls.Add(this.cboUser);
            this.grb_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_Admin.Location = new System.Drawing.Point(4, 31);
            this.grb_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Admin.Name = "grb_Admin";
            this.grb_Admin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Admin.Size = new System.Drawing.Size(823, 192);
            this.grb_Admin.TabIndex = 4;
            this.grb_Admin.TabStop = false;
            this.grb_Admin.Text = "Admin- Khôi Phục Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn tài khoản:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnResetPassword.Location = new System.Drawing.Point(538, 106);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(237, 64);
            this.btnResetPassword.TabIndex = 1;
            this.btnResetPassword.Text = "Đồng ý";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(321, 48);
            this.cboUser.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(453, 37);
            this.cboUser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(831, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 709);
            this.panel1.TabIndex = 3;
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1368, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grb_Admin.ResumeLayout(false);
            this.grb_Admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Button btnChangedPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordTwo;
        private System.Windows.Forms.TextBox txtPasswordNewOne;
        private System.Windows.Forms.GroupBox grb_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ComboBox cboUser;
    }
}