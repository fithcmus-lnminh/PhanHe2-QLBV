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
    public partial class CSYT_DVHSBA : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public CSYT_DVHSBA()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CSYT_DVHSBA_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLCSYT.V_HSBA_DVHSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA_DV.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QLCSYT.V_HSBA_DVHSBA WHERE MAHSBA LIKE '%" + txtTimHSBA.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA_DV.DataSource = dt;
            txtTimHSBA.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
