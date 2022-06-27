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
    public partial class ThanhTra_NV : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public ThanhTra_NV()
        {
            InitializeComponent();
        }

        private void ThanhTra_NV_Load(object sender, EventArgs e)
        {
            con.Open();
            string strSQL = "SELECT * FROM QLCSYT.NHANVIEN";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(oReader);
            dgvHSNV.DataSource = dt.DefaultView;
            con.Close();
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QLCSYT.NHANVIEN WHERE MANV LIKE '%" + txbMaNV.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHSNV.DataSource = dt;
            txbMaNV.Text = "";
        }
    }
}
