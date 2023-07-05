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

        private void btn_testoop_Click(object sender, EventArgs e)
        {
            //parent_class pc=new parent_class();
            //pc.Jade="ruby";
            //MessageBox.Show(pc.Jade);
            //child_class cc = new child_class();
            //cc.Jade = "diamond"; ;
            //MessageBox.Show(cc.Jade);

            //grand_child_class gcc =new grand_child_class();
            //gcc.Jade = "ruby" ;

            //MessageBox.Show(gcc.Jade);

            //parent_class pc;
            //pc = new parent_class();
            //pc =new child_class();
            //pc.person();
            parent_class pc;

            pc =new child_class();
            
            pc.person();
          
        }
    }
}
