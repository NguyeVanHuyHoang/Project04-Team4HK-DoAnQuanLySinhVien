using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLySinhVien.Data;


namespace DoAnQuanLySinhVien
{
    public class Cls_Main
    {
        //Biến lưu User sau khi đăng nhập thành công
        public static TaiKhoanMatKhau _staticTKMK = new TaiKhoanMatKhau();
        //Đối đượng danh sách User danh sách này được khởi tạo khi mở chương trình. giá trị được đọc từ file text.
        public static List<TaiKhoanMatKhau> _listTKMK = new TaiKhoanMatKhauDao().listTKMK;
        //Biến lưu đường dẫn file listUser.ini trong thư mục cài đặt của project
        //Biến lưu đường dẫn file listUser.ini trong thư mục cài đặt của project
        public static string pathfile = string.Format(@"{0}\list_TKMK.ini", Application.StartupPath);
        
    }
}
