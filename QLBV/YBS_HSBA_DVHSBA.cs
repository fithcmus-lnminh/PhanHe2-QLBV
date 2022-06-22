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
    public partial class YBS_HSBA_DVHSBA : Form
    {
        public YBS_HSBA_DVHSBA()
        {
            InitializeComponent();
        }

        private void YBS_HSBA_DVHSBA_Load(object sender, EventArgs e)
        {
            try
            {
                dgDSHSBA.Rows.Clear();

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                string strSQL = "SELECT * FROM QLCSYT.YBACSI_HSBA";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgDSHSBA.Rows[0].Clone();
                    row.Cells[0].Value = reader["MAHSBA"].ToString();
                    row.Cells[1].Value = reader["MABN"].ToString();
                    row.Cells[2].Value = reader["NGAY"].ToString();
                    row.Cells[3].Value = reader["CHANDOAN"].ToString();
                    row.Cells[4].Value = reader["MABN"].ToString();
                    row.Cells[5].Value = reader["MAKHOA"].ToString();
                    row.Cells[6].Value = reader["MACSYT"].ToString();
                    row.Cells[7].Value = reader["KETLUAN"].ToString();

                    dgDSHSBA.Rows.Add(row);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Không thể tìm thấy hồ sơ bệnh án do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTimHSBA_Click(object sender, EventArgs e)
        {
            string maHSBAInput = txtTimMaHSBA.Text;

            if (maHSBAInput.Length == 0)
            {
                MessageBox.Show("Mã hồ sơ bệnh án phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    dgvDSKQDVHSBA.Rows.Clear();

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = conString;
                    con.Open();

                    string strSQL = "SELECT * FROM QLCSYT.YBACSI_HSBA_DV WHERE MAHSBA LIKE '" 
                        + maHSBAInput + "'";
                    OracleCommand oCmd = new OracleCommand(strSQL, con);
                    var reader = oCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvDSKQDVHSBA.Rows[0].Clone();
                            row.Cells[0].Value = reader["MAHSBA"].ToString();
                            row.Cells[1].Value = reader["KETQUA"].ToString();

                            dgvDSKQDVHSBA.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả dịch vụ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                    MessageBox.Show("Không thể tìm thấy kết quả dịch vụ do lỗi bên hệ thống", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
