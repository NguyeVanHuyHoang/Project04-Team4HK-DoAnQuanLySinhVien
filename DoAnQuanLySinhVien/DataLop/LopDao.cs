using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataLop
{
    class LopDao
    {
        public List<Lop> listLop = new List<Lop>();
        public LopDao()
        {

            //listUser = new List<User>()
            //{
            //     new User() { ID =
            //         1, UserName = "admin", PassWord = "admin", Remember = true ,IdUserType=1},// 1 là admin
            //     new User() { ID =
            //         2, UserName = "user", PassWord = "user", Remember = false ,IdUserType=2},//2 là User
            //     new User() { ID =
            //         3, UserName = "minhhung", PassWord = "123456789", Remember = true,IdUserType=2 },
            //};
        }
        // ghi file text
        public void GhiFileLop(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {


                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Lop item in listLop)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", item.STT, item.MSSV, item.TenSV, item.Khoa, item.GVCN, item.KhoaHoc, item.LopHoc));
                    }
                }
            }
        }
        //  đọc file text

        public void DocFileLop(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;// emty là k có gì cả
                    Lop lop;
                    listLop.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        // 1,admin,admin,True,1
                        //2,user,user,False,2
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] userArray = line.Split(',');
                            lop = new Lop();
                            lop.STT = Convert.ToInt32(userArray[0]);
                            lop.MSSV = Convert.ToInt32(userArray[1]);
                            lop.TenSV = userArray[2];
                            lop.Khoa = userArray[3];
                            lop.GVCN = userArray[4];
                            lop.KhoaHoc = userArray[5];
                            lop.LopHoc = Convert.ToString(userArray[6]);
                            listLop.Add(lop);
                        }

                    }
                }
            }
        }

        //viet phuong thuc lay MaxID ListUser
        public int GetMaxID()
        {
            int maxID = 0;
            foreach (Lop item in listLop)
            {
                if (item.STT > maxID)
                    maxID = item.STT;
            }
            return maxID + 1;
        }
    }
}
