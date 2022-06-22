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
    public partial class NC_DVHSBA : Form
    {
        public NC_DVHSBA()
        {
            InitializeComponent();
        }

        private void NC_DVHSBA_Load(object sender, EventArgs e)
        {
            try
            {
                dgDSHSBA_DV.Rows.Clear();

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                string strSQL = "SELECT * FROM QLCSYT.NGHIENCUU_HSBA_DV";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgDSHSBA_DV.Rows[0].Clone();
                    row.Cells[0].Value = reader["MAHSBA"].ToString();
                    row.Cells[1].Value = reader["MADV"].ToString();
                    row.Cells[2].Value = reader["NGAY"].ToString();
                    row.Cells[3].Value = reader["MAKTV"].ToString();
                    row.Cells[4].Value = reader["KETQUA"].ToString();

                    dgDSHSBA_DV.Rows.Add(row);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Không thể tìm thấy dịch vụ hồ sơ bệnh án do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maHSBAInput = txtTimHSBA.Text;

            if (maHSBAInput.Length == 0)
            {
                MessageBox.Show("Mã hồ sơ bệnh án phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    dgDSHSBA_DV.Rows.Clear();

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = conString;
                    con.Open();

                    string strSQL = "SELECT * FROM QLCSYT.NGHIENCUU_HSBA_DV WHERE MAHSBA LIKE '"
                        + maHSBAInput + "'";
                    OracleCommand oCmd = new OracleCommand(strSQL, con);
                    var reader = oCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dgDSHSBA_DV.Rows[0].Clone();
                            row.Cells[0].Value = reader["MAHSBA"].ToString();
                            row.Cells[1].Value = reader["MADV"].ToString();
                            row.Cells[2].Value = reader["NGAY"].ToString();
                            row.Cells[3].Value = reader["MAKTV"].ToString();
                            row.Cells[4].Value = reader["KETQUA"].ToString();

                            dgDSHSBA_DV.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hồ sơ bệnh án", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
