namespace DoAnQuanLySinhVien
{
    partial class Frm_ThemSuaXoaSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DSSinhVien = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.txt_Gmail = new System.Windows.Forms.TextBox();
            this.cbx_Khoa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_Lop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_STT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_InDS = new CustomButton.VBButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new CustomButton.VBButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1368, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_DSSinhVien
            // 
            this.dgv_DSSinhVien.AllowUserToAddRows = false;
            this.dgv_DSSinhVien.AllowUserToDeleteRows = false;
            this.dgv_DSSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgv_DSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_MSSV,
            this.col_HoTen,
            this.col_GioiTinh,
            this.col_Lop,
            this.col_Khoa,
            this.col_NgaySinh,
            this.col_Gmail});
            this.dgv_DSSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSSinhVien.Location = new System.Drawing.Point(3, 74);
            this.dgv_DSSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DSSinhVien.Name = "dgv_DSSinhVien";
            this.dgv_DSSinhVien.ReadOnly = true;
            this.dgv_DSSinhVien.RowHeadersVisible = false;
            this.dgv_DSSinhVien.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_DSSinhVien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSSinhVien.RowTemplate.Height = 24;
            this.dgv_DSSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSinhVien.Size = new System.Drawing.Size(988, 637);
            this.dgv_DSSinhVien.TabIndex = 2;
            this.dgv_DSSinhVien.Click += new System.EventHandler(this.dgv_DSSinhVien_Click);
            this.dgv_DSSinhVien.DoubleClick += new System.EventHandler(this.dgv_DSSinhVien_DoubleClick);
            // 
            // col_STT
            // 
            this.col_STT.DataPropertyName = "STT";
            this.col_STT.HeaderText = "STT";
            this.col_STT.MinimumWidth = 6;
            this.col_STT.Name = "col_STT";
            this.col_STT.ReadOnly = true;
            this.col_STT.Width = 50;
            // 
            // col_MSSV
            // 
            this.col_MSSV.DataPropertyName = "MSSV";
            this.col_MSSV.HeaderText = "MSSV";
            this.col_MSSV.MinimumWidth = 6;
            this.col_MSSV.Name = "col_MSSV";
            this.col_MSSV.ReadOnly = true;
            this.col_MSSV.Width = 80;
            // 
            // col_HoTen
            // 
            this.col_HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_HoTen.DataPropertyName = "TenSV";
            this.col_HoTen.HeaderText = "Họ Và Tên";
            this.col_HoTen.MinimumWidth = 6;
            this.col_HoTen.Name = "col_HoTen";
            this.col_HoTen.ReadOnly = true;
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
            this.col_GioiTinh.Width = 50;
            // 
            // col_Lop
            // 
            this.col_Lop.DataPropertyName = "Lop";
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.MinimumWidth = 6;
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.ReadOnly = true;
            this.col_Lop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Lop.Width = 125;
            // 
            // col_Khoa
            // 
            this.col_Khoa.DataPropertyName = "Khoa";
            this.col_Khoa.HeaderText = "Khoa";
            this.col_Khoa.MinimumWidth = 6;
            this.col_Khoa.Name = "col_Khoa";
            this.col_Khoa.ReadOnly = true;
            this.col_Khoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Khoa.Width = 125;
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.DataPropertyName = "NgaySinh";
            this.col_NgaySinh.HeaderText = "Ngày Sinh";
            this.col_NgaySinh.MinimumWidth = 6;
            this.col_NgaySinh.Name = "col_NgaySinh";
            this.col_NgaySinh.ReadOnly = true;
            this.col_NgaySinh.Width = 125;
            // 
            // col_Gmail
            // 
            this.col_Gmail.DataPropertyName = "Gmail";
            this.col_Gmail.HeaderText = "Gmail";
            this.col_Gmail.MinimumWidth = 6;
            this.col_Gmail.Name = "col_Gmail";
            this.col_Gmail.ReadOnly = true;
            this.col_Gmail.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới Tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 424);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gmail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoa :";
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Nam.Location = new System.Drawing.Point(129, 212);
            this.rd_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(65, 24);
            this.rd_Nam.TabIndex = 5;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Nu.Location = new System.Drawing.Point(202, 211);
            this.rd_Nu.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(51, 24);
            this.rd_Nu.TabIndex = 6;
            this.rd_Nu.TabStop = true;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = true;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MSSV.Location = new System.Drawing.Point(133, 109);
            this.txt_MSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(225, 27);
            this.txt_MSSV.TabIndex = 7;
            this.txt_MSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MSSV_KeyPress);
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gmail.Location = new System.Drawing.Point(129, 424);
            this.txt_Gmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.Size = new System.Drawing.Size(225, 27);
            this.txt_Gmail.TabIndex = 9;
            // 
            // cbx_Khoa
            // 
            this.cbx_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Khoa.FormattingEnabled = true;
            this.cbx_Khoa.Location = new System.Drawing.Point(129, 316);
            this.cbx_Khoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Khoa.Name = "cbx_Khoa";
            this.cbx_Khoa.Size = new System.Drawing.Size(225, 28);
            this.cbx_Khoa.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Họ Và Tên :";
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSV.Location = new System.Drawing.Point(133, 162);
            this.txt_TenSV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(225, 27);
            this.txt_TenSV.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lớp :";
            // 
            // cbx_Lop
            // 
            this.cbx_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Lop.FormattingEnabled = true;
            this.cbx_Lop.Location = new System.Drawing.Point(129, 260);
            this.cbx_Lop.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Lop.Name = "cbx_Lop";
            this.cbx_Lop.Size = new System.Drawing.Size(225, 28);
            this.cbx_Lop.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_STT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_TaiLai);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.cbx_Lop);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_TenSV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbx_Khoa);
            this.groupBox1.Controls.Add(this.txt_Gmail);
            this.groupBox1.Controls.Add(this.txt_MSSV);
            this.groupBox1.Controls.Add(this.rd_Nu);
            this.groupBox1.Controls.Add(this.rd_Nam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(374, 714);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinh.Location = new System.Drawing.Point(129, 374);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(225, 27);
            this.date_NgaySinh.TabIndex = 26;
            // 
            // txt_STT
            // 
            this.txt_STT.Enabled = false;
            this.txt_STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STT.Location = new System.Drawing.Point(133, 64);
            this.txt_STT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Size = new System.Drawing.Size(225, 27);
            this.txt_STT.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "STT :";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Location = new System.Drawing.Point(214, 522);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(144, 40);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "Sữa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_TaiLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_TaiLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_TaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.ForeColor = System.Drawing.Color.Black;
            this.btn_TaiLai.Location = new System.Drawing.Point(210, 623);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(144, 40);
            this.btn_TaiLai.TabIndex = 22;
            this.btn_TaiLai.Text = "Tải Lại";
            this.btn_TaiLai.UseVisualStyleBackColor = false;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(30, 623);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(144, 40);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(30, 522);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(144, 40);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_InDS);
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 48);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_InDS
            // 
            this.btn_InDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_InDS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_InDS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_InDS.BorderRadius = 20;
            this.btn_InDS.BorderSize = 0;
            this.btn_InDS.FlatAppearance.BorderSize = 0;
            this.btn_InDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_InDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_InDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InDS.ForeColor = System.Drawing.Color.White;
            this.btn_InDS.Location = new System.Drawing.Point(523, 7);
            this.btn_InDS.Name = "btn_InDS";
            this.btn_InDS.Size = new System.Drawing.Size(129, 33);
            this.btn_InDS.TabIndex = 9;
            this.btn_InDS.Text = "In DS";
            this.btn_InDS.TextColor = System.Drawing.Color.White;
            this.btn_InDS.UseVisualStyleBackColor = false;
            this.btn_InDS.Click += new System.EventHandler(this.btn_InDS_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(3, 11);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(366, 30);
            this.txt_TimKiem.TabIndex = 7;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimKiem_KeyPress);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_TimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_TimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TimKiem.BorderRadius = 20;
            this.btn_TimKiem.BorderSize = 0;
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_TimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(374, 7);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(129, 33);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextColor = System.Drawing.Color.White;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DSSinhVien);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(374, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 714);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // Frm_ThemSuaXoaSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1368, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThemSuaXoaSinhVien";
            this.Text = "Frm_ThemSuaXoaSinhVien";
            this.Load += new System.EventHandler(this.Frm_ThemSuaXoaSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DSSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.TextBox txt_Gmail;
        private System.Windows.Forms.ComboBox cbx_Khoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_Lop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_STT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Panel panel2;
        private CustomButton.VBButton btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gmail;
        private CustomButton.VBButton btn_InDS;
    }
}