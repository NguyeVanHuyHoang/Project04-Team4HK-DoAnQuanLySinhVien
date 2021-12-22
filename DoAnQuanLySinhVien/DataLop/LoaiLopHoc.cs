using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataLop
{
    class LoaiLopHoc
    {
        private int iDLoaiLopHoc;//ctrl+R+E--> Enter
        private string tenLoaiLopHoc;

        public int IDLoaiLopHoc { get => iDLoaiLopHoc; set => iDLoaiLopHoc = value; }
        public string TenLoaiLopHoc { get => tenLoaiLopHoc; set => tenLoaiLopHoc = value; }
    }
}
