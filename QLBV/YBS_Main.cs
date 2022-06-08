using System;
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
    public partial class YBS_Main : Form
    {
        public YBS_Main()
        {
            InitializeComponent();
        }

        private void btnHSBA_Click(object sender, EventArgs e)
        {
            YBS_HSBA_DVHSBA hs = new YBS_HSBA_DVHSBA();
            Hide();
            hs.ShowDialog();
            Show();
        }

        private void btnTTBN_Click(object sender, EventArgs e)
        {
            YBS_TTBN bn = new YBS_TTBN();
            Hide();
            bn.ShowDialog();
            Show();
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            NV_TTCN nv = new NV_TTCN();
            Hide();
            nv.ShowDialog();
            Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap formDn = new DangNhap();
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Hide();
                formDn.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
