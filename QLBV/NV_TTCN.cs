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
            cbPhai.Enabled = true;
            txtCMNDNV.ReadOnly = false;
            txtQueQuanNV.ReadOnly = false;
            txtSDTNV.ReadOnly = false;
            cbCSYT.Enabled = true;
            cbVaiTro.Enabled = true;
            if (cbVaiTro.Text == "Y sĩ / Bác sĩ" || cbVaiTro.Text == "Nghiên cứu") cbChuyenKhoa.Enabled = true;
            btnSuaTTCNNV.Visible = false;
            btnHuySuaTTCNNV.Visible = true;
            btnSuaTTCNAcpNV.Visible = true;
        }

        private void btnHuySuaTTCNNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = true;
            dtpNgaySinhNV.Enabled = false;
            cbPhai.Enabled = false;
            txtCMNDNV.ReadOnly = true;
            txtQueQuanNV.ReadOnly = true;
            txtSDTNV.ReadOnly = true;
            cbCSYT.Enabled = false;
            cbVaiTro.Enabled = false;
            cbChuyenKhoa.Enabled = false;
            btnSuaTTCNNV.Visible = true;
            btnHuySuaTTCNNV.Visible = false;
            btnSuaTTCNAcpNV.Visible = false;
        }

        private void btnSuaTTCNAcpNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = true;
            dtpNgaySinhNV.Enabled = false;
            cbPhai.Enabled = false;
            txtCMNDNV.ReadOnly = true;
            txtQueQuanNV.ReadOnly = true;
            txtSDTNV.ReadOnly = true;
            cbCSYT.Enabled = false;
            cbVaiTro.Enabled = false;
            cbChuyenKhoa.Enabled = false;
            btnSuaTTCNNV.Visible = true;
            btnHuySuaTTCNNV.Visible = false;
            btnSuaTTCNAcpNV.Visible = false;
        }

        private void cbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVaiTro.Text == "Y sĩ / Bác sĩ" || cbVaiTro.Text == "Nghiên cứu")
            {
                cbChuyenKhoa.Enabled = true;
            }
            else cbChuyenKhoa.Enabled = false;
        }
    }
}
