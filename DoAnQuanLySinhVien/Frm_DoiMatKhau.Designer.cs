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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NhoMatKhau = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.txt_HienThiTK = new System.Windows.Forms.TextBox();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MK2 = new System.Windows.Forms.TextBox();
            this.txt_MK1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).BeginInit();
            this.grbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grbUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1368, 709);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DSTaiKhoan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(379, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(985, 674);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tài Khoản";
            // 
            // dgv_DSTaiKhoan
            // 
            this.dgv_DSTaiKhoan.AllowUserToAddRows = false;
            this.dgv_DSTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_DSTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_DSTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_DSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_HoVaTen,
            this.col_GioiTinh,
            this.col_TenTaiKhoan,
            this.col_MatKhau,
            this.col_NhoMatKhau,
            this.col_ChucVu});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSTaiKhoan.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_DSTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSTaiKhoan.Location = new System.Drawing.Point(3, 30);
            this.dgv_DSTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSTaiKhoan.Name = "dgv_DSTaiKhoan";
            this.dgv_DSTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_DSTaiKhoan.RowHeadersVisible = false;
            this.dgv_DSTaiKhoan.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_DSTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_DSTaiKhoan.RowTemplate.Height = 24;
            this.dgv_DSTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSTaiKhoan.Size = new System.Drawing.Size(979, 641);
            this.dgv_DSTaiKhoan.TabIndex = 3;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.Frozen = true;
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Width = 125;
            // 
            // col_HoVaTen
            // 
            this.col_HoVaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_HoVaTen.DataPropertyName = "HoTen";
            this.col_HoVaTen.HeaderText = "Họ và Tên";
            this.col_HoVaTen.MinimumWidth = 6;
            this.col_HoVaTen.Name = "col_HoVaTen";
            this.col_HoVaTen.ReadOnly = true;
            this.col_HoVaTen.Visible = false;
            this.col_HoVaTen.Width = 54;
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.HeaderText = "Giới Tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            this.col_GioiTinh.ReadOnly = true;
            this.col_GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_GioiTinh.Visible = false;
            this.col_GioiTinh.Width = 125;
            // 
            // col_TenTaiKhoan
            // 
            this.col_TenTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenTaiKhoan.DataPropertyName = "TaiKhoan";
            this.col_TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            this.col_TenTaiKhoan.MinimumWidth = 6;
            this.col_TenTaiKhoan.Name = "col_TenTaiKhoan";
            this.col_TenTaiKhoan.ReadOnly = true;
            // 
            // col_MatKhau
            // 
            this.col_MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MatKhau.DataPropertyName = "MatKhau";
            this.col_MatKhau.HeaderText = "Mật Khẩu";
            this.col_MatKhau.MinimumWidth = 6;
            this.col_MatKhau.Name = "col_MatKhau";
            this.col_MatKhau.ReadOnly = true;
            this.col_MatKhau.Width = 150;
            // 
            // col_NhoMatKhau
            // 
            this.col_NhoMatKhau.DataPropertyName = "NhoMatKhau";
            this.col_NhoMatKhau.HeaderText = "Nhớ Mật Khẩu";
            this.col_NhoMatKhau.MinimumWidth = 6;
            this.col_NhoMatKhau.Name = "col_NhoMatKhau";
            this.col_NhoMatKhau.ReadOnly = true;
            this.col_NhoMatKhau.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_NhoMatKhau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_NhoMatKhau.Width = 125;
            // 
            // col_ChucVu
            // 
            this.col_ChucVu.DataPropertyName = "ChucVu";
            this.col_ChucVu.HeaderText = "Chức Vụ";
            this.col_ChucVu.MinimumWidth = 6;
            this.col_ChucVu.Name = "col_ChucVu";
            this.col_ChucVu.ReadOnly = true;
            this.col_ChucVu.Width = 125;
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.btn_TaiLai);
            this.grbUser.Controls.Add(this.txt_HienThiTK);
            this.grbUser.Controls.Add(this.lbl_TaiKhoan);
            this.grbUser.Controls.Add(this.btn_DongY);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.txt_MK2);
            this.grbUser.Controls.Add(this.txt_MK1);
            this.grbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUser.ForeColor = System.Drawing.Color.White;
            this.grbUser.Location = new System.Drawing.Point(4, 31);
            this.grbUser.Margin = new System.Windows.Forms.Padding(4);
            this.grbUser.Name = "grbUser";
            this.grbUser.Padding = new System.Windows.Forms.Padding(4);
            this.grbUser.Size = new System.Drawing.Size(375, 674);
            this.grbUser.TabIndex = 5;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Tài Khoản- Đổi Mật Khẩu";
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_TaiLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_TaiLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_TaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.ForeColor = System.Drawing.Color.Black;
            this.btn_TaiLai.Location = new System.Drawing.Point(18, 313);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(154, 39);
            this.btn_TaiLai.TabIndex = 7;
            this.btn_TaiLai.Text = "Tải Lại";
            this.btn_TaiLai.UseVisualStyleBackColor = false;
            // 
            // txt_HienThiTK
            // 
            this.txt_HienThiTK.Enabled = false;
            this.txt_HienThiTK.Location = new System.Drawing.Point(16, 62);
            this.txt_HienThiTK.Name = "txt_HienThiTK";
            this.txt_HienThiTK.Size = new System.Drawing.Size(184, 28);
            this.txt_HienThiTK.TabIndex = 6;
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(24, 30);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(129, 29);
            this.lbl_TaiKhoan.TabIndex = 5;
            this.lbl_TaiKhoan.Text = "Tài Khoản:";
            // 
            // btn_DongY
            // 
            this.btn_DongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_DongY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_DongY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_DongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.ForeColor = System.Drawing.Color.Black;
            this.btn_DongY.Location = new System.Drawing.Point(180, 313);
            this.btn_DongY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(154, 39);
            this.btn_DongY.TabIndex = 4;
            this.btn_DongY.Text = "Đồng ý";
            this.btn_DongY.UseVisualStyleBackColor = false;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 203);
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
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txt_MK2
            // 
            this.txt_MK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK2.Location = new System.Drawing.Point(16, 229);
            this.txt_MK2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MK2.Name = "txt_MK2";
            this.txt_MK2.Size = new System.Drawing.Size(225, 28);
            this.txt_MK2.TabIndex = 1;
            // 
            // txt_MK1
            // 
            this.txt_MK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK1.Location = new System.Drawing.Point(16, 155);
            this.txt_MK1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MK1.Name = "txt_MK1";
            this.txt_MK1.Size = new System.Drawing.Size(225, 28);
            this.txt_MK1.TabIndex = 0;
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1368, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).EndInit();
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MK2;
        private System.Windows.Forms.TextBox txt_MK1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DSTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoVaTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_NhoMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChucVu;
        private System.Windows.Forms.TextBox txt_HienThiTK;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.Button btn_TaiLai;
    }
}