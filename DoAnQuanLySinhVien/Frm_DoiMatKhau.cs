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
    public partial class Frm_DoiMatKhau : Form
    {
        TaiKhoanMatKhauDao taiKhoanMatKhauDao;
        
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        int idTaiKhoan = 0;

        List<TaiKhoanMatKhau> tk;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            tk = new List<TaiKhoanMatKhau>();
            taiKhoanMatKhauDao = new TaiKhoanMatKhauDao();
            // Hiển thị ID và UserName lên lblUserName
            idTaiKhoan = Cls_Main._staticTKMK.ID;
            
            txt_HienThiTK.Text = string.Format("{0}", idTaiKhoan.ToString(), Cls_Main._staticTKMK.TaiKhoan.ToUpper());
            HienThi();
            hienthi1();


        }
        
        private void hienthi1()
        {
            if (!string.IsNullOrEmpty(txt_HienThiTK.Text))
            {
                foreach (TaiKhoanMatKhau item in taiKhoanMatKhauDao.listTKMK)
                {
                    if (item.ID == Convert.ToInt32(txt_HienThiTK.Text))
                    {
                        tk.Add(item);
                    }

                }
            }
            HienThi();
        }
       
        private void HienThi()
        {
            // Đọc file để lấy danh sách User theo đường dẫn file  được cung cấp
            taiKhoanMatKhauDao.DocFile(Cls_Main.pathfile);
            // bindingsoure dùng để tự động cập nhập list user mỗi khi nhấn update
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tk;
            // Gán danh sách user vào thuộc tính DataSource của DataGridView
            dgv_DSTaiKhoan.DataSource = bindingSource;
            // lblQuality.Text đếm số lượng user trong dgvUserlist
            //lblQuality.Text = dgvUserlist.RowCount.ToString();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MK1.Text))
            {
                if (!string.IsNullOrEmpty(txt_MK2.Text))
                {
                    if (txt_MK1.Text.Equals(txt_MK2.Text))
                    {
                        if (DoiMatKhau(txt_MK1.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không đúng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu 1.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu 2:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool DoiMatKhau(string matKhauMoi)
        {
            foreach (TaiKhoanMatKhau item in Cls_Main._listTKMK)
            {
                if (item.ID == idTaiKhoan)
                {
                    item.MatKhau = matKhauMoi;
                    taiKhoanMatKhauDao.listTKMK = Cls_Main._listTKMK;
                    taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);
                    return true;
                }
            }
            return false;
        }

      
    }
}
