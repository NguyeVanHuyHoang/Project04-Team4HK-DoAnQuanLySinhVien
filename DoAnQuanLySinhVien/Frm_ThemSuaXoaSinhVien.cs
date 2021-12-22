using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLySinhVien.DataSinhVien;

namespace DoAnQuanLySinhVien
{
    public partial class Frm_ThemSuaXoaSinhVien : Form
    {
        
        public Frm_ThemSuaXoaSinhVien()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;

        SinhVien sinhVien;
        List<SinhVien> listSV = new List<SinhVien>();
        SinhVienDao sinhVienDao;

        string err = string.Empty;


        private void Frm_ThemSuaXoaSinhVien_Load(object sender, EventArgs e)
        {
            sinhVien = new SinhVien();
            sinhVienDao = new SinhVienDao();
            sinhVienDao.DocFileSV(Cls_Main.pathfileSV);
            DuLieu_CBX();//dữ liệu của 2 combobox cụ thể đây là khoa và Lớp
            HienThi_Data_SV();//Hiển thị lên datagridview
            txt_STT.Text = CreateMaxID();//STT tự động tăng dần 
        }

        private void DuLieu_CBX()
        {
            List<LoaiKhoaSV> loaiKhoaSV = new List<LoaiKhoaSV>()
            {
                new LoaiKhoaSV(){TenLoaiKhoaSV="CNTT"},
                new LoaiKhoaSV(){TenLoaiKhoaSV="QTKT-QT"},
                new LoaiKhoaSV(){TenLoaiKhoaSV="Cơ Điện"},
                new LoaiKhoaSV(){TenLoaiKhoaSV="NN Trung"},
                new LoaiKhoaSV(){TenLoaiKhoaSV="NN Hàn"},
                new LoaiKhoaSV(){TenLoaiKhoaSV="NN Nhật"},
                new LoaiKhoaSV(){TenLoaiKhoaSV="Dược"},
            };

            List<LoaiLop> loaiLop = new List<LoaiLop>()
            {
                new LoaiLop(){TenLoaiLop="20CT111"},
                new LoaiLop(){TenLoaiLop="20CT112"},
                new LoaiLop(){TenLoaiLop="20CT113"},
                new LoaiLop(){TenLoaiLop="20CT114"},
                new LoaiLop(){TenLoaiLop="19CT111"},
                new LoaiLop(){TenLoaiLop="19CT112"},
                new LoaiLop(){TenLoaiLop="19CT113"},
                new LoaiLop(){TenLoaiLop="19CT114"},
                new LoaiLop(){TenLoaiLop="18CT111"},
                new LoaiLop(){TenLoaiLop="18CT112"},
                new LoaiLop(){TenLoaiLop="17CT111"},
                new LoaiLop(){TenLoaiLop="17CT112"},
            };

            //gan vao datasource cua comboBox
            cbx_Khoa.DataSource = loaiKhoaSV;
            //Thiet lap thuoc tinh
            cbx_Khoa.DisplayMember = "TenLoaiKhoaSV";
            cbx_Khoa.ValueMember = "TenLoaiKhoaSV";


            //gan vao datasource cua comboBox
            cbx_Lop.DataSource = loaiLop;
            //Thiet lap thuoc tinh
            cbx_Lop.DisplayMember = "TenLoaiLop";
            cbx_Lop.ValueMember = "TenLoaiLop";
        }


        private void HienThi_Data_SV()
        {

            // Đọc file để lấy danh sách User theo đường dẫn file  được cung cấp
            sinhVienDao.DocFileSV(Cls_Main.pathfileSV);
            // bindingsoure dùng để tự động cập nhập list user mỗi khi nhấn update
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sinhVienDao.listSV;
            // Gán danh sách user vào thuộc tính DataSource của DataGridView
            dgv_DSSinhVien.DataSource = bindingSource;
            // lblQuality.Text đếm số lượng user trong dgvUserlist
            //lblQuality.Text = dgvUserlist.RowCount.ToString();
        }
        private string CreateMaxID()
        {
            string maxID = string.Empty;
            maxID = sinhVienDao.GetMaxID().ToString();
            return maxID;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_DSSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MSSV.Text))//Kiểm tra phải nhập fullname
            {
                if (!string.IsNullOrEmpty(txt_TenSV.Text))//Kiểm tra phải nhập UserName 
                {
                    if (cbx_Lop.SelectedIndex > -1)//Kiểm tra phải nhập Password
                    {
                        if (cbx_Khoa.SelectedIndex > -1)
                        {
                            if (!string.IsNullOrEmpty(date_NgaySinh.Text))//Kiểm tra phải chọn UserType
                            {
                                if (!string.IsNullOrEmpty(txt_Gmail.Text))
                                {
                                    //Khởi tạo User Và lấy dữ liệu từ Control,
                                    sinhVien = new SinhVien()
                                    {
                                        STT = Convert.ToInt32(txt_STT.Text),
                                        MSSV = Convert.ToInt32(txt_MSSV.Text),
                                        TenSV = txt_TenSV.Text,
                                        GioiTinh = rd_Nam.Checked,
                                        Lop = cbx_Lop.SelectedValue.ToString(),
                                        Khoa = cbx_Khoa.SelectedValue.ToString(),
                                        NgaySinh = date_NgaySinh.Value.Date.ToShortDateString(),
                                        Gmail = txt_Gmail.Text,
                                        

                                    };
                                    //gọi phương thức UpdateUser.
                                    if (ThemTK(ref err, sinhVien))
                                    {
                                        MessageBox.Show("Thêm thông tin sinh viên thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        HienThi_Data_SV();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Hãy nhập Gmail.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hãy chọn ngày tháng năm sinh", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn khoa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn lớp.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Hãy nhập họ tên sinh viên.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập mã số sinh viên.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ThemTK(ref string err, SinhVien sinhVien)
        {
            try
            {

                sinhVienDao.listSV.Add(sinhVien);//Thêm user vào trong List<User> Của UserDao

                sinhVienDao.GhiFileSV(Cls_Main.pathfileSV);//Ghi listUser vào trong file listUser.ini
                return true;//Trả vể true khi thực hiện thành công.


            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            txt_STT.Text = CreateMaxID();
            txt_TenSV.Text = "";
            txt_MSSV.Text = "";
            
            txt_Gmail.Text = "";
            HienThi_Data_SV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (sinhVien != null)
            {
                foreach (SinhVien item in sinhVienDao.listSV)
                {
                    if (item.STT == sinhVien.STT)
                    {
                        sinhVienDao.listSV.Remove(item);
                        return;
                    }
                }
                sinhVienDao.GhiFileSV (Cls_Main.pathfileSV);
                sinhVien = null;
                HienThi_Data_SV();
            }
        }

        private void dgv_DSSinhVien_Click(object sender, EventArgs e)
        {
            sinhVien = new SinhVien()
            {
                STT = Convert.ToInt32(dgv_DSSinhVien.CurrentRow.Cells["col_STT"].Value.ToString()),
                MSSV = Convert.ToInt32(dgv_DSSinhVien.CurrentRow.Cells["col_MSSV"].Value.ToString()),
                TenSV = dgv_DSSinhVien.CurrentRow.Cells["col_HoTen"].Value.ToString(),
                Lop = dgv_DSSinhVien.CurrentRow.Cells["col_Lop"].Value.ToString(),
                Khoa = dgv_DSSinhVien.CurrentRow.Cells["col_Khoa"].Value.ToString(),
                //NgaySinh = dgv_DSSinhVien.CurrentRow.Cells["col_NgaySinh"].Value.ToString(),
                Gmail = dgv_DSSinhVien.CurrentRow.Cells["col_Gmail"].Value.ToString(),
            };

            txt_STT.Text = dgv_DSSinhVien.CurrentRow.Cells["col_STT"].Value.ToString();
            txt_MSSV.Text = dgv_DSSinhVien.CurrentRow.Cells["col_MSSV"].Value.ToString();
            txt_TenSV.Text = dgv_DSSinhVien.CurrentRow.Cells["col_HoTen"].Value.ToString();
            cbx_Lop.SelectedValue = dgv_DSSinhVien.CurrentRow.Cells["col_Lop"].Value.ToString();
            cbx_Khoa.SelectedValue = dgv_DSSinhVien.CurrentRow.Cells["col_Khoa"].Value.ToString();
            //date_NgaySinh.Text = dgv_DSSinhVien.CurrentRow.Cells["col_NgaySinh"].Value.ToString();
            txt_Gmail.Text = dgv_DSSinhVien.CurrentRow.Cells["col_Gmail"].Value.ToString();

        }

       
    }
}
