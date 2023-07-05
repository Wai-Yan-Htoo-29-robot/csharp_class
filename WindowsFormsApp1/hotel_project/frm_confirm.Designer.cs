namespace WindowsFormsApp1.hotel_project
{
    partial class frm_confirm
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
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_numberofguest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_numberofroom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_fees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(85, 370);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(126, 34);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date";
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Location = new System.Drawing.Point(56, 107);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(51, 20);
            this.lbl_start_date.TabIndex = 2;
            this.lbl_start_date.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Location = new System.Drawing.Point(187, 107);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(51, 20);
            this.lbl_end_date.TabIndex = 4;
            this.lbl_end_date.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of Guest";
            // 
            // lbl_numberofguest
            // 
            this.lbl_numberofguest.AutoSize = true;
            this.lbl_numberofguest.Location = new System.Drawing.Point(56, 197);
            this.lbl_numberofguest.Name = "lbl_numberofguest";
            this.lbl_numberofguest.Size = new System.Drawing.Size(51, 20);
            this.lbl_numberofguest.TabIndex = 6;
            this.lbl_numberofguest.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Number of Room";
            // 
            // lbl_numberofroom
            // 
            this.lbl_numberofroom.AutoSize = true;
            this.lbl_numberofroom.Location = new System.Drawing.Point(187, 197);
            this.lbl_numberofroom.Name = "lbl_numberofroom";
            this.lbl_numberofroom.Size = new System.Drawing.Size(51, 20);
            this.lbl_numberofroom.TabIndex = 8;
            this.lbl_numberofroom.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Room Type";
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Location = new System.Drawing.Point(56, 300);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(60, 20);
            this.lbl_room_type.TabIndex = 10;
            this.lbl_room_type.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fees";
            // 
            // lbl_fees
            // 
            this.lbl_fees.AutoSize = true;
            this.lbl_fees.Location = new System.Drawing.Point(178, 300);
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.Size = new System.Drawing.Size(60, 20);
            this.lbl_fees.TabIndex = 12;
            this.lbl_fees.Text = "label12";
            // 
            // frm_confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 419);
            this.Controls.Add(this.lbl_fees);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_room_type);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_numberofroom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_numberofguest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_end_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_start_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_confirm";
            this.Text = "frm_confirm";
            this.Load += new System.EventHandler(this.frm_confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_start_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_numberofguest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_numberofroom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_fees;
    }
}