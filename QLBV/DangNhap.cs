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
            //CSYT_Main bn = new CSYT_Main();
            //BN_Main bn = new BN_Main();
            //ThanhTra_Main bn = new ThanhTra_Main();
            //YBS_Main bn = new YBS_Main();
            NC_Main bn = new NC_Main();
            Hide();
            bn.ShowDialog();
            Show();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
