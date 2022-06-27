using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;


namespace QLBV
{
    public partial class BN_TTCN : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

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
            cbCSYT.Enabled = true;
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
            cbCSYT.Enabled = false;
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
            cbCSYT.Enabled = false;
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

        private void BN_TTCN_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string strSQL = "SELECT * FROM QLCSYT.BENHNHAN";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                while (reader.Read())
                {
                    txbMaBN.Text = reader["MABN"].ToString();
                    txtTenBN.Text = reader["TENBN"].ToString();
                    txtCMND.Text = reader["CMND"].ToString();
                    dtpNgaySinh.Text = reader["NGAYSINH"].ToString();
                    cbCSYT.Text = reader["MACSYT"].ToString();
                    txtSoNha.Text = reader["SONHA"].ToString();
                    txtTenDuong.Text = reader["TENDUONG"].ToString();
                    txtQH.Text = reader["QUANHUYEN"].ToString();
                    txtTinhTP.Text = reader["TINHTP"].ToString();
                    txtTSB.Text = reader["TIENSUBENH"].ToString();
                    txtTSBGD.Text = reader["TIENSUBENHGD"].ToString();
                    txtDiUngThuoc.Text = reader["DIUNGTHUOC"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin cá nhân do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    
}
