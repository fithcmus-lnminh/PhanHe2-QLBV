using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class BN_TTCN : Form
    {
        public BN_TTCN()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BN_Main bnmain = new BN_Main();
            Hide();
            bnmain.ShowDialog();
        }

        private void btnSuaTTCN_Click(object sender, EventArgs e)
        {

        }
    }
}
