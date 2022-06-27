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
    public partial class YBS_TTBN : Form
    {
        public YBS_TTBN()
        {
            InitializeComponent();
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            string maBNInput = txtMaBN.Text;

            if (maBNInput.Length == 0)
            {
                MessageBox.Show("Mã bệnh nhân phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    dgDSBN.Rows.Clear();

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = conString;
                    con.Open();

                    string strSQL = "SELECT* FROM QLCSYT.BENHNHAN WHERE MABN LIKE '"
                        + maBNInput + "'";
                    OracleCommand oCmd = new OracleCommand(strSQL, con);
                    var reader = oCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dgDSBN.Rows[0].Clone();
                            row.Cells[0].Value = reader["MABN"].ToString();
                            row.Cells[1].Value = reader["MACSYT"].ToString();
                            row.Cells[2].Value = reader["TENBN"].ToString();
                            row.Cells[3].Value = reader["CMND"].ToString();
                            row.Cells[4].Value = reader["NGAYSINH"].ToString();
                            row.Cells[5].Value = reader["SONHA"].ToString();
                            row.Cells[6].Value = reader["TENDUONG"].ToString();
                            row.Cells[7].Value = reader["QUANHUYEN"].ToString();
                            row.Cells[8].Value = reader["TINHTP"].ToString();
                            row.Cells[9].Value = reader["TIENSUBENH"].ToString();
                            row.Cells[10].Value = reader["TIENSUBENHGD"].ToString();
                            row.Cells[11].Value = reader["DIUNGTHUOC"].ToString();

                            dgDSBN.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin bệnh nhân", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                    MessageBox.Show("Không thể tìm thấy thông tin bệnh nhân do lỗi bên hệ thống", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            string CMNDInput = txtCMND.Text;

            if (CMNDInput.Length == 0)
            {
                MessageBox.Show("CMND phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    dgDSBN.Rows.Clear();

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = conString;
                    con.Open();

                    string strSQL = "SELECT * FROM QLCSYT.BENHNHAN WHERE CMND LIKE '"
                        + CMNDInput + "'";
                    OracleCommand oCmd = new OracleCommand(strSQL, con);
                    var reader = oCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dgDSBN.Rows[0].Clone();
                            row.Cells[0].Value = reader["MABN"].ToString();
                            row.Cells[1].Value = reader["MACSYT"].ToString();
                            row.Cells[2].Value = reader["TENBN"].ToString();
                            row.Cells[3].Value = reader["CMND"].ToString();
                            row.Cells[4].Value = reader["NGAYSINH"].ToString();
                            row.Cells[5].Value = reader["SONHA"].ToString();
                            row.Cells[6].Value = reader["TENDUONG"].ToString();
                            row.Cells[7].Value = reader["QUANHUYEN"].ToString();
                            row.Cells[8].Value = reader["TINHTP"].ToString();
                            row.Cells[9].Value = reader["TIENSUBENH"].ToString();
                            row.Cells[10].Value = reader["TIENSUBENHGD"].ToString();
                            row.Cells[11].Value = reader["DIUNGTHUOC"].ToString();

                            dgDSBN.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin bệnh nhân", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                    MessageBox.Show("Không thể tìm thấy thông tin bệnh nhân do lỗi bên hệ thống", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void YBS_TTBN_Load(object sender, EventArgs e)
        {
            try
            {
                dgDSBN.Rows.Clear();

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                string strSQL = "SELECT * FROM QLCSYT.BENHNHAN";

                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)dgDSBN.Rows[0].Clone();
                        row.Cells[0].Value = reader["MABN"].ToString();
                        row.Cells[1].Value = reader["MACSYT"].ToString();
                        row.Cells[2].Value = reader["TENBN"].ToString();
                        row.Cells[3].Value = reader["CMND"].ToString();
                        row.Cells[4].Value = reader["NGAYSINH"].ToString();
                        row.Cells[5].Value = reader["SONHA"].ToString();
                        row.Cells[6].Value = reader["TENDUONG"].ToString();
                        row.Cells[7].Value = reader["QUANHUYEN"].ToString();
                        row.Cells[8].Value = reader["TINHTP"].ToString();
                        row.Cells[9].Value = reader["TIENSUBENH"].ToString();
                        row.Cells[10].Value = reader["TIENSUBENHGD"].ToString();
                        row.Cells[11].Value = reader["DIUNGTHUOC"].ToString();

                        dgDSBN.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin bệnh nhân", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Không thể tìm thấy thông tin bệnh nhân do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}