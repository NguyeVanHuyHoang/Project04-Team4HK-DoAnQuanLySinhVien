﻿using System;
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
            LoadDataToComUserType();
            GetDataToDataGridView();

            txt_ID.Text = CreateMaxID();

            
        }

        private void GetDataToDataGridView()
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
        private void LoadDataToComUserType()
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
        private string CreateMaxID()
        {
            string maxID = string.Empty;
            maxID = taiKhoanMatKhauDao.GetMaxID().ToString();
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
                                ChucVu = Convert.ToInt32(cbx_ChucVu.SelectedValue.ToString())
                            };
                            //gọi phương thức UpdateUser.
                            if (ThemTK(ref err, taiKhoanMatKhau))
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
        private bool ThemTK(ref string err, TaiKhoanMatKhau taiKhoanMatKhau)
        {
            try
            {

                taiKhoanMatKhauDao.listTKMK.Add(taiKhoanMatKhau);//Thêm user vào trong List<User> Của UserDao
                taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);//Ghi listUser vào trong file listUser.ini
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

        private void dgv_DSTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_DSTaiKhoan.RowCount > 0)//Kiểm tra dataGridView có dữ liệu hay không
            {
                txt_ID.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_ID"].Value.ToString();
                txt_HoTen.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_HoVaTen"].Value.ToString();
                txt_TenTK.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_TenTaiKhoan"].Value.ToString();
                txt_MatKhau.Text = dgv_DSTaiKhoan.CurrentRow.Cells["col_MatKhau"].Value.ToString();
                ckb_NhoMK.Checked = Convert.ToBoolean(dgv_DSTaiKhoan.CurrentRow.Cells["col_NhoMatKhau"].Value.ToString());
                cbx_ChucVu.SelectedValue = Convert.ToInt32(dgv_DSTaiKhoan.CurrentRow.Cells["col_ChucVu"].Value.ToString());
                ;
            }
        }


        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            GetDataToDataGridView();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (taiKhoanMatKhau != null)
            {
                taiKhoanMatKhauDao.listTKMK.Remove(taiKhoanMatKhau);
                taiKhoanMatKhauDao.GhiFile(Cls_Main.pathfile);
                taiKhoanMatKhau = null;
                GetDataToDataGridView();
            }
        }

        
    }
}
