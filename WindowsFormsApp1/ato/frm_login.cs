using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ato
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        public static string name, password;

        private void btn_login_Click(object sender, EventArgs e)
        {
            string staff1_name, staff2_name;
            string staff1_pwd, staff2_pwd;
            staff1_name = "nyi ye naing";
            staff1_pwd = "admin";

            name = txt_name.Text;
            password = txt_password.Text;
            if(staff1_name==name && staff1_pwd==password)
            {
                //frm_ato_shop fatosho=new frm_ato_shop();
                frm_admin_dashboard fad=new frm_admin_dashboard();
                this.Hide();
                fad.Show();
            }
        }
    }
}
