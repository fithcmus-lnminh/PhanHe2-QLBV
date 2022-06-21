using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace QLBV
{
    public partial class CSYT_HSBA : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public CSYT_HSBA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CSYT_HSBA_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLCSYT.V_CSYT_HSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt;
            dr.Close();

            txtMaCSYT.Text = dt.Rows[0][6].ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QLCSYT.V_CSYT_HSBA WHERE MAHSBA LIKE '%" + txtTimHSBA.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt;
            txtTimHSBA.Text = "";
        }

        private void updateDSHSBA()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLCSYT.V_CSYT_HSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dgDSHSBA.DataSource = dt;
        }

        private void btnThemHSBA_Click(object sender, EventArgs e)
        {
            if (txtMaHSBA.Text == "" || txtMaBN.Text == "" || txtMaCSYT.Text == "" || txtMaBS.Text == "" || txtMaKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết");
                return;
            }


            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO QLCSYT.V_CSYT_HSBA(MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) VALUES ('"
                + txtMaHSBA.Text.ToString() + "', '" + txtMaBN.Text.ToString() + "', TO_DATE('" + dtpNgayHSBA.Value.ToShortDateString() + "','mm/dd/yyyy'),'"
                + txtChanDoan.Text.ToString() + "', '" + txtMaBS.Text.ToString() + "', '" + txtMaKhoa.Text.ToString() + "', '" + txtMaCSYT.Text.ToString()
                + "', '" + txtKetLuan.Text.ToString() + "')";
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm HSBA thành công!");
                txtMaHSBA.Text = "";
                txtMaBN.Text = "";
                txtChanDoan.Text = "";
                txtMaBS.Text = "";
                txtMaKhoa.Text = "";
                txtKetLuan.Text = "";
                updateDSHSBA();
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); return; }
            
        }

        private void btnXoaHSBA_Click(object sender, EventArgs e)
        {
            OracleCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "DELETE FROM QLCSYT.V_HSBA_DVHSBA WHERE MAHSBA = '" + txtMaHSBAXoa.Text.ToString() + "'";
            cmd1.CommandType = CommandType.Text;


            OracleCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "DELETE FROM QLCSYT.V_CSYT_HSBA WHERE MAHSBA = '" + txtMaHSBAXoa.Text.ToString() + "'";
            cmd2.CommandType = CommandType.Text;

            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Xóa HSBA thành công!");
                txtMaHSBAXoa.Text = "";
                updateDSHSBA();
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
    }
}
