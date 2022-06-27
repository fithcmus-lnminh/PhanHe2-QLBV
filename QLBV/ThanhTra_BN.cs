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
    public partial class ThanhTra_BN : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public ThanhTra_BN()
        {
            InitializeComponent();
        }

        private void ThanhTra_BN_Load(object sender, EventArgs e)
        {
            con.Open();
            string strSQL = "SELECT * FROM QLCSYT.BENHNHAN";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(oReader);
            dgvTTBN.DataSource = dt.DefaultView;
            con.Close();
        }

        private void btnTimBN_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QLCSYT.BENHNHAN WHERE MABN LIKE '%" + tbxMaBN.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvTTBN.DataSource = dt;
            tbxMaBN.Text = "";
        }
    }
}
