﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class GDS_Main : Form
    {
        public GDS_Main()
        {
            InitializeComponent();
        }

        private void btnDVHSBA_Click(object sender, EventArgs e)
        {
            GDS_GDCSYT_YBS_XemTB xtb = new GDS_GDCSYT_YBS_XemTB();
            xtb.ShowDialog();
        }
    }
}
