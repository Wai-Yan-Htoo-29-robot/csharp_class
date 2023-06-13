namespace WindowsFormsApp1
{
    partial class frm_reset
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_increase = new System.Windows.Forms.Button();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_other = new System.Windows.Forms.RadioButton();
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_one_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label";
            // 
            // btn_increase
            // 
            this.btn_increase.Location = new System.Drawing.Point(47, 99);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(118, 36);
            this.btn_increase.TabIndex = 1;
            this.btn_increase.Text = "Increase";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(56, 185);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(68, 24);
            this.rbtn_male.TabIndex = 2;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(56, 246);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(82, 24);
            this.rbtn_female.TabIndex = 3;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_other
            // 
            this.rbtn_other.AutoSize = true;
            this.rbtn_other.Location = new System.Drawing.Point(56, 308);
            this.rbtn_other.Name = "rbtn_other";
            this.rbtn_other.Size = new System.Drawing.Size(71, 24);
            this.rbtn_other.TabIndex = 4;
            this.rbtn_other.TabStop = true;
            this.rbtn_other.Text = "other";
            this.rbtn_other.UseVisualStyleBackColor = true;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(56, 390);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(118, 36);
            this.btn_choose.TabIndex = 5;
            this.btn_choose.Text = "choose";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // btn_one_click
            // 
            this.btn_one_click.Location = new System.Drawing.Point(433, 214);
            this.btn_one_click.Name = "btn_one_click";
            this.btn_one_click.Size = new System.Drawing.Size(118, 36);
            this.btn_one_click.TabIndex = 6;
            this.btn_one_click.Text = "One Click";
            this.btn_one_click.UseVisualStyleBackColor = true;
            this.btn_one_click.Click += new System.EventHandler(this.btn_one_click_Click);
            // 
            // frm_reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 563);
            this.Controls.Add(this.btn_one_click);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.rbtn_other);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.btn_increase);
            this.Controls.Add(this.label1);
            this.Name = "frm_reset";
            this.Text = "frm_reset";
            this.Load += new System.EventHandler(this.frm_reset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_other;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_one_click;
    }
}