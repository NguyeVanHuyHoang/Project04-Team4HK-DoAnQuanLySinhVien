using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLySinhVien.DataLop;

namespace DoAnQuanLySinhVien
{
    public partial class Frm_ThemSuaXoaLop : Form
    {
        public Frm_ThemSuaXoaLop()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;

        Lop lop;
        List<Lop> ListLop = new List<Lop>();
        LopDao lopDao;
        //Biến lưu lỗi. biến này dùng truyền tham chiếu trong phương thức UpdataUser.
        string err = string.Empty;


        private void Frm_ThemSuaXoaLop_Load(object sender, EventArgs e)
        {
            lop = new Lop();
            lopDao = new LopDao();
            lopDao.DocFileLop(Cls_Main.pathfileLopHoc);
            LoadDataToComUserType();
            GetDataToDataGridView();

            txt_STT.Text = CreateMaxID();
        }
        private void LoadDataToComUserType()
        {
            //Tạo dữ liệu danh sách UserType.
            List<LoaiKhoa> loaiKhoa = new List<LoaiKhoa>()
            {
                new LoaiKhoa(){TenLoaiKhoa="CNTT"},
                new LoaiKhoa(){TenLoaiKhoa="QTKT-QT"},
                new LoaiKhoa(){TenLoaiKhoa="Cơ Điện"},
                new LoaiKhoa(){TenLoaiKhoa="NN Trung"},
                new LoaiKhoa(){TenLoaiKhoa="NN Hàn"},
                 new LoaiKhoa(){TenLoaiKhoa="NN Nhật"},
            new LoaiKhoa(){TenLoaiKhoa="Dược"},
            };

            List<LoaiKhoaHoc> loaiKhoaHoc = new List<LoaiKhoaHoc>()
            {
                new LoaiKhoaHoc(){TenLoaiKhoaHoc="17"},
                new LoaiKhoaHoc(){TenLoaiKhoaHoc="18"},
                new LoaiKhoaHoc(){TenLoaiKhoaHoc="19"},
                new LoaiKhoaHoc(){TenLoaiKhoaHoc="20"},
            };

            List<LoaiLopHoc> loaiLopHoc = new List<LoaiLopHoc>()
            {
                new LoaiLopHoc(){TenLoaiLopHoc="20CT111"},
                new LoaiLopHoc(){TenLoaiLopHoc="20CT112"},
                new LoaiLopHoc(){TenLoaiLopHoc="20CT113"},
                new LoaiLopHoc(){TenLoaiLopHoc="20CT114"},
                new LoaiLopHoc(){TenLoaiLopHoc="19CT111"},
                new LoaiLopHoc(){TenLoaiLopHoc="19CT112"},
                new LoaiLopHoc(){TenLoaiLopHoc="19CT113"},
                new LoaiLopHoc(){TenLoaiLopHoc="19CT114"},
                new LoaiLopHoc(){TenLoaiLopHoc="18CT111"},
                new LoaiLopHoc(){TenLoaiLopHoc="18CT112"},
                new LoaiLopHoc(){TenLoaiLopHoc="17CT111"},
                new LoaiLopHoc(){TenLoaiLopHoc="17CT112"},
            };



            //*
            //gan vao datasource cua comboBox
            cbx_Khoa.DataSource = loaiKhoa;
            //Thiet lap thuoc tinh
            cbx_Khoa.DisplayMember = "TenLoaiKhoa";
            cbx_Khoa.ValueMember = "TenLoaiKhoa";
            //*

            //*
            //gan vao datasource cua comboBox
            cbx_KhoaHoc.DataSource = loaiKhoaHoc;
            //Thiet lap thuoc tinh
            cbx_KhoaHoc.DisplayMember = "TenLoaiKhoaHoc";
            cbx_KhoaHoc.ValueMember = "TenLoaiKhoaHoc";
            //*

            //*
            //gan vao datasource cua comboBox
            cbx_LopHoc.DataSource = loaiLopHoc;
            //Thiet lap thuoc tinh
            cbx_LopHoc.DisplayMember = "TenLoaiLopHoc";
            cbx_LopHoc.ValueMember = "TenLoaiLopHoc";
            //*


        }
        private void cbxKhoaHoc()
        {


        }
        private void GetDataToDataGridView()
        {
            // Đọc file để lấy danh sách User theo đường dẫn file  được cung cấp
            lopDao.DocFileLop(Cls_Main.pathfileLopHoc);
            // bindingsoure dùng để tự động cập nhập list user mỗi khi nhấn update
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lopDao.listLop;
            // Gán danh sách user vào thuộc tính DataSource của DataGridView
            dgv_DSLopHoc.DataSource = bindingSource;
            // lblQuality.Text đếm số lượng user trong dgvUserlist
            //lblQuality.Text = dgvUserlist.RowCount.ToString();
        }

        private string CreateMaxID()
        {
            string maxID = string.Empty;
            maxID = lopDao.GetMaxID().ToString();
            return maxID;
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MSSV.Text))//Kiểm tra phải nhập fullname
            {
                if (!string.IsNullOrEmpty(txt_TenSV.Text))//Kiểm tra phải nhập UserName 
                {
                    if (cbx_Khoa.SelectedIndex > -1)//Kiểm tra phải nhập Password
                    {
                        if (!string.IsNullOrEmpty(txt_GVCN.Text))
                        {
                            if (cbx_KhoaHoc.SelectedIndex > -1)//Kiểm tra phải chọn UserType
                            {
                                if (cbx_LopHoc.SelectedIndex > -1)
                                {
                                    //Khởi tạo User Và lấy dữ liệu từ Control,
                                    lop = new Lop()
                                    {
                                        STT = Convert.ToInt32(txt_STT.Text),
                                        MSSV = Convert.ToInt32(txt_MSSV.Text),
                                        TenSV = txt_TenSV.Text,
                                        Khoa = cbx_Khoa.SelectedValue.ToString(),
                                        GVCN = txt_GVCN.Text,
                                        KhoaHoc = (cbx_KhoaHoc.SelectedValue.ToString()),
                                        LopHoc = (cbx_LopHoc.SelectedValue.ToString()),

                                    };
                                    //gọi phương thức UpdateUser.
                                    if (ThemTK(ref err, lop))
                                    {
                                        MessageBox.Show("Add User SuccessFull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        GetDataToDataGridView();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Not Select userType", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Not Select userType", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Not Select userType", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Select Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Not Select UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not Select FullName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool ThemTK(ref string err, Lop lop)
        {
            try
            {

                lopDao.listLop.Add(lop);//Thêm user vào trong List<User> Của UserDao
                lopDao.GhiFileLop(Cls_Main.pathfileLopHoc);//Ghi listUser vào trong file listUser.ini
                return true;//Trả vể true khi thực hiện thành công.

                //else
                //{
                //    foreach (TaiKhoanMatKhau item in taiKhoanMatKhauDao.listTKMK)//Lập trên danh sách User, để tìm User cần sửa
                //    {
                //        if (item.ID == taiKhoanMatKhau.ID)//Kiểm tra User cấn sửa
                //        {
                //            //Sửa thông tin user trên listUser.
                //            item.HoTen = taiKhoanMatKhau.HoTen;
                //            item.TaiKhoan = taiKhoanMatKhau.TaiKhoan;
                //            item.MatKhau = taiKhoanMatKhau.MatKhau;
                //            item.GioiTinh = taiKhoanMatKhau.GioiTinh;
                //            item.NhoMatKhau = taiKhoanMatKhau.NhoMatKhau;
                //            item.ChucVu = taiKhoanMatKhau.ChucVu;
                //        }
                //    }
                //    //Ghi nội dung trên danh sách ListUser trong UserDao vào file listUser.ini
                //    taiKhoanMatKhauDao.DocFile(Cls_Main.pathfile);
                //    return true;
                //}
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            txt_STT.Text = CreateMaxID();
            txt_TenSV.Text = "";
            txt_MSSV.Text = "";
            txt_GVCN.Text = "";
            GetDataToDataGridView();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lop != null)
            {
                foreach (Lop item in lopDao.listLop)
                {
                    if (item.STT == lop.STT)
                    {
                        lopDao.listLop.Remove(item);
                        return;
                    }
                }
                lopDao.GhiFileLop(Cls_Main.pathfileLopHoc);
                lop = null;
                GetDataToDataGridView();
            }
        }

        private void dgv_DSLopHoc_Click(object sender, EventArgs e)
        {
            if (dgv_DSLopHoc.RowCount > 0)//Kiểm tra dataGridView có dữ liệu hay không
            {

                lop = new Lop()
                {
                    STT = Convert.ToInt32(dgv_DSLopHoc.CurrentRow.Cells["col_STT"].Value.ToString()),
                    MSSV = Convert.ToInt32(dgv_DSLopHoc.CurrentRow.Cells["col_MSSV"].Value.ToString()),
                    TenSV = dgv_DSLopHoc.CurrentRow.Cells["col_TenSV"].Value.ToString(),
                    Khoa = dgv_DSLopHoc.CurrentRow.Cells["col_Khoa"].Value.ToString(),
                    GVCN = dgv_DSLopHoc.CurrentRow.Cells["col_GVCN"].Value.ToString(),
                    KhoaHoc = dgv_DSLopHoc.CurrentRow.Cells["col_KhoaHoc"].Value.ToString(),
                    LopHoc = dgv_DSLopHoc.CurrentRow.Cells["col_LopHoc"].Value.ToString(),
                };

                txt_STT.Text = dgv_DSLopHoc.CurrentRow.Cells["col_STT"].Value.ToString();
                txt_MSSV.Text = dgv_DSLopHoc.CurrentRow.Cells["col_MSSV"].Value.ToString();
                txt_TenSV.Text = dgv_DSLopHoc.CurrentRow.Cells["col_TenSV"].Value.ToString();
                cbx_Khoa.SelectedValue = dgv_DSLopHoc.CurrentRow.Cells["col_Khoa"].Value.ToString();
                txt_GVCN.Text = dgv_DSLopHoc.CurrentRow.Cells["col_GVCN"].Value.ToString();
                cbx_KhoaHoc.SelectedValue = dgv_DSLopHoc.CurrentRow.Cells["col_KhoaHoc"].Value.ToString();
                cbx_LopHoc.SelectedValue = dgv_DSLopHoc.CurrentRow.Cells["col_LopHoc"].Value.ToString();

                
            }
        }
    }
}
