using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataSinhVien
{
    public class SinhVien : IComparable
    {
        // field - Những thuộc tính cần lưu trữ của User 
        private int sTT;
        private int mSSV;
        private string hoTen;
        private bool gioiTinh;
        private string lop;
        private string khoa;
        private string ngaySinh;
        private string gmail;
        //Contructor- hàm tạo cho đối tượng User 

        public SinhVien() { }

        public SinhVien(int MSSV, string userName, string passWord, bool remeber)
        {
            this.STT = STT;
            this.MSSV = MSSV;
            this.TenSV = TenSV;
            this.Khoa = Khoa;
            this.Lop = Lop;
            this.NgaySinh = NgaySinh;
            this.Gmail = Gmail;
        }
        // Properties - Tạo thuộc tính cho User theo snipet: RClick vào
        // field tương ứng --> Chọn Quick Action &... (Ctrl +)--> Encapsulate Field...
        public int STT { get { return sTT; } set { sTT = value; } }
        public int MSSV { get => mSSV; set => mSSV = value; }
        public string TenSV { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public String Khoa { get => khoa; set => khoa = value; }
        public string Lop { get => lop; set => lop = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Gmail { get => gmail; set => gmail = value; }





        //Phương thức Lấy chuỗi định dạng của đối tượng User 
        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", STT, MSSV, TenSV, GioiTinh, Khoa, Lop, NgaySinh, Gmail);
        }
        /// <summary>
        /// Phương thức nạp chồng giúp so sánh 2 đối tượng user nếu bằng nhau ==> true.
        /// Có thể quy định user bằng nhau theo thuộc tính nào là do người dụng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is SinhVien)
            {
                return this.STT.Equals(((SinhVien)obj).STT);
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
            return this.STT.CompareTo(((SinhVien)obj).STT);
        }
    }
}
