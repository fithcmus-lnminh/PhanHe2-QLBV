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
    public partial class NV_TTCN : Form
    {
        public NV_TTCN()
        {
            InitializeComponent();
        }

        private void btnSuaTTCNNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = false;
            dtpNgaySinhNV.Enabled = true;
            txtPhaiNV.ReadOnly = false;
            txtCMNDNV.ReadOnly = false;
            txtQueQuanNV.ReadOnly = false;
            txtSDTNV.ReadOnly = false;
            txtCSYTNV.ReadOnly = false;
            txtVaiTroNV.ReadOnly = false;
            txtChuyenKhoaNV.ReadOnly = false;
            btnSuaTTCNNV.Visible = false;
            btnHuySuaTTCNNV.Visible = true;
            btnSuaTTCNAcpNV.Visible = true;
        }

        private void btnHuySuaTTCNNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = true;
            dtpNgaySinhNV.Enabled = false;
            txtPhaiNV.ReadOnly = true;
            txtCMNDNV.ReadOnly = true;
            txtQueQuanNV.ReadOnly = true;
            txtSDTNV.ReadOnly = true;
            txtCSYTNV.ReadOnly = true;
            txtVaiTroNV.ReadOnly = true;
            txtChuyenKhoaNV.ReadOnly = true;
            btnSuaTTCNNV.Visible = true;
            btnHuySuaTTCNNV.Visible = false;
            btnSuaTTCNAcpNV.Visible = false;
        }

        private void btnSuaTTCNAcpNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = true;
            dtpNgaySinhNV.Enabled = false;
            txtPhaiNV.ReadOnly = true;
            txtCMNDNV.ReadOnly = true;
            txtQueQuanNV.ReadOnly = true;
            txtSDTNV.ReadOnly = true;
            txtCSYTNV.ReadOnly = true;
            txtVaiTroNV.ReadOnly = true;
            txtChuyenKhoaNV.ReadOnly = true;
            btnSuaTTCNNV.Visible = true;
            btnHuySuaTTCNNV.Visible = false;
            btnSuaTTCNAcpNV.Visible = false;
        }
    }
}
