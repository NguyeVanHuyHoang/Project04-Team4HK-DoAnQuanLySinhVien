using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLySinhVien
{
    public partial class Frm_ThemSuaXoaLop : Form
    {
        public Frm_ThemSuaXoaLop()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void Frm_ThemSuaXoaLop_Load(object sender, EventArgs e)
        {

        }
    }
}
