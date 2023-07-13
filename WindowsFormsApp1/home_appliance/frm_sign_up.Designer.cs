namespace WindowsFormsApp1.home_appliance
{
    partial class frm_sign_up
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
            this.btn_signup = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llbl_already_account = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(92, 224);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(131, 29);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "Signup";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(195, 148);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(131, 26);
            this.txt_password.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(195, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(131, 26);
            this.txt_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // llbl_already_account
            // 
            this.llbl_already_account.AutoSize = true;
            this.llbl_already_account.Location = new System.Drawing.Point(260, 224);
            this.llbl_already_account.Name = "llbl_already_account";
            this.llbl_already_account.Size = new System.Drawing.Size(123, 20);
            this.llbl_already_account.TabIndex = 8;
            this.llbl_already_account.TabStop = true;
            this.llbl_already_account.Text = "Already account";
            this.llbl_already_account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_already_account_LinkClicked);
            // 
            // frm_sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 430);
            this.Controls.Add(this.llbl_already_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Name = "frm_sign_up";
            this.Text = "frm_sign_up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbl_already_account;
    }
}