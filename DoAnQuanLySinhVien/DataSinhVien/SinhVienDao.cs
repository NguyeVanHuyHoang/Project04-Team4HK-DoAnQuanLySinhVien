using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataSinhVien
{
    class SinhVienDao
    {
        public List<SinhVien> listSV = new List<SinhVien>();
        public SinhVienDao()
        {

            //listUser = new List<User>() 


            //     new User() { ID =
            //         1, UserName = "admin", PassWord = "admin", Remember = true ,IdUserType=1},// 1 là admin
            //     new User() { ID =
            //         2, UserName = "user", PassWord = "user", Remember = false ,IdUserType=2},//2 là User
            //     new User() { ID =
            //         3, UserName = "minhhung", PassWord = "123456789", Remember = true,IdUserType=2 },
            //};
        }
        // ghi file text
        public void GhiFileSV(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {


                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (SinhVien item in listSV)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", item.STT, item.MSSV, item.TenSV,item.GioiTinh, item.Lop, item.Khoa, item.NgaySinh, item.Gmail));
                    }
                }
            }
        }
        //  đọc file text

        public void DocFileSV(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;// emty là k có gì cả
                    SinhVien sinhVien;

                    listSV.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        // 1,admin,admin,True,1
                        //2,user,user,False,2
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] userArray = line.Split(',');
                            sinhVien = new SinhVien();
                            sinhVien.STT = Convert.ToInt32(userArray[0]);
                            sinhVien.MSSV = Convert.ToInt32(userArray[1]);
                            sinhVien.TenSV = userArray[2];
                            sinhVien.GioiTinh = Convert.ToBoolean(userArray[3]);
                            sinhVien.Lop = userArray[4];
                            sinhVien.Khoa = userArray[5];
                            sinhVien.NgaySinh = userArray[6];
                            sinhVien.Gmail = userArray[7];
                            listSV.Add(sinhVien);
                        }

                    }
                }
            }
        }

        //viet phuong thuc lay MaxID ListUser
        public int GetMaxID()
        {
            int maxID = 0;
            foreach (SinhVien item in listSV)
            {
                if (item.STT > maxID)
                    maxID = item.STT;
            }
            return maxID + 1;
        }
    }
}
