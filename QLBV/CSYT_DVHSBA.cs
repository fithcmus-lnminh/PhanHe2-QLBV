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

        private void updateDSDVHSBA()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLCSYT.V_HSBA_DVHSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dgDSHSBA_DV.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHSBADV.Text == "" || txtMaDV.Text == "" || txtMaKTV.Text == "") { 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết");
                return;
            }


            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO QLCSYT.V_HSBA_DVHSBA(MAHSBA, MADV, NGAY, MAKTV, KETQUA) VALUES ('"
                + txtMaHSBADV.Text.ToString() + "', '" + txtMaDV.Text.ToString() + "', TO_DATE('" + dtpNgay.Value.ToShortDateString()
                + "','mm/dd/yyyy'),'" + txtMaKTV.Text.ToString() + "', '" + txtKetQua.Text.ToString() + "')";
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 0) MessageBox.Show("Dữ liệu nhập vào không hợp lệ hoặc đã tồn tại.");
                    else
                {
                    MessageBox.Show("Thêm Dịch vu HSBA thành công!");
                    txtMaHSBADV.Text = "";
                    txtMaDV.Text = "";
                    txtMaKTV.Text = "";
                    txtKetQua.Text = "";
                    updateDSDVHSBA();
                }
                    
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); return; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDVXoa.Text == "" || txtMaHSBAXoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cần xóa");
                return;
            }

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM QLCSYT.V_HSBA_DVHSBA WHERE MAHSBA = '" + txtMaHSBAXoa.Text.ToString() + "' AND MADV ='" + txtMaDVXoa.Text.ToString() + "'";
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1) { MessageBox.Show("Xóa HSBA thành công!"); txtMaHSBAXoa.Text = "";
                    txtMaDVXoa.Text = "";
                    updateDSDVHSBA();
                } else
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ.");
                }
                
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
    }
}
