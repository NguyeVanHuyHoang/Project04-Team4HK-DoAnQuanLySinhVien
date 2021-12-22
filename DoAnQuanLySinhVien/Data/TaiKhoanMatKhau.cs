using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.Data
{
    public class TaiKhoanMatKhau : IComparable
    {
        // field - Những thuộc tính cần lưu trữ của User 
        private int iD;
        private string hoTen;
        private bool gioiTinh;//true: nam; false: nu
        private string taiKhoan;
        private string matKhau;
        private bool nhoMatKhau;
        private int chucVu;
        //Contructor- hàm tạo cho đối tượng User 
        public TaiKhoanMatKhau() { }
        public TaiKhoanMatKhau(int iD, string userName, string passWord, bool remeber)
        {
            this.iD = iD;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.NhoMatKhau = NhoMatKhau;
            this.ChucVu = ChucVu;   
        }
        // Properties - Tạo thuộc tính cho User theo snipet: RClick vào
        // field tương ứng --> Chọn Quick Action &... (Ctrl +)--> Encapsulate Field...
        public int ID { get { return iD; } set { iD = value; } }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool NhoMatKhau { get => nhoMatKhau; set => nhoMatKhau = value; }
       
        public int ChucVu { get => chucVu; set => chucVu = value; }





        //Phương thức Lấy chuỗi định dạng của đối tượng User 
        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, TaiKhoan, MatKhau, NhoMatKhau.ToString(), ChucVu);
        }
        /// <summary>
        /// Phương thức nạp chồng giúp so sánh 2 đối tượng user nếu bằng nhau ==> true.
        /// Có thể quy định user bằng nhau theo thuộc tính nào là do người dụng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is TaiKhoanMatKhau)
            {
                return this.ID.Equals(((TaiKhoanMatKhau)obj).ID);
            }
            return false;
        }
        /// <summary>
        /// Phương thức được thực thi từ interface Icomparable 
        /// nếu muốn sắp xếp danh sách.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return this.ID.CompareTo(((TaiKhoanMatKhau)obj).ID);
        }
    }
}
