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
using System.Text.RegularExpressions;

namespace QLBV
{
    public partial class NV_TTCN : Form
    {
        public NV_TTCN()
        {
            InitializeComponent();
        }

        // NHẤN VÀO NÚT "SỬA THÔNG TIN"
        private void btnSuaTTCNNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = false;
            dtpNgaySinhNV.Enabled = true;
            cbPhai.Enabled = true;
            txtCMNDNV.ReadOnly = false;
            txtQueQuanNV.ReadOnly = false;
            txtSDTNV.ReadOnly = false;
            cbCSYT.Enabled = true;
            cbVaiTro.Enabled = true;
            if (cbVaiTro.Text == "Y si / Bac si" || cbVaiTro.Text == "Nghien cuu") cbChuyenKhoa.Enabled = true;
            btnSuaTTCNNV.Visible = false;
            btnHuySuaTTCNNV.Visible = true;
            btnSuaTTCNAcpNV.Visible = true;
        }

        // NHẤN VÀO NÚT "HỦY" THÌ THỰC HIỆN
        private void btnHuySuaTTCNNV_Click(object sender, EventArgs e)
        {
            txtHoTenNV.ReadOnly = true;
            dtpNgaySinhNV.Enabled = false;
            cbPhai.Enabled = false;
            txtCMNDNV.ReadOnly = true;
            txtQueQuanNV.ReadOnly = true;
            txtSDTNV.ReadOnly = true;
            cbCSYT.Enabled = false;
            cbVaiTro.Enabled = false;
            cbChuyenKhoa.Enabled = false;
            btnSuaTTCNNV.Visible = true;
            btnHuySuaTTCNNV.Visible = false;
            btnSuaTTCNAcpNV.Visible = false;
            TTCN_Load();
        }

        // khi nhấn nút "sửa" thành công
        private void btnSuaTTCNAcpNV_Click(object sender, EventArgs e)
        {
            string maNVInput = txtMaNV.Text.Trim();
            string hoTenInput = txtHoTenNV.Text.Trim();
            string ngaySinhValueInput = dtpNgaySinhNV.Value.ToString("yyyy-MM-dd");
            string phaiInput = cbPhai.Text.Trim();
            string CMNDInput = txtCMNDNV.Text.Trim();
            string queQuanInput = txtQueQuanNV.Text.Trim();
            string SDTInput = txtSDTNV.Text.Trim();
            string CSYTInput = cbCSYT.Text.Trim();
            string vaiTroInput = cbVaiTro.Text.Trim();
            string chuyenKhoaInput = cbChuyenKhoa.Text.Trim();
            bool isValid = true;

            if (hoTenInput.Length < 4)
            {
                isValid = false;
                MessageBox.Show("Họ tên yêu cầu tối thiểu 4 kí tự", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (CMNDInput.Length < 9 || IsNumber(CMNDInput) == false)
            {
                isValid = false;
                MessageBox.Show("CMND yêu cầu tối thiểu 9 kí tự số", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (IsValidDate(ngaySinhValueInput) == false)
            {
                isValid = false;
                MessageBox.Show("Ngày sinh nhân viên yêu cầu từ 20 tuổi trở lên", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (queQuanInput.Length == 0)
            {
                isValid = false;
                MessageBox.Show("Quê quán phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (SDTInput.Length != 10 || IsNumber(SDTInput) == false)
            {
                isValid = false;
                MessageBox.Show("SDT yêu cầu nhập 10 kí tự số", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (isValid == true)
            {
                try
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = conString;
                    con.Open();

                    string strSQL = "Update QLCSYT.NHANVIEN SET HOTEN = N'" + hoTenInput +
                        "', NGAYSINH = TO_DATE('" + ngaySinhValueInput + "','yyyy-mm-dd')" +
                        ", PHAI = N'" + phaiInput +
                        "', CMND = '" + CMNDInput +
                        "', QUEQUAN = N'" + queQuanInput +
                        "', SODT = '" + SDTInput +
                        "', CSYT = '" + CSYTInput +
                        "', VAITRO = N'" + vaiTroInput +
                        "', CHUYENKHOA = '" + chuyenKhoaInput +
                        "' WHERE MANV LIKE '" + maNVInput + "'";

                    OracleCommand oCmd = new OracleCommand(strSQL, con);

                    // Thực thi lệnh.
                    oCmd.ExecuteNonQuery();


                    txtHoTenNV.ReadOnly = true;
                    dtpNgaySinhNV.Enabled = false;
                    cbPhai.Enabled = false;
                    txtCMNDNV.ReadOnly = true;
                    txtQueQuanNV.ReadOnly = true;
                    txtSDTNV.ReadOnly = true;
                    cbCSYT.Enabled = false;
                    cbVaiTro.Enabled = false;
                    cbChuyenKhoa.Enabled = false;
                    btnSuaTTCNNV.Visible = true;
                    btnHuySuaTTCNNV.Visible = false;
                    btnSuaTTCNAcpNV.Visible = false;

                    MessageBox.Show(maNVInput + " đã cập nhật thông tin cá nhân thành công", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                    MessageBox.Show("Không thể cập nhật thông tin cá nhân do lỗi bên hệ thống", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void cbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVaiTro.Text == "Y si / Bac si" || cbVaiTro.Text == "Nghien cuu")
            {
                cbChuyenKhoa.Enabled = true;
            }
            else cbChuyenKhoa.Enabled = false;
        }

        private void NV_TTCN_Load(object sender, EventArgs e)
        {
            TTCN_Load();
            cbChuyenKhoa.Enabled = false;
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public bool IsValidDate(string ngaySinh)
        {
            DateTime dt = DateTime.Parse(ngaySinh);
            DateTime dt_now = DateTime.Now;
            DateTime dt_valid = dt.AddYears(20); //here add years, not subtract

            if (dt_valid.Date >= dt_now.Date) //here you want to compare dt_now
            {
                return false;
            }
            return true;
        }
        public void TTCN_Load()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                string strSQL = "SELECT * FROM QLCSYT.NHANVIEN";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMaNV.Text = reader["MANV"].ToString();
                    txtHoTenNV.Text = reader["HOTEN"].ToString();
                    cbPhai.Text = reader["PHAI"].ToString();
                    dtpNgaySinhNV.Text = reader["NGAYSINH"].ToString();
                    txtCMNDNV.Text = reader["CMND"].ToString();
                    txtQueQuanNV.Text = reader["QUEQUAN"].ToString();
                    txtSDTNV.Text = reader["SODT"].ToString();
                    cbCSYT.Text = reader["CSYT"].ToString();
                    cbVaiTro.Text = reader["VAITRO"].ToString();
                    cbChuyenKhoa.Text = reader["CHUYENKHOA"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Không thể tìm thấy thông tin cá nhân do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}