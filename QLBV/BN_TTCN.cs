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
    public partial class BN_TTCN : Form
    {
        public BN_TTCN()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BN_Main bnmain = new BN_Main();
            Hide();
            bnmain.ShowDialog();
        }

        private void btnSuaTTCN_Click(object sender, EventArgs e)
        {
            txtTenBN.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            txtCMND.ReadOnly = false;
            txtTinhTP.ReadOnly = false;
            txtCSYT.ReadOnly = false;
            txtSoNha.ReadOnly = false;
            txtTenDuong.ReadOnly = false;
            txtQH.ReadOnly = false;
            txtDiUngThuoc.ReadOnly = false;
            txtTSB.ReadOnly = false;
            txtTSBGD.ReadOnly = false;
            btnSuaTTCN.Visible = false;
            btnHuySuaTTCN.Visible = true;
            btnSuaTTCNAcp.Visible = true;
        }

        private void btnHuySuaTTCN_Click(object sender, EventArgs e)
        {
            txtTenBN.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            txtCMND.ReadOnly = true;
            txtTinhTP.ReadOnly = true;
            txtCSYT.ReadOnly = true;
            txtSoNha.ReadOnly = true;
            txtTenDuong.ReadOnly = true;
            txtQH.ReadOnly = true;
            txtDiUngThuoc.ReadOnly = true;
            txtTSB.ReadOnly = true;
            txtTSBGD.ReadOnly = true;
            btnSuaTTCN.Visible = true;
            btnHuySuaTTCN.Visible = false;
            btnSuaTTCNAcp.Visible = false;
        }

        private void btnSuaTTCNAcp_Click(object sender, EventArgs e)
        {
            txtTenBN.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            txtCMND.ReadOnly = true;
            txtTinhTP.ReadOnly = true;
            txtCSYT.ReadOnly = true;
            txtSoNha.ReadOnly = true;
            txtTenDuong.ReadOnly = true;
            txtQH.ReadOnly = true;
            txtDiUngThuoc.ReadOnly = true;
            txtTSB.ReadOnly = true;
            txtTSBGD.ReadOnly = true;
            btnSuaTTCN.Visible = true;
            btnSuaTTCNAcp.Visible = false;
            btnHuySuaTTCN.Visible = false;
        }
    }
}
