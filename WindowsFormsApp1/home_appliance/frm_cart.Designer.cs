namespace WindowsFormsApp1.home_appliance
{
    partial class frm_cart
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
            this.btn_add_to_cart2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sub_total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_to_cart2
            // 
            this.btn_add_to_cart2.Location = new System.Drawing.Point(3, 190);
            this.btn_add_to_cart2.Name = "btn_add_to_cart2";
            this.btn_add_to_cart2.Size = new System.Drawing.Size(229, 33);
            this.btn_add_to_cart2.TabIndex = 9;
            this.btn_add_to_cart2.Text = "Add to Cart";
            this.btn_add_to_cart2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_sub_total);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_add_to_cart2);
            this.panel1.Location = new System.Drawing.Point(511, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 226);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Order Summary";
            // 
            // lbl_sub_total
            // 
            this.lbl_sub_total.AutoSize = true;
            this.lbl_sub_total.Location = new System.Drawing.Point(12, 47);
            this.lbl_sub_total.Name = "lbl_sub_total";
            this.lbl_sub_total.Size = new System.Drawing.Size(51, 20);
            this.lbl_sub_total.TabIndex = 11;
            this.lbl_sub_total.Text = "label2";
            // 
            // frm_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 654);
            this.Controls.Add(this.panel1);
            this.Name = "frm_cart";
            this.Text = "frm_cart";
            this.Load += new System.EventHandler(this.frm_cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_to_cart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_sub_total;
        private System.Windows.Forms.Label label1;
    }
}