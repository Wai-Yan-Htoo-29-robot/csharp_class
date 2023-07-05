using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.resume_project
{
    public partial class frm_cv : Form
    {
        public frm_cv()
        {
            InitializeComponent();
        }

        Connect connect = new Connect();
        MySqlCommand command;
        private void btn_upload_Click(object sender, EventArgs e)
        {
            command=new MySqlCommand();
            OpenFileDialog opf=new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                
                byte[] img= ms.ToArray();
                command = connect.conn.CreateCommand();
                command.CommandText = "insert into recruitment(resume_data) values('"+img+"')";

            }
            command.ExecuteNonQuery();
            connect.conn.Close();

        }

        private void btn_read_write_Click(object sender, EventArgs e)
        {
            string data;
            //data = txt_data_input.Text;
            //StreamWriter sw;
            ////                     file name  / filepath f
            //sw = new StreamWriter("kbtcstudentdata.txt");//create file
            //sw.WriteLine(data);
            //MessageBox.Show("file upload");
            //sw.Close();
            //File.AppendAllText("kbtcstudentdata.txt",data + "\n");
            StreamReader sr=new StreamReader("kbtcstudentdata.txt");
            data = sr.ReadToEnd();
            lbl_output.Text = data;
            sr.Close();

            MessageBox.Show("file upload");
        }
    }
}
