﻿using System;
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
    public partial class Frm_ThemSuaXoaSinhVien : Form
    {
        public Frm_ThemSuaXoaSinhVien()
        {
            InitializeComponent();
        }
        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void Frm_ThemSuaXoaSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}