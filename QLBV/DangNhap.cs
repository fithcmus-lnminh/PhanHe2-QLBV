using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace QLBV
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == null)
            {
                MessageBox.Show("Vui lòng nhập Username");
                return;
            }

            if (txbPw.Text == null)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            string conString = "USER ID=" + txbUsername.Text + ";PASSWORD=" + txbPw.Text + ";DATA SOURCE=localhost:1521/OLS_THONGBAO";
            
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["con"].ConnectionString = conString;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Đăng nhập thành công!");
                Hide();
                string strSQL = "select GRANTED_ROLE from user_role_privs";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataReader dr;
                dr = oCmd.ExecuteReader();
                dr.Read();
                string role = dr["GRANTED_ROLE"].ToString();
                switch (role)
                {
                    case "R_THANHTRA":
                        ThanhTra_Main tt = new ThanhTra_Main();
                        Hide();
                        tt.ShowDialog();
                        Show();
                        break;

                    case "R_COSOYTE":
                        CSYT_Main csyt = new CSYT_Main();
                        Hide();
                        csyt.ShowDialog();
                        Show();
                        break;
                    case "R_YSI_BACSI":
                        YBS_Main ybs = new YBS_Main();
                        Hide();
                        ybs.ShowDialog();
                        Show();
                        break;
                    case "R_NGHIENCUU":
                        NC_Main nc = new NC_Main();
                        Hide();
                        nc.ShowDialog();
                        Show();
                        break;
                    case "R_BENHNHAN":
                        BN_Main bn = new BN_Main();
                        Hide();
                        bn.ShowDialog();
                        Show();
                        break;
                    case "R_GDS":
                        GDS_Main gds = new GDS_Main();
                        Hide();
                        gds.ShowDialog();
                        Show();
                        break;
                    case "R_GDCSYT":
                        GDCSYT_Main gdc = new GDCSYT_Main();
                        Hide();
                        gdc.ShowDialog();
                        Show();
                        break;
                    case "R_YBS":
                        YBACSI_Main ybsi = new YBACSI_Main();
                        Hide();
                        ybsi.ShowDialog();
                        Show();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
