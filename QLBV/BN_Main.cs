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
    public partial class BN_Main : Form
    {
        public BN_Main()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap formDn = new DangNhap();
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                formDn.ShowDialog();
                Show();
            }
            else if (result == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnTTBN_Click(object sender, EventArgs e)
        {
            BN_TTCN ttcn = new BN_TTCN();
            Hide();
            ttcn.ShowDialog();
            Show();
        }
    }
}
