using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.Data
{
    internal class LoaiTaiKhoan
    {
        //Kiểu dữ liệu UserType
        private int iDLoaiTaiKhoan;//ctrl+R+E--> Enter
        private string tenLoaiTaiKhoan;

        public int IDLoaiTaiKhoan { get => iDLoaiTaiKhoan; set => iDLoaiTaiKhoan = value; }
        public string TenLoaiTaiKhoan { get => tenLoaiTaiKhoan; set => tenLoaiTaiKhoan = value; }
    }
}
