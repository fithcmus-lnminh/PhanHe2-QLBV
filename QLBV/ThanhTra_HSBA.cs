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
    public partial class ThanhTra_HSBA : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public ThanhTra_HSBA()
        {
            InitializeComponent();
        }

        private void ThanhTra_HSBA_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string strSQL = "SELECT * FROM QLCSYT.HSBA";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataReader oReader = oCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oReader);
                dgvHSBA.DataSource = dt.DefaultView;
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Không đủ quyền truy cập");
            }
            
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QLCSYT.HSBA WHERE MAHSBA LIKE '%" + txtMaHSBA.Text + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHSBA.DataSource = dt;
            txtMaHSBA.Text = "";
        }
    }
}
