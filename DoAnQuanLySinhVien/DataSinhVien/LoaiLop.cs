using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySinhVien.DataSinhVien
{
    internal class LoaiLop
    {
        private int iDLoaiLop;//ctrl+R+E--> Enter
        private string tenLoaiLop;

        public int IDLoaiLop { get => iDLoaiLop; set => iDLoaiLop = value; }
        public string TenLoaiLop { get => tenLoaiLop; set => tenLoaiLop = value; }
    }
}
