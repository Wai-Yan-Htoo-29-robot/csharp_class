namespace WindowsFormsApp1.kattis
{
    partial class frm_qudrent_selection
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
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_input1
            // 
            this.txt_input1.Location = new System.Drawing.Point(207, 53);
            this.txt_input1.Name = "txt_input1";
            this.txt_input1.Size = new System.Drawing.Size(132, 26);
            this.txt_input1.TabIndex = 0;
            // 
            // txt_input2
            // 
            this.txt_input2.Location = new System.Drawing.Point(207, 105);
            this.txt_input2.Name = "txt_input2";
            this.txt_input2.Size = new System.Drawing.Size(132, 26);
            this.txt_input2.TabIndex = 1;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(207, 166);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(100, 28);
            this.btn_click.TabIndex = 2;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // frm_qudrent_selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.txt_input2);
            this.Controls.Add(this.txt_input1);
            this.Name = "frm_qudrent_selection";
            this.Text = "frm_qudrent_selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input1;
        private System.Windows.Forms.TextBox txt_input2;
        private System.Windows.Forms.Button btn_click;
    }
}