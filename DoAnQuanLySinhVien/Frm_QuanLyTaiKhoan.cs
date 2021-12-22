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
    public partial class Frm_QuanLyTaiKhoan : Form
    {
        public Frm_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        /*******************************************/
        TaiKhoanMatKhau taiKhoanMatKhau;
        List<TaiKhoanMatKhau> listTKMK;
        TaiKhoanMatKhauDao taiKhoanMatKhauDao;
        //Biến lưu lỗi. biến này dùng truyền tham chiếu trong phương thức UpdataUser.
        string err = string.Empty;
        private void Frm_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

            taiKhoanMatKhauDao = new TaiKhoanMatKhauDao();
            taiKhoanMatKhauDao.DocFile(Cls_Main.pathfile);
            HienThiDuLieuLenCBChucVu();
            HienThi();

            txt_ID.Text = TaoTangIDTuDong();


        }

        private void HienThi()
        {
            // Đọc file để lấy danh sách User theo đường dẫn file  được cung cấp
            taiKhoanMatKhauDao.DocFile(Cls_Main.pathfile);
            // bindingsoure dùng để tự động cập nhập list user mỗi khi nhấn update
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = taiKhoanMatKhauDao.listTKMK;
            // Gán danh sách user vào thuộc tính DataSource của DataGridView
            dgv_DSTaiKhoan.DataSource = bindingSource;
            // lblQuality.Text đếm số lượng user trong dgvUserlist
            //lblQuality.Text = dgvUserlist.RowCount.ToString();
        }
        /// <summary>
        /// Phương thức lấy dữ liệu vào trong ComboBox.
        /// </summary>
        private void HienThiDuLieuLenCBChucVu()
        {
            //Tạo dữ liệu danh sách UserType.
            List<LoaiTaiKhoan> loaiTaiKhoan = new List<LoaiTaiKhoan>()
            {
                new LoaiTaiKhoan(){IDLoaiTaiKhoan=1,TenLoaiTaiKhoan="Admin"},
                new LoaiTaiKhoan(){IDLoaiTaiKhoan=2,TenLoaiTaiKhoan="User"},
            };

            //gan vao datasource cua comboBox
            cbx_ChucVu.DataSource = loaiTaiKhoan;
            //Thiet lap thuoc tinh
            cbx_ChucVu.DisplayMember = "TenLoaiTaiKhoan";
            cbx_ChucVu.ValueMember = "IDLoaiTaiKhoan";
        }
        /// <summary>
        /// Phương thức Tạo ID lớn nhất
        /// </summary>
        /// <returns></returns>
        private string TaoTangIDTuDong()
        {
            string maxID = string.Empty;
            maxID = taiKhoanMatKhauDao.TangID().ToString();
            return maxID;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_HoTen.Text))//Kiểm tra phải nhập fullname
            {
                if (!string.IsNullOrEmpty(txt_TenTK.Text))//Kiểm tra phải nhập UserName 
                {
                    if (!string.IsNullOrEmpty(txt_MatKhau.Text))//Kiểm tra phải nhập Password
                    {
                        if (cbx_ChucVu.SelectedIndex > -1)//Kiểm tra phải chọn UserType
                        {

                            //Khởi tạo User Và lấy dữ liệu từ Control,
                            taiKhoanMatKhau = new TaiKhoanMatKhau()
                            {
                                ID = Convert.ToInt32(txt_ID.Text),
                                HoTen = txt_HoTen.Text,
                                GioiTinh = rd_Nam.Checked,
                                TaiKhoan = txt_TenTK.Text,
                                MatKhau = txt_MatKhau.Text,
                                NhoMatKhau = ckb_NhoMK.Checked,
                                ChucVu = Convert.ToInt32(cbx_ChucVu.SelectedValue.ToString()),


                            };
                            //gọi phương thức UpdateUser.
                            if (ThemTK(ref err, taiKhoanMatKhau))
                            {
                                MessageBox.Show("Thêm thông tin tài khoản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HienThi();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn chức vụ tài khoản.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu tài khoản.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ThemTK(ref string err, TaiKhoanMatKhau taiKhoanMatKhau)
        {
            try
            {

                taiKhoanMatKhauDao.listTKMK.Add(taiKhoanMatKhau);//Thêm user vào trong List<User> Của UserDao

                taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);//Ghi listUser vào trong file listUser.ini
                return true;//Trả vể true khi thực hiện thành công.


            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }
        private bool SuaTK(ref string err, TaiKhoanMatKhau taiKhoanMatKhau)
        {
            try
            {
                foreach (TaiKhoanMatKhau item in taiKhoanMatKhauDao.listTKMK)
                {
                    if (item.ID == taiKhoanMatKhau.ID)
                    {
                        //taiKhoanMatKhauDao.listTKMK.Remove(taiKhoanMatKhau);
                        item.ChucVu = taiKhoanMatKhau.ChucVu;
                        item.GioiTinh = taiKhoanMatKhau.GioiTinh;
                        item.HoTen = taiKhoanMatKhau.HoTen;
                        item.MatKhau = taiKhoanMatKhau.MatKhau;
                        item.NhoMatKhau = taiKhoanMatKhau.NhoMatKhau;
                        item.TaiKhoan = taiKhoanMatKhau.TaiKhoan;
                    }
                }
                //taiKhoanMatKhauDao.listTKMK.Add(taiKhoanMatKhau);//Thêm user vào trong List<User> Của UserDao
                taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);//Ghi listUser vào trong file listUser.ini
                return true;//Trả vể true khi thực hiện thành công.


            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }
        private void dgv_DSTaiKhoan_Click_1(object sender, EventArgs e)
        {
            if (dgv_DSTaiKhoan.RowCount > 0)//Kiểm tra dataGridView có dữ liệu hay không
            {
                taiKhoanMatKhau = new TaiKhoanMatKhau()
                {
                    ID = Convert.ToInt32(dgv_DSTaiKhoan.CurrentRow.Cells["col_ID"].Value.ToString()),
                    HoTen = dgv_DSTaiKhoan.CurrentRow.Cells["col_HoVaTen"].Value.ToString(),
                    TaiKhoan = dgv_DSTaiKhoan.CurrentRow.Cells["col_TenTaiKhoan"].Value.ToString(),
                    MatKhau = dgv_DSTaiKhoan.CurrentRow.Cells["col_MatKhau"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgv_DSTaiKhoan.CurrentRow.Cells["col_NhoMatKhau"].Value.ToString()),
                    ChucVu = Convert.ToInt32(dgv_DSTaiKhoan.CurrentRow.Cells["col_ChucVu"].Value.ToString()),
                };

            }
        }
        private void dgv_DSTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            txt_ID.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_ID"].Value.ToString();
            txt_HoTen.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_HoVaTen"].Value.ToString();
            txt_TenTK.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_TenTaiKhoan"].Value.ToString();
            txt_MatKhau.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_MatKhau"].Value.ToString();
            ckb_NhoMK.Checked = Convert.ToBoolean(dgv_DSTaiKhoan.CurrentRow.Cells["col_NhoMatKhau"].Value.ToString());
            cbx_ChucVu.SelectedValue = dgv_DSTaiKhoan.CurrentRow.Cells["col_ChucVu"].Value.ToString();
            ;
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            txt_ID.Text = TaoTangIDTuDong();
            txt_HoTen.Clear();
            txt_TenTK.Clear();
            txt_MatKhau.Clear();
            HienThi();
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //if (taiKhoanMatKhau != null)
            //{
            //    foreach (TaiKhoanMatKhau item in taiKhoanMatKhauDao.listTKMK)
            //    {
            //        if (item.ID == taiKhoanMatKhau.ID)
            //        {
            //            taiKhoanMatKhauDao.listTKMK.Remove(item);
            //            return;
            //        }
            //    }
            //    taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);
            //    taiKhoanMatKhau = null;
            //    HienThi();
            //}
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu không.\n Chọn OK để xoá. Cancel để huỷ.", "Thông báo",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {   
                if (taiKhoanMatKhau != null)//Kiểm tra đã chọn User cần xoá trên dataGridView chưa.
                {
                    //Thực hiện phương thức Remove để xoá user ra khỏi listUser của UserDao.
                    //Chú ý: để phương thức này hoạt động được, phải tiến hành viết nạp chồng (override) lên phương thức Equals trong lớp User. để quy định khi so sánh 2 user sẽ dùng thuộc tính nào.
                    taiKhoanMatKhauDao.listTKMK.Remove(taiKhoanMatKhau);
                    //Ghi lại danh sách lên file listUser.ini.
                    taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);
                    taiKhoanMatKhau = null;
                    HienThi();//Hiển thị lại danh sách lên DataGridView.
                }
                
            }
           
            
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_HoTen.Text))//Kiểm tra phải nhập fullname
            {
                if (!string.IsNullOrEmpty(txt_TenTK.Text))//Kiểm tra phải nhập UserName 
                {
                    if (!string.IsNullOrEmpty(txt_MatKhau.Text))//Kiểm tra phải nhập Password
                    {
                        if (cbx_ChucVu.SelectedIndex > -1)//Kiểm tra phải chọn UserType
                        {
                            //Khởi tạo User Và lấy dữ liệu từ Control,
                            taiKhoanMatKhau = new TaiKhoanMatKhau()
                            {
                                ID = Convert.ToInt32(txt_ID.Text),
                                HoTen = txt_HoTen.Text,
                                GioiTinh = rd_Nam.Checked,
                                TaiKhoan = txt_TenTK.Text,
                                MatKhau = txt_MatKhau.Text,
                                NhoMatKhau = ckb_NhoMK.Checked,
                                ChucVu = Convert.ToInt32(cbx_ChucVu.SelectedValue.ToString()),
                            };
                            //gọi phương thức UpdateUser.
                            if (SuaTK(ref err, taiKhoanMatKhau))
                            {
                                MessageBox.Show("Sửa thông tin thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HienThi();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn chức vụ.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu tài khoản.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
