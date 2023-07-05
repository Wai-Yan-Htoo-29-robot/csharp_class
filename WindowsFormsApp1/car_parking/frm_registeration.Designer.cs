namespace WindowsFormsApp1.car_parking
{
    partial class frm_registeration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phno = new System.Windows.Forms.TextBox();
            this.cbo_nrc_region_no = new System.Windows.Forms.ComboBox();
            this.cbo_nrc_city = new System.Windows.Forms.ComboBox();
            this.txt_nrc_no = new System.Windows.Forms.TextBox();
            this.txt_license_number = new System.Windows.Forms.TextBox();
            this.txt_plate_no = new System.Windows.Forms.TextBox();
            this.cbo_palte_char = new System.Windows.Forms.ComboBox();
            this.cbo_plate_no = new System.Windows.Forms.ComboBox();
            this.dt_startdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_enddate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(97, 46);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(243, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_phno
            // 
            this.txt_phno.Location = new System.Drawing.Point(97, 78);
            this.txt_phno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phno.Name = "txt_phno";
            this.txt_phno.Size = new System.Drawing.Size(243, 26);
            this.txt_phno.TabIndex = 1;
            // 
            // cbo_nrc_region_no
            // 
            this.cbo_nrc_region_no.FormattingEnabled = true;
            this.cbo_nrc_region_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cbo_nrc_region_no.Location = new System.Drawing.Point(97, 111);
            this.cbo_nrc_region_no.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_nrc_region_no.Name = "cbo_nrc_region_no";
            this.cbo_nrc_region_no.Size = new System.Drawing.Size(39, 28);
            this.cbo_nrc_region_no.TabIndex = 2;
            this.cbo_nrc_region_no.SelectedIndexChanged += new System.EventHandler(this.cbo_nrc_region_no_SelectedIndexChanged);
            // 
            // cbo_nrc_city
            // 
            this.cbo_nrc_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nrc_city.FormattingEnabled = true;
            this.cbo_nrc_city.Location = new System.Drawing.Point(136, 111);
            this.cbo_nrc_city.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_nrc_city.Name = "cbo_nrc_city";
            this.cbo_nrc_city.Size = new System.Drawing.Size(74, 28);
            this.cbo_nrc_city.TabIndex = 3;
            this.cbo_nrc_city.SelectedIndexChanged += new System.EventHandler(this.cbo_nrc_city_SelectedIndexChanged);
            // 
            // txt_nrc_no
            // 
            this.txt_nrc_no.Location = new System.Drawing.Point(253, 112);
            this.txt_nrc_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nrc_no.Name = "txt_nrc_no";
            this.txt_nrc_no.Size = new System.Drawing.Size(88, 26);
            this.txt_nrc_no.TabIndex = 4;
            // 
            // txt_license_number
            // 
            this.txt_license_number.Location = new System.Drawing.Point(97, 147);
            this.txt_license_number.Margin = new System.Windows.Forms.Padding(2);
            this.txt_license_number.Name = "txt_license_number";
            this.txt_license_number.Size = new System.Drawing.Size(244, 26);
            this.txt_license_number.TabIndex = 5;
            // 
            // txt_plate_no
            // 
            this.txt_plate_no.Location = new System.Drawing.Point(210, 182);
            this.txt_plate_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_plate_no.Name = "txt_plate_no";
            this.txt_plate_no.Size = new System.Drawing.Size(131, 26);
            this.txt_plate_no.TabIndex = 8;
            // 
            // cbo_palte_char
            // 
            this.cbo_palte_char.FormattingEnabled = true;
            this.cbo_palte_char.Items.AddRange(new object[] {
            "R"});
            this.cbo_palte_char.Location = new System.Drawing.Point(146, 183);
            this.cbo_palte_char.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_palte_char.Name = "cbo_palte_char";
            this.cbo_palte_char.Size = new System.Drawing.Size(39, 28);
            this.cbo_palte_char.TabIndex = 7;
            // 
            // cbo_plate_no
            // 
            this.cbo_plate_no.FormattingEnabled = true;
            this.cbo_plate_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_plate_no.Location = new System.Drawing.Point(97, 183);
            this.cbo_plate_no.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_plate_no.Name = "cbo_plate_no";
            this.cbo_plate_no.Size = new System.Drawing.Size(39, 28);
            this.cbo_plate_no.TabIndex = 6;
            // 
            // dt_startdate
            // 
            this.dt_startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_startdate.Location = new System.Drawing.Point(100, 219);
            this.dt_startdate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_startdate.Name = "dt_startdate";
            this.dt_startdate.Size = new System.Drawing.Size(303, 26);
            this.dt_startdate.TabIndex = 9;
            this.dt_startdate.ValueChanged += new System.EventHandler(this.dt_startdate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "NRC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "License";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "No Plate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "End Date";
            // 
            // lbl_enddate
            // 
            this.lbl_enddate.AutoSize = true;
            this.lbl_enddate.Location = new System.Drawing.Point(93, 260);
            this.lbl_enddate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_enddate.Name = "lbl_enddate";
            this.lbl_enddate.Size = new System.Drawing.Size(80, 20);
            this.lbl_enddate.TabIndex = 17;
            this.lbl_enddate.Text = "end date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "User Registeration";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(64, 338);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(146, 34);
            this.btn_register.TabIndex = 19;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(N)",
            "(P)",
            "(E)",
            "(AMT)",
            "(T)",
            "(Tha)"});
            this.comboBox1.Location = new System.Drawing.Point(210, 111);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // frm_registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 479);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_enddate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_startdate);
            this.Controls.Add(this.txt_plate_no);
            this.Controls.Add(this.cbo_palte_char);
            this.Controls.Add(this.cbo_plate_no);
            this.Controls.Add(this.txt_license_number);
            this.Controls.Add(this.txt_nrc_no);
            this.Controls.Add(this.cbo_nrc_city);
            this.Controls.Add(this.cbo_nrc_region_no);
            this.Controls.Add(this.txt_phno);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_registeration";
            this.Text = "frm_registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phno;
        private System.Windows.Forms.ComboBox cbo_nrc_region_no;
        private System.Windows.Forms.ComboBox cbo_nrc_city;
        private System.Windows.Forms.TextBox txt_nrc_no;
        private System.Windows.Forms.TextBox txt_license_number;
        private System.Windows.Forms.TextBox txt_plate_no;
        private System.Windows.Forms.ComboBox cbo_palte_char;
        private System.Windows.Forms.ComboBox cbo_plate_no;
        private System.Windows.Forms.DateTimePicker dt_startdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_enddate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}