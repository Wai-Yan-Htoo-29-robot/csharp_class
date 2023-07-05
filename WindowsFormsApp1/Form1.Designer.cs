namespace WindowsFormsApp1
{
    partial class frm_homes
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
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_testoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(261, 85);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(158, 38);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Reset";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_testoop
            // 
            this.btn_testoop.Location = new System.Drawing.Point(527, 97);
            this.btn_testoop.Name = "btn_testoop";
            this.btn_testoop.Size = new System.Drawing.Size(158, 38);
            this.btn_testoop.TabIndex = 1;
            this.btn_testoop.Text = "testoop";
            this.btn_testoop.UseVisualStyleBackColor = true;
            this.btn_testoop.Click += new System.EventHandler(this.btn_testoop_Click);
            // 
            // frm_homes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 337);
            this.Controls.Add(this.btn_testoop);
            this.Controls.Add(this.btn_next);
            this.Name = "frm_homes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_homes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_testoop;
    }
}

