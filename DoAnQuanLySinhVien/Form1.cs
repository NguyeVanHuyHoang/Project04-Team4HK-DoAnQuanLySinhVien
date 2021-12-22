using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DoAnQuanLySinhVien.Data;
using DoAnQuanLySinhVien.DataSinhVien;


namespace DoAnQuanLySinhVien
{
    public partial class Form1 : Form
    {
        TaiKhoanMatKhauDao taiKhoanMatKhauDao;
        SinhVienDao sinhVienDao;
        public Form1()
        {
            InitializeComponent();

        }


        int chucVu = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            taiKhoanMatKhauDao = new TaiKhoanMatKhauDao();

            taiKhoanMatKhauDao.DocFile(Cls_Main.pathfile);
            Cls_Main._listTKMK = taiKhoanMatKhauDao.listTKMK;
            
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            LoadMenu();
            TrangChu();
            chucVu = Cls_Main._staticTKMK.ChucVu;     
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            switch (chucVu)
            {
                case 1:
                    btn_QuanLyTaiKhoan.Enabled = true;
                    break;
                case 2:
                    btn_QuanLyTaiKhoan.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void LoadMenu()
        {
            pnl_Left.Width = 50;
            pnl_btn.Height = 60;
            pnl_btn2.Height = 60;
            pnl_btn3.Height = 60;
            pnl_Bot.Height = 60;
        }

        private void btn_ThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region Dieu khiem mo form tren tabcontrol DOTBar2
        private bool trangThaiMoTa = false;
        string tieuDeTab;
        public Form1 form1;
        public delegate void _deDongTab();
        /// <summary>
        /// Phuong thuc kiem 1 tab da duoc mo hay chua
        /// </summary>
        /// <param name="name">ten của form</param>
        /// <returns>true: đã mở; false: chưa mở</returns>
        private bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < tc_Main.Tabs.Count; i++)
            {
                if (tc_Main.Tabs[i].Text == name)
                {
                    tc_Main.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void tc_Main_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            TabItem t = tc_Main.SelectedTab;
            tc_Main.Tabs.Remove(t);
        }

        private void DongTab()
        {
            foreach (TabItem item in tc_Main.Tabs)
            {
                if (item.IsSelected)
                {
                    tc_Main.Tabs.Remove(item);
                    return;
                }
            }
        }


        #endregion


        #region HOVER chuột vào button

        private void btn_TaiKhoan_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tài khoản.", btn_TaiKhoan);
        }
        private void btn_QuanLyDSL_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Quản lý danh sách lớp.", btn_QuanLyDSL);
        }
        private void btn_QuanLySV_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Quản lý tài khoản.", btn_QuanLySV);
        }
        #endregion


        #region co giãn các button và pannel
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnl_Left.Width == 300)
            {
                pnl_Left.Width = 50;
                pnl_btn.Height = 60;
                pnl_btn2.Height = 60;
                pnl_btn3.Height = 60;
                pnl_Bot.Height = 60;
            }
            else
            {
                pnl_Left.Width = 300;

            }
        }
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            if (pnl_btn.Height == 180)
            {
                pnl_btn.Height = 60;

            }
            else
            {
                pnl_Left.Width = 300;
                pnl_btn.Height = 180;
                pnl_btn2.Height = 60;
                pnl_btn3.Height = 60;
            }
        }
        private void btn_QuanLySV_Click(object sender, EventArgs e)
        {
            if (pnl_btn2.Height == 120)
            {
                pnl_btn2.Height = 60;

            }
            else
            {
                pnl_Left.Width = 300;
                pnl_btn2.Height = 120;
                pnl_btn.Height = 60;
                pnl_btn3.Height = 60;
            }
        }
        private void btn_QuanLyDSL_Click(object sender, EventArgs e)
        {
            if (pnl_btn3.Height == 120)
            {
                pnl_btn3.Height = 60;

            }
            else
            {
                pnl_Left.Width = 300;
                pnl_btn.Height = 60;
                pnl_btn2.Height = 60;
                pnl_btn3.Height = 120;
            }
        }
        #endregion


        #region hiện form lên tabcontol
        private void TrangChu()
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Trang Chủ";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_QuanLyTaiKhoan ";
                Frm_TrangChu frm = new Frm_TrangChu()
                {
                    DongTab = new Frm_TrangChu._deDongTab(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }
        private void btn_QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Quản lý tài khoản";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_QuanLyTaiKhoan ";
                Frm_QuanLyTaiKhoan frm = new Frm_QuanLyTaiKhoan()
                {
                    DongTab = new Frm_QuanLyTaiKhoan._deDongTab(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }





        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Doi Mat Khau";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_Use_UserControl";
                Frm_DoiMatKhau frm = new Frm_DoiMatKhau()
                {
                    DongTab = new Frm_DoiMatKhau._deDongTab(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }

        private void btn_ThemSuaXoaTTSV_Click(object sender, EventArgs e)
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Thêm sửa xoá thông tin sinh viên";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_QuanLyTaiKhoan ";
                Frm_ThemSuaXoaSinhVien frm = new Frm_ThemSuaXoaSinhVien()
                {
                    DongTab = new Frm_ThemSuaXoaSinhVien._deDongTab(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill


                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }

        private void btn_PhanLopChuyenLop_Click(object sender, EventArgs e)
        {

        }



        private void btn_ThemSuaXoaLop_Click(object sender, EventArgs e)
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Thêm,sửa,xoá lớp";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_PhanLopChuyenLop";
                Frm_ThemSuaXoaLop frm = new Frm_ThemSuaXoaLop()
                {
                    DongTab = new Frm_ThemSuaXoaLop._deDongTab(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }




        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            btn_Minimized.Visible = false;
            btn_Maximize.Visible = true;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_Maximize.Visible = false;
            btn_Minimized.Visible = true;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Cls_Main._staticTKMK = null;
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.Show();
            
            


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tắt trương trình hay không.\n Chọn OK để tắt. Cancel để huỷ.", "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
