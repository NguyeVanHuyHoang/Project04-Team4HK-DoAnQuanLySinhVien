using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.Data
{
    public class TaiKhoanMatKhauDao
    {
        //Khai báo  đối tượng List<User>
        public List<TaiKhoanMatKhau> listTKMK = new List<TaiKhoanMatKhau>();
        //Viết hàm tạo để khởi tạo đối tượng listUser.
        public TaiKhoanMatKhauDao()
        {
           
            
        }
        //Phương thức ghi danh sách listUser vào trong file text theo đương dẫn file Path
        public void GhiFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            //Sử dụng cấu trúc using để khai báo đối tượng FileStream
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                //Sử dung class StreamWriter để làm việc với file text (ini, txt)
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (TaiKhoanMatKhau item in listTKMK)
                    {
                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", item.ID, item.HoTen, item.GioiTinh.ToString(), item.TaiKhoan, item.MatKhau, item.NhoMatKhau.ToString(), item.ChucVu));
                    }
                }
            }

        }
        //Phuong thức đọc nội dung file text theo dường dẫn path và chứa trong listUser.

        public void DocFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                //Dùng Lớp StreamReader để đọc file theo đường dẫn được khai báo trong FileStream (phía trên).
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    TaiKhoanMatKhau tk;
                    listTKMK.Clear();
                    //Readline() phương thức đọc từng dòng trong file.
                    //Vòng Lặp while cho phép thực hiện việc này liên tục khi đọc đươc giá trì null
                    //Sau khi đọc xong 1 dòng, data sẽ được lưu vào trong biến line.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //1,admin,admin,True,1
                        //Kiểm tra line có giá trị hay không (null hoặc enmpty)
                        if (!string.IsNullOrEmpty(line))
                        {
                            //Dùng hàm Split('char') để tách chuỗi line thành mảng theo ký tự (char) ngăn cách
                            string[] userArray = line.Split(',');
                            //Tạo một đối tượng User và thêm giá trị từ mảng đọc được vào 
                            tk = new TaiKhoanMatKhau();
                            tk.ID = Convert.ToInt32(userArray[0]);
                            tk.HoTen = userArray[1];
                            tk.GioiTinh = Convert.ToBoolean(userArray[2]);
                            tk.TaiKhoan   = userArray[3];
                            tk.MatKhau = userArray[4];
                            tk.NhoMatKhau = Convert.ToBoolean(userArray[5].ToString());
                            tk.ChucVu = Convert.ToInt32(userArray[6]);
                            //Them User vào trong danh sách list_TKMK.
                            listTKMK.Add(tk);
                        }

                    }
                }
            }

        }

        //Viet phuong thuc lay MaxID cuar ListUser
        public int GetMaxID()
        {
            int maxID = 0;
            foreach (TaiKhoanMatKhau item in listTKMK)
            {
                if (item.ID > maxID)
                    maxID = item.ID;
            }
            return maxID + 1;
        }
        
    }
}
