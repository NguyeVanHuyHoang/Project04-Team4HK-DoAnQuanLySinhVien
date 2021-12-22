using DoAnQuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLySinhVien
{
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        List<TaiKhoanMatKhau> _listTKMK;
        TaiKhoanMatKhauDao taiKhoanMatKhauDao;
        int id = 0;
        //doimatkhau
        String chucVu;
        Boolean loadcbo = false;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            taiKhoanMatKhauDao = new TaiKhoanMatKhauDao();
            lblUserName.Text = Cls_Main._staticTKMK.ChucVu.ToString();
            id= Cls_Main._staticTKMK.ID;
            chucVu = Cls_Main._staticTKMK.ChucVu;
            
            switch (chucVu)
            {
                case "Admin":
                    grb_Admin.Enabled = true;
                    break;
                case "User":
                    grb_Admin.Enabled = false;
                    break;
                default :
                    grb_Admin.Enabled = false;
                    break;
            }
            _listTKMK = Cls_Main._listTKMK;
            LoadTaiKhoanMatKhau();
        }

        private void LoadTaiKhoanMatKhau()
        {
            cboUser.DataSource = _listTKMK;
            cboUser.DisplayMember = "TaiKhoan";
            cboUser.SelectedIndex = -1;
            cboUser.Text = "--------------------------- Select User ------------------------------";
            loadcbo = true;
        }

        private void grbUser_Enter(object sender, EventArgs e)
        {

        }

        private void grb_Admin_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            foreach (TaiKhoanMatKhau item in Cls_Main._listTKMK)
            {
                if (item.ChucVu == chucVu )
                {
                    item.MatKhau = item.TaiKhoan;
                    taiKhoanMatKhauDao.listTKMK = Cls_Main._listTKMK;
                    taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);
                    if (item.MatKhau==item.TaiKhoan)
                    {
                        MessageBox.Show("1");
                    }
                }
            }
        }





        private void btnChangedPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPasswordNewOne.Text))
            {
                if (!string.IsNullOrEmpty(txtPasswordTwo.Text))
                {
                    if (txtPasswordNewOne.Text.Equals(txtPasswordTwo.Text))
                    {
                        ChangedPassword(txtPasswordNewOne.Text);
                    }
                }
            }
        }

        private void ChangedPassword(string  passNew)
        {
            foreach (TaiKhoanMatKhau item in Cls_Main._listTKMK)
            {
                //if (item.ID == int=)
                //{
                //    item.MatKhau = passNew;

                //}
            }
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUser.SelectedIndex >= -1&&loadcbo== true)
            {
                chucVu = cboUser.SelectedValue.ToString();
            }
        }
    }
}
