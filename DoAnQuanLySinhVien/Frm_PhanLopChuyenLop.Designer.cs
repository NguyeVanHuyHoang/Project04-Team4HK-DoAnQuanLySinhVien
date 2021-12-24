namespace DoAnQuanLySinhVien
{
    partial class Frm_PhanLopChuyenLop
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
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.SuspendLayout();
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(180, 144);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(113, 20);
            this.gunaCheckBox1.TabIndex = 0;
            this.gunaCheckBox1.Text = "gunaCheckBox1";
            // 
            // Frm_PhanLopChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gunaCheckBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_PhanLopChuyenLop";
            this.Text = "Frm_PhanLopChuyenLop";
            this.Load += new System.EventHandler(this.Frm_PhanLopChuyenLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
    }
}