using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_homes : Form
    {
        public frm_homes()
        {
            InitializeComponent();
        }

        private void frm_homes_Load(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            frm_reset freset = new frm_reset();
            freset.ShowDialog();
        }
    }
}
