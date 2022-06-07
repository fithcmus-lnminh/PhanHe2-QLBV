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
    public partial class ThanhTra_Main : Form
    {
        public ThanhTra_Main()
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

        private void btnHSBA_Click(object sender, EventArgs e)
        {
            ThanhTra_HSBA hsba = new ThanhTra_HSBA();
            Hide();
            hsba.ShowDialog();
            Show();
        }

        private void btnDVHSBA_Click(object sender, EventArgs e)
        {
            ThanhTra_DVHSBA dv = new ThanhTra_DVHSBA();
            Hide();
            dv.ShowDialog();
            Show();
        }

        private void btnTTBN_Click(object sender, EventArgs e)
        {
            ThanhTra_BN bn = new ThanhTra_BN();
            Hide();
            bn.ShowDialog();
            Show();
        }

        private void btnCSYT_Click(object sender, EventArgs e)
        {
            ThanhTra_CSYT csyt = new ThanhTra_CSYT();
            Hide();
            csyt.ShowDialog();
            Show();
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            ThanhTra_NV nv = new ThanhTra_NV();
            Hide();
            nv.ShowDialog();
            Show();
        }
    }
}
