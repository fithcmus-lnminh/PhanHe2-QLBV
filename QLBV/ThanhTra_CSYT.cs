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
    public partial class ThanhTra_CSYT : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public ThanhTra_CSYT()
        {
            InitializeComponent();
        }

        private void ThanhTra_CSYT_Load(object sender, EventArgs e)
        {
            con.Open();
            string strSQL = "SELECT * FROM QLCSYT.CSYT";
            OracleCommand oCmd = new OracleCommand(strSQL, con);
            OracleDataReader oReader = oCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(oReader);
            dgvCSYT.DataSource = dt.DefaultView;
            con.Close();
        }

        private void btnTimCSYT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QLCSYT.CSYT WHERE MACSYT LIKE '%" + txbMaCSYT.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCSYT.DataSource = dt;
            txbMaCSYT.Text = "";
        }
    }
}
