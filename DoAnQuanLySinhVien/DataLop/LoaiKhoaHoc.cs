using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataLop
{
    class LoaiKhoaHoc
    {
        //Kiểu dữ liệu UserType
        private int iDLoaiKhoaHoc;//ctrl+R+E--> Enter
        private string tenLoaiKhoaHoc;

        public int IDLoaiKhoaHoc { get => iDLoaiKhoaHoc; set => iDLoaiKhoaHoc = value; }
        public string TenLoaiKhoaHoc { get => tenLoaiKhoaHoc; set => tenLoaiKhoaHoc = value; }
    }
}
