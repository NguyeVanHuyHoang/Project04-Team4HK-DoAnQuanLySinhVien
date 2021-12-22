using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataLop
{
    public class Lop : IComparable
    {
        // field - Những thuộc tính cần lưu trữ của User 
        private int sTT;
        private string khoa;
        private string gVCN;
        private string khoaHoc;
        private string lopHoc;
        //Contructor- hàm tạo cho đối tượng User 

        public Lop() { }
        public Lop(int MSSV, string userName, string passWord, bool remeber)
        {
            this.STT = STT;
            this.Khoa = Khoa;
            this.GVCN = GVCN;
            this.KhoaHoc = KhoaHoc;
            this.LopHoc = LopHoc;
        }
        // Properties - Tạo thuộc tính cho User theo snipet: RClick vào
        // field tương ứng --> Chọn Quick Action &... (Ctrl +)--> Encapsulate Field...
        public int STT { get { return sTT; } set { sTT = value; } }
        public String Khoa { get => khoa; set => khoa = value; }
        public string GVCN { get => gVCN; set => gVCN = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string LopHoc { get => lopHoc; set => lopHoc = value; }





        //Phương thức Lấy chuỗi định dạng của đối tượng User 
        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", STT, KhoaHoc, Khoa, LopHoc, GVCN);
        }
        /// <summary>
        /// Phương thức nạp chồng giúp so sánh 2 đối tượng user nếu bằng nhau ==> true.
        /// Có thể quy định user bằng nhau theo thuộc tính nào là do người dụng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Lop)
            {
                return this.STT.Equals(((Lop)obj).STT);
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
            return this.STT.CompareTo(((Lop)obj).STT);
        }
    }
}
