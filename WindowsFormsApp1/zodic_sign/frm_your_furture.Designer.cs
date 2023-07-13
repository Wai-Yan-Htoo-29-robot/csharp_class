namespace WindowsFormsApp1.zodic_sign
{
    partial class frm_your_furture
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_zodic_sign = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._12zodicsign;
            this.pictureBox1.Location = new System.Drawing.Point(35, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cbo_zodic_sign
            // 
            this.cbo_zodic_sign.FormattingEnabled = true;
            this.cbo_zodic_sign.Items.AddRange(new object[] {
            "Aries, ",
            "Taurus, ",
            "Gemini, ",
            "Cancer, ",
            "Leo, ",
            "Virgo, ",
            "Libra, ",
            "Scorpio, ",
            "Sagittarius, ",
            "Capricorn, ",
            "Aquarius, and ",
            "Pisces"});
            this.cbo_zodic_sign.Location = new System.Drawing.Point(736, 57);
            this.cbo_zodic_sign.Name = "cbo_zodic_sign";
            this.cbo_zodic_sign.Size = new System.Drawing.Size(172, 28);
            this.cbo_zodic_sign.TabIndex = 2;
            this.cbo_zodic_sign.SelectedIndexChanged += new System.EventHandler(this.cbo_zodic_sign_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_your_furture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_zodic_sign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_your_furture";
            this.Text = "frm_your_furture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_zodic_sign;
        private System.Windows.Forms.Button button1;
    }
}