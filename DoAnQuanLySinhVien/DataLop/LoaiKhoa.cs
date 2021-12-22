using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataLop
{
    class LoaiKhoa
    {
        private int iDLoaiKhoa;//ctrl+R+E--> Enter
        private string tenLoaiKhoa;

        public int IDLoaiKhoa { get => iDLoaiKhoa; set => iDLoaiKhoa = value; }
        public string TenLoaiKhoa { get => tenLoaiKhoa; set => tenLoaiKhoa = value; }
    }
}
