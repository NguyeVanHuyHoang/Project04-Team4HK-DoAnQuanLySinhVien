using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLySinhVien.Data;

namespace DoAnQuanLySinhVien
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        List<TaiKhoanMatKhau> listTKMK;
        private TaiKhoanMatKhauDao taiKhoanMatKhauDao;

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            taiKhoanMatKhauDao = new TaiKhoanMatKhauDao();

            taiKhoanMatKhauDao.DocFile(Cls_Main.pathfile);
            Cls_Main._listTKMK = taiKhoanMatKhauDao.listTKMK;
            listTKMK =Cls_Main._listTKMK;
            
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //kiem tra 2 txtbox co nhap hay khong
            if (!string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txt_MatKhau.Text))
                {
                    //kiem tra xem txt vua nhap co trung voi username va pass hay khong--> if...else...

                    if (KiemTraDangNhap(txt_TaiKhoan.Text, txt_MatKhau.Text))
                    {
                        //Kiem tra bien nho
                        //_user.user.Remember = ckbRemember.Checked;
                        //Cls_Main._staticUser = _user.user;    
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool KiemTraDangNhap(string userName, string passWord)
        {
            foreach (TaiKhoanMatKhau item in listTKMK)
            {
                if (item.TaiKhoan.Equals(userName) && item.MatKhau.Equals(passWord))
                {
                    item.NhoMatKhau = ckb_NhoMatKhau.Checked;
                    Cls_Main._staticTKMK = item;
                    return true;
                }
            }
            return false;
        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            foreach (TaiKhoanMatKhau item in listTKMK)
            {
                if (item.TaiKhoan == txt_TaiKhoan.Text && item.NhoMatKhau)
                {
                    ckb_NhoMatKhau.Checked = true;

                    txt_MatKhau.Text = item.MatKhau;
                    btn_DangNhap.Focus();
                }

            }
        }
    }
}
