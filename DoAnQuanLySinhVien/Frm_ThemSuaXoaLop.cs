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
            DuLieu_CBX_Lop();
            HienThi_Lop();

            txt_STT.Text = CreateMaxID();
        }
        private void DuLieu_CBX_Lop()
        {
            //Tạo dữ liệu danh sách UserType.

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

            List<LoaiGVCN> loaiGVCN = new List<LoaiGVCN>()
            {
                new LoaiGVCN(){TenGVCN="Nguyễn Minh Phúc"},
                new LoaiGVCN(){TenGVCN="Văn Đình Vỹ Phương"},
                new LoaiGVCN(){TenGVCN="Nguyễn Duy Quang"},
                new LoaiGVCN(){TenGVCN="Phạm Công Xuyên"},
            };

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

            //*
            //gan vao datasource cua comboBox
            cbx_GVCN.DataSource = loaiGVCN;
            //Thiet lap thuoc tinh
            cbx_GVCN.DisplayMember = "TenGVCN";
            cbx_GVCN.ValueMember = "TenGVCN";
            //*
        }
        private void cbxKhoaHoc()
        {


        }
        private void HienThi_Lop()
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
            if (cbx_KhoaHoc.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(txt_Khoa.Text))//Kiểm tra phải nhập Password
                {
                    if (cbx_LopHoc.SelectedIndex > -1)
                    {
                        if (cbx_GVCN.SelectedIndex > -1)
                        {
                            //Khởi tạo User Và lấy dữ liệu từ Control,
                            lop = new Lop()
                            {
                                STT = Convert.ToInt32(txt_STT.Text),
                                KhoaHoc = (cbx_KhoaHoc.SelectedValue.ToString()),
                                Khoa = txt_Khoa.Text,
                                LopHoc = (cbx_LopHoc.SelectedValue.ToString()),
                                GVCN = cbx_GVCN.SelectedValue.ToString(),

                            };
                            //gọi phương thức UpdateUser.
                            if (ThemTK(ref err, lop))
                            {
                                MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HienThi_Lop();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn giáo viên chủ nhiệm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn lớp học", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Not Select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập khoá học", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private bool ThemTK(ref string err, Lop lop)
        {
            try
            {

                lopDao.listLop.Add(lop);//Thêm user vào trong List<User> Của UserDao
                lopDao.GhiFileLop(Cls_Main.pathfileLopHoc);//Ghi listUser vào trong file listUser.ini
                return true;//Trả vể true khi thực hiện thành công.
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
            HienThi_Lop();
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
                HienThi_Lop();
            }
        }

        private void dgv_DSLopHoc_Click(object sender, EventArgs e)
        {
            if (dgv_DSLopHoc.RowCount > 0)//Kiểm tra dataGridView có dữ liệu hay không
            {

                lop = new Lop()
                {
                    STT = Convert.ToInt32(dgv_DSLopHoc.CurrentRow.Cells["col_STT"].Value.ToString()),
                    KhoaHoc = dgv_DSLopHoc.CurrentRow.Cells["col_KhoaHoc"].Value.ToString(),
                    Khoa = dgv_DSLopHoc.CurrentRow.Cells["col_Khoa"].Value.ToString(),
                    LopHoc = dgv_DSLopHoc.CurrentRow.Cells["col_LopHoc"].Value.ToString(),
                    GVCN = dgv_DSLopHoc.CurrentRow.Cells["col_GVCN"].Value.ToString(),

                };

                txt_STT.Text = dgv_DSLopHoc.CurrentRow.Cells["col_STT"].Value.ToString();
                cbx_KhoaHoc.SelectedValue = dgv_DSLopHoc.CurrentRow.Cells["col_KhoaHoc"].Value.ToString();
                txt_Khoa.Text = dgv_DSLopHoc.CurrentRow.Cells["col_Khoa"].Value.ToString();
                cbx_LopHoc.SelectedValue = dgv_DSLopHoc.CurrentRow.Cells["col_LopHoc"].Value.ToString();
                cbx_GVCN.SelectedValue = dgv_DSLopHoc.CurrentRow.Cells["col_GVCN"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (cbx_KhoaHoc.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(txt_Khoa.Text))//Kiểm tra phải nhập Password
                {
                    if (cbx_LopHoc.SelectedIndex > -1)
                    {
                        if (cbx_GVCN.SelectedIndex > -1)
                        {
                            //Khởi tạo User Và lấy dữ liệu từ Control,
                            lop = new Lop()
                            {
                                STT = Convert.ToInt32(txt_STT.Text),
                                KhoaHoc = (cbx_KhoaHoc.SelectedValue.ToString()),
                                Khoa = txt_Khoa.Text,
                                LopHoc = (cbx_LopHoc.SelectedValue.ToString()),
                                GVCN = cbx_GVCN.SelectedValue.ToString(),

                            };
                            //gọi phương thức UpdateUser.
                            if (SuaTK(ref err, lop))
                            {
                                MessageBox.Show("Sữa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HienThi_Lop();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn giáo viên chủ nhiệm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn lớp học", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Not Select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập khoá học", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SuaTK(ref string err, Lop lop)
        {
            try
            {
                foreach (Lop item in lopDao.listLop)
                {
                    if (item.STT == lop.STT)
                    {
                        //taiKhoanMatKhauDao.listTKMK.Remove(taiKhoanMatKhau);
                        item.LopHoc = lop.LopHoc;
                        item.KhoaHoc = lop.KhoaHoc;
                        item.Khoa = lop.Khoa;
                        item.GVCN = lop.GVCN;
                    }
                }
                //taiKhoanMatKhauDao.listTKMK.Add(taiKhoanMatKhau);//Thêm user vào trong List<User> Của UserDao
                lopDao.GhiFileLop(Cls_Main.pathfileLopHoc);//Ghi listUser vào trong file listUser.ini
                return true;//Trả vể true khi thực hiện thành công.


            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }
    }
}
