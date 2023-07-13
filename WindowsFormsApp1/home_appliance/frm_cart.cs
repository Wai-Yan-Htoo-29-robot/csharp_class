using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.home_appliance
{
    public partial class frm_cart : Form
    {
        public frm_cart()
        {
            InitializeComponent();
        }

        private void frm_cart_Load(object sender, EventArgs e)
        {
             string[] test_split =  frm_appliance_view.test.Split(',');
            int pic_loc = 0;
            int sub_total = 0;
            for(int i = 0; i < test_split.Length-1; i++)
            {
                if (test_split[i] == "lcdtv")
                {
                    var picture = new PictureBox
                    {
                        Name = "pic_lcdtv",
                        Size = new Size(90, 90),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10 + pic_loc),
                        Image = Image.FromFile("LCD TV.jpg"),

                    };
                    this.Controls.Add(picture);
                   
                }

                if (test_split[i] == "toshibatv")
                {
                    var picture = new PictureBox
                    {
                        Name = "pic_toshibatv",
                        Size = new Size(90, 90),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10 + pic_loc),
                        Image = Image.FromFile("toshibatv.jpg"),

                    };
                    this.Controls.Add(picture);
                }

                if (test_split[i] == "fridge_freezer")
                {
                    var picture = new PictureBox
                    {
                        Name = "pic_fridge_freezer",
                        Size = new Size(90, 90),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10 + pic_loc),
                        Image = Image.FromFile("fridge_freezer.jpg"),

                    };
                    this.Controls.Add(picture);
                }

                if (test_split[i] == "freezer1")
                {
                    var picture = new PictureBox
                    {
                        Name = "pic_freezer",
                        Size = new Size(90, 90),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10 + pic_loc),
                        Image = Image.FromFile("freezer1.jpg"),

                    };
                    this.Controls.Add(picture);
                }

                pic_loc += 100;
                sub_total = i+1;
            }
            lbl_sub_total.Text = $"Subtotal ({sub_total} items)";
        }
    }
}

//PictureBox test_picturebox = new PictureBox();
//this.Controls.Add(test_picturebox);
//test_picturebox.Location = new System.Drawing.Point(26, 10);
//test_picturebox.Name = "pic_test_pictureBox1".ToString();
//test_picturebox.BackColor = System.Drawing.Color.Red;
//test_picturebox.Size = new System.Drawing.Size(49, 29);
//test_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//test_picturebox.TabIndex = 4;
//test_picturebox.TabStop = false;
//this.Controls.Add(test_picturebox);

//int count =frm_appliance_view.count;
//MessageBox.Show(count.ToString());
//try
//{
//    if (pictureBox1.Controls != null)
//    {

//    }
//    //for(int i=1;i<=count;i++)
//    //{
//    //    if (i == 1)
//    //    {
//    //        pictureBox1.Image = Image.FromFile(frm_appliance_view.Item_Path_1);
//    //    }
//    //    else if(i==2)
//    //    {
//    //        pictureBox2.Image = Image.FromFile(frm_appliance_view.Item_Path_2);
//    //    }
//    //}

//}
//catch {
//    MessageBox.Show("no item");
//}