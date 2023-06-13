namespace WindowsFormsApp1.kattis
{
    partial class frm_fizz_buzz
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
            this.txt_input1 = new System.Windows.Forms.TextBox();
            this.txt_input2 = new System.Windows.Forms.TextBox();
            this.txt_input3 = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.lbl_fizzbuzz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input1
            // 
            this.txt_input1.Location = new System.Drawing.Point(112, 77);
            this.txt_input1.Name = "txt_input1";
            this.txt_input1.Size = new System.Drawing.Size(153, 26);
            this.txt_input1.TabIndex = 0;
            // 
            // txt_input2
            // 
            this.txt_input2.Location = new System.Drawing.Point(112, 129);
            this.txt_input2.Name = "txt_input2";
            this.txt_input2.Size = new System.Drawing.Size(153, 26);
            this.txt_input2.TabIndex = 1;
            // 
            // txt_input3
            // 
            this.txt_input3.Location = new System.Drawing.Point(112, 190);
            this.txt_input3.Name = "txt_input3";
            this.txt_input3.Size = new System.Drawing.Size(153, 26);
            this.txt_input3.TabIndex = 2;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(112, 244);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(153, 38);
            this.btn_click.TabIndex = 3;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // lbl_fizzbuzz
            // 
            this.lbl_fizzbuzz.AutoSize = true;
            this.lbl_fizzbuzz.Location = new System.Drawing.Point(386, 77);
            this.lbl_fizzbuzz.Name = "lbl_fizzbuzz";
            this.lbl_fizzbuzz.Size = new System.Drawing.Size(51, 20);
            this.lbl_fizzbuzz.TabIndex = 4;
            this.lbl_fizzbuzz.Text = "label1";
            // 
            // frm_fizz_buzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 567);
            this.Controls.Add(this.lbl_fizzbuzz);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.txt_input3);
            this.Controls.Add(this.txt_input2);
            this.Controls.Add(this.txt_input1);
            this.Name = "frm_fizz_buzz";
            this.Text = "frm_fizz_buzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input1;
        private System.Windows.Forms.TextBox txt_input2;
        private System.Windows.Forms.TextBox txt_input3;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label lbl_fizzbuzz;
    }
}