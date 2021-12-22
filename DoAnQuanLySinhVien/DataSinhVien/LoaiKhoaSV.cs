using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataSinhVien
{
    internal class LoaiKhoaSV
    {
        private int iDLoaiKhoaSV;//ctrl+R+E--> Enter
        private string tenLoaiKhoaSV;

        public int IDLoaiKhoaSV { get => iDLoaiKhoaSV; set => iDLoaiKhoaSV = value; }
        public string TenLoaiKhoaSV { get => tenLoaiKhoaSV; set => tenLoaiKhoaSV = value; }
    }
}
