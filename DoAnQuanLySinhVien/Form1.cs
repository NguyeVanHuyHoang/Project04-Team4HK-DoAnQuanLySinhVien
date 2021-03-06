using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace DoAnQuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void LoadMenu()
        {
            pnl_Left.Width = 50;
            pnl_btn.Height = 60;
            pnl_btn2.Height = 60;
            pnl_btn3.Height = 60;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnl_Left.Width == 300)
            {
                pnl_Left.Width = 50;
                pnl_btn.Height = 60;
                pnl_btn2.Height = 60;
                pnl_btn3.Height = 60;
            }
            else
            {
                pnl_Left.Width = 300;
                
            }
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
        private void btn_TaiKhoan_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tài khoản", btn_TaiKhoan);
        }
        private void btn_QuanLySV_Click(object sender, EventArgs e)
        {
            if (pnl_btn2.Height == 180)
            {
                pnl_btn2.Height = 60;

            }
            else
            {
                pnl_Left.Width = 300;
                pnl_btn2.Height = 180;
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

        private void btn_QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            
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

        }

        private void btn_PhanLopChuyenLop_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_ThemSuaXoaLop_Click(object sender, EventArgs e)
        {

        }

        
    }
}
