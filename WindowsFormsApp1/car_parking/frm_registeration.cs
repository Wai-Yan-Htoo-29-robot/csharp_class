using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.car_parking
{
    public partial class frm_registeration : Form
    {
        public frm_registeration()
        {
            InitializeComponent();
        }

        private void dt_startdate_ValueChanged(object sender, EventArgs e)
        {
            string dt = dt_startdate.Text;
            string startdate = "";
            string end_date="";
            for( int i= dt.Length - 4; i < dt.Length; i++)
            {
                end_date += dt[i];
            }
            for (int i=0;i<dt.Length-5;i++)
            {
                startdate += dt[i];
            }
            startdate +=  $"{int.Parse(end_date) + 1}"; 
            lbl_enddate.Text = startdate;
        }

        private void cbo_nrc_city_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void cbo_nrc_region_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nrc=cbo_nrc_region_no.SelectedItem.ToString();
            
            if (nrc == "1")
            {
                cbo_nrc_city.Items.Clear();
                this.cbo_nrc_city.Items.Add("BaMaNa");
                this.cbo_nrc_city.Items.Add("KhaHpaNa");
                this.cbo_nrc_city.Items.Add("DaHpaYa");
                this.cbo_nrc_city.Items.Add("AhGaYa");
                this.cbo_nrc_city.Items.Add("KaMaNa");
                this.cbo_nrc_city.Items.Add("KaMaTa");
                this.cbo_nrc_city.Items.Add("KaPaTa");
                this.cbo_nrc_city.Items.Add("KhaLaHpa");
                this.cbo_nrc_city.Items.Add("LaGaNa");
                this.cbo_nrc_city.Items.Add("MaKhaBa");
                this.cbo_nrc_city.Items.Add("MaSaNa");
                this.cbo_nrc_city.Items.Add("MaKaTa");
                this.cbo_nrc_city.Items.Add("MaMaNa");
                this.cbo_nrc_city.Items.Add("MaKaNa");
                this.cbo_nrc_city.Items.Add("MaLaNa");
                this.cbo_nrc_city.Items.Add("NaMaNa");
                this.cbo_nrc_city.Items.Add("PaWaNa");
                this.cbo_nrc_city.Items.Add("PaNaDa");
                this.cbo_nrc_city.Items.Add("PaTaAh");
                this.cbo_nrc_city.Items.Add("SaDaNa");
                this.cbo_nrc_city.Items.Add("YaKaNa");
                this.cbo_nrc_city.Items.Add("SaBaNa");
                this.cbo_nrc_city.Items.Add("SaPaBa");
                this.cbo_nrc_city.Items.Add("SaPaYa");
                this.cbo_nrc_city.Items.Add("TaNaNa");
                this.cbo_nrc_city.Items.Add("SaLaNa");
                this.cbo_nrc_city.Items.Add("TaSaLa");
                this.cbo_nrc_city.Items.Add("WaMaNA");

            }
            else if (nrc == "2")
            {
                cbo_nrc_city.Items.Clear();
                cbo_nrc_city.Items.Add("BaLaKha");
                cbo_nrc_city.Items.Add("DaMaSa");
                cbo_nrc_city.Items.Add("HpaSaNa");
                cbo_nrc_city.Items.Add("HpaYaSa");
                cbo_nrc_city.Items.Add("LaKaNa");
                cbo_nrc_city.Items.Add("MaSaNa");
                cbo_nrc_city.Items.Add("YaTaNa");
                cbo_nrc_city.Items.Add("YaThaNa");
            }
            else if (nrc == "3")
            {
                cbo_nrc_city.Items.Clear();
                cbo_nrc_city.Items.Add("BaGaLa");
                cbo_nrc_city.Items.Add("LaBaNa");
                cbo_nrc_city.Items.Add("BaAhNa");
                cbo_nrc_city.Items.Add("HpaPaNa");
                cbo_nrc_city.Items.Add("BaThaSa");
                cbo_nrc_city.Items.Add("KaMaMa");
                cbo_nrc_city.Items.Add("KaKaYa");
                cbo_nrc_city.Items.Add("KaDaNa");
                cbo_nrc_city.Items.Add("KaSaKa");
                cbo_nrc_city.Items.Add("KaDaNa");
                cbo_nrc_city.Items.Add("KaDaTa");
                cbo_nrc_city.Items.Add("LaThaNa");
                cbo_nrc_city.Items.Add("MaWaTa");
                cbo_nrc_city.Items.Add("PaKaNa");
                cbo_nrc_city.Items.Add("YaYaTha");
                cbo_nrc_city.Items.Add("SaKaLa");
                cbo_nrc_city.Items.Add("ThaTaNa");
                cbo_nrc_city.Items.Add("ThaTaKa");
                cbo_nrc_city.Items.Add("WaLaMa");
            }
            else if (nrc == "4")
            {
                cbo_nrc_city.Items.Clear();
                cbo_nrc_city.Items.Add("KaKhaNa");
                cbo_nrc_city.Items.Add("HpaLaNa");
                cbo_nrc_city.Items.Add("HaKhaNa");
                cbo_nrc_city.Items.Add("KaPaLa");
                cbo_nrc_city.Items.Add("MaTaPa");
                cbo_nrc_city.Items.Add("MaTaNa");
                cbo_nrc_city.Items.Add("PaLaWa");
                cbo_nrc_city.Items.Add("YaZaNa");
                cbo_nrc_city.Items.Add("YaKhaDa");
                cbo_nrc_city.Items.Add("SaMaNa");
                cbo_nrc_city.Items.Add("TaTaNa");
                cbo_nrc_city.Items.Add("HtaTaLa");
                cbo_nrc_city.Items.Add("TaZaNa");
            }
            else if (nrc == "5")
            {
                cbo_nrc_city.Items.Clear();
                cbo_nrc_city.Items.Add("AhYaTa");
                cbo_nrc_city.Items.Add("BaMaNa");
                cbo_nrc_city.Items.Add("KhaOuTa");
                cbo_nrc_city.Items.Add("KhaTaNa");
                cbo_nrc_city.Items.Add("HaMaLa");
                cbo_nrc_city.Items.Add("AhTaNa");
                cbo_nrc_city.Items.Add("KaLaHta");
                cbo_nrc_city.Items.Add("KaLaWa");
                cbo_nrc_city.Items.Add("KaBaLa");
                cbo_nrc_city.Items.Add("KaNaNa");
                cbo_nrc_city.Items.Add("KaThaNa");
                cbo_nrc_city.Items.Add("KaLaTa");
                cbo_nrc_city.Items.Add("KhaOuNa");
                cbo_nrc_city.Items.Add("KaLaNa");
                cbo_nrc_city.Items.Add("LaHaNa");
                cbo_nrc_city.Items.Add("LaYaNa");
                cbo_nrc_city.Items.Add("MaLaNa");
                cbo_nrc_city.Items.Add("MaKaNa");
                cbo_nrc_city.Items.Add("MaYaNa");
                cbo_nrc_city.Items.Add("MaMaTa");
                cbo_nrc_city.Items.Add("NaYaNa");
                cbo_nrc_city.Items.Add("MaMaTa");
                cbo_nrc_city.Items.Add("NaYaNa");
                cbo_nrc_city.Items.Add("NgaZaNa");
                cbo_nrc_city.Items.Add("PaLaNa");
                cbo_nrc_city.Items.Add("HpaPaNa");
                cbo_nrc_city.Items.Add("PaLaBa");
                cbo_nrc_city.Items.Add("SaKaNa");
                cbo_nrc_city.Items.Add("SaLaKa");
                cbo_nrc_city.Items.Add("YaBaNa");
                cbo_nrc_city.Items.Add("DaPaYa");
                cbo_nrc_city.Items.Add("TaMaNa");
                cbo_nrc_city.Items.Add("TaSaNa");
                cbo_nrc_city.Items.Add("HtaKhaNa");
                cbo_nrc_city.Items.Add("WaLaNa");
                cbo_nrc_city.Items.Add("WaThaNa");
                cbo_nrc_city.Items.Add("YaOuNa");
                cbo_nrc_city.Items.Add("KaMaNa");
                cbo_nrc_city.Items.Add("KhaPaNa");
            }
            else if (nrc == "6")
            {
                cbo_nrc_city.Items.Clear();
                cbo_nrc_city.Items.Add("BaPaNa");
                cbo_nrc_city.Items.Add("HtaWaNa");
                cbo_nrc_city.Items.Add("KaSaNa");
                cbo_nrc_city.Items.Add("LaLaNa");
                cbo_nrc_city.Items.Add("MaMaNa");
                cbo_nrc_city.Items.Add("PaLaNa");
                cbo_nrc_city.Items.Add("TaThaYa");
                cbo_nrc_city.Items.Add("ThaYaKha");
                cbo_nrc_city.Items.Add("YaHpaNa");
                cbo_nrc_city.Items.Add("KhaMaNa");
                cbo_nrc_city.Items.Add("MaTaNa");
                cbo_nrc_city.Items.Add("PaLaTa");
                cbo_nrc_city.Items.Add("MaAhYa");
                cbo_nrc_city.Items.Add("KaYaYa");

            }
        }
        // constructor
        Connect connect=new Connect();

        MySqlCommand command;

        private void btn_register_Click(object sender, EventArgs e)
        {
           

            string name,phno,nrc_region_no,nrc_city,nrc_citizen_id,
                nrc_no,owner_license,plate_no_char,plate_char,plate_no,
                start_date,end_date;
            name = txt_name.Text;
            phno = txt_phno.Text;
            nrc_region_no=cbo_nrc_region_no.SelectedItem.ToString();
            nrc_city=cbo_nrc_city.SelectedItem.ToString();
            nrc_citizen_id=comboBox1.SelectedItem.ToString();
            nrc_no = txt_nrc_no.Text;
            owner_license=txt_license_number.Text;
            plate_no_char=cbo_plate_no.SelectedItem.ToString();
            plate_char=cbo_palte_char.SelectedItem.ToString () ;
            plate_no=txt_plate_no.Text;
            start_date = dt_startdate.Text;
            end_date = lbl_enddate.Text;

            string query;
            query = "insert into user_registration(user_name,user_phno,nrc_no,user_license," +
                "car_no_plate,registration_date,expired_date) " +
                "values( '"+name+"','"+phno+"','"+$"{nrc_region_no}/{nrc_city}{nrc_citizen_id}{nrc_no}"+"'," +
                "'"+owner_license+"','"+$"{plate_no_char}{plate_char}-{plate_no}"+"','"+start_date+"','"+end_date+"' )";
            
            command = new MySqlCommand();
            //             
            command = connect.conn.CreateCommand();

            command.CommandText = query;// select 
            //
            command.ExecuteNonQuery();
            connect.conn.Close();
            txt_license_number.Clear();
            txt_name.Clear();
            txt_nrc_no.Clear();
            txt_phno.Clear();
            txt_plate_no.Clear();

            cbo_nrc_city.Items.Clear();
            cbo_nrc_region_no.Items.Clear();
            comboBox1.Items.Clear();
            cbo_palte_char.Items.Clear();
            cbo_plate_no.Items.Clear();
            dt_startdate.Text = "";
            lbl_enddate.Text = "";
        }
    }
}
