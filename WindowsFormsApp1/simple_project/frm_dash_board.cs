using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.simple_project
{
    public partial class frm_dash_board : Form
    {
        public frm_dash_board()
        {
            InitializeComponent();
        }

        private void frm_dash_board_Load(object sender, EventArgs e)
        {
            frm_customers_login fcl=new frm_customers_login();
            MessageBox.Show( fcl.profile_name);
        }
    }
}
