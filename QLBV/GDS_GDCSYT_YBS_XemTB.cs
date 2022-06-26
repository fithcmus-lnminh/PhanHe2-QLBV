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

    public partial class GDS_GDCSYT_YBS_XemTB : Form
    {
     OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public GDS_GDCSYT_YBS_XemTB()
        {
            InitializeComponent();
            LoadTB();
        }
        public void LoadTB()
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT NGAYGIO, DIADIEM, GUIDEN, NOIDUNG FROM QLCSYT.THONGBAO";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgTB.DataSource = dt;
            dr.Close();
        }
    }
}
