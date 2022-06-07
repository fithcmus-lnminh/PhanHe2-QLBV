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
    public partial class CSYT_Main : Form
    {
        public CSYT_Main()
        {
            InitializeComponent();
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

        private void btnTTBN_Click(object sender, EventArgs e)
        {
            CSYT_HSBA hsba = new CSYT_HSBA();
            Hide();
            hsba.ShowDialog();
            Show();
        }

        private void btnDVHSBA_Click(object sender, EventArgs e)
        {
            CSYT_DVHSBA dv = new CSYT_DVHSBA();
            Hide();
            dv.ShowDialog();
            Show();
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            NV_TTCN nv = new NV_TTCN();
            Hide();
            nv.ShowDialog();
            Show();
        }
    }
}
